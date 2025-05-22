using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Data.SqlClient;
using POS_BACK_OFFICE;
using Font = iTextSharp.text.Font; // Burada sizin xüsusi namespace daxil olacaq (əgər varsa)

public class PdfReportExporter
{
    private readonly mssqlBaglanti sqlbaglan = new mssqlBaglanti();

    // PdfReportExporter konstruktoru
    public PdfReportExporter() { }

    // PDF faylını ixrac etmək üçün əsas metod
    public void Export(DataGridView dataGridView, string filePath)
    {
        // 1. Şirkət məlumatını al
        var companyInfo = GetCompanyInfo();

        // 2. Toplanacaq sütunları al
        var sumColumns = GetSumColumns();

        // 3. Səhifə formatını al
        bool isLandscape = GetPageFormat();

        // 4. PDF sənədi yarat
        Document document = new Document(
            isLandscape ? PageSize.A4.Rotate() : PageSize.A4,
            20, 20, 30, 30
        );

        using (FileStream stream = new FileStream(filePath, FileMode.Create))
        {
            PdfWriter.GetInstance(document, stream);
            document.Open();

            // **Şriftin düzgün yüklənməsi**
            // Arial Unicode MS şriftinin tam yolunu göstəririk
            var unicodeBaseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\arialuni.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            var titleFont = new Font(unicodeBaseFont, 16, Font.BOLD); // Arial Unicode MS şriftini istifadə et
            var normalFont = new Font(unicodeBaseFont, 12); // Arial Unicode MS şriftini istifadə et

            // Şirkət adı və tarix
            document.Add(new Paragraph(companyInfo["NAME"], titleFont));
            document.Add(new Paragraph("Tarix: " + DateTime.Now.ToString("dd.MM.yyyy"), normalFont));
            document.Add(new Paragraph(" ")); // boş sətir

            // Cədvəl
            List<DataGridViewColumn> visibleColumns = new List<DataGridViewColumn>();
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (column.Visible)
                    visibleColumns.Add(column);
            }

            PdfPTable table = new PdfPTable(visibleColumns.Count);
            table.WidthPercentage = 100;

            // Başlıqlar (HeaderText istifadə edirik)
            foreach (var column in visibleColumns)
            {
                PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, normalFont));
                headerCell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(headerCell);
            }

            // Məlumatlar
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                foreach (var column in visibleColumns)
                {
                    table.AddCell(row.Cells[column.Index].Value?.ToString() ?? "");
                }
            }

            document.Add(table);

            // Toplam hissəsi
            if (sumColumns.Count > 0)
            {
                document.Add(new Paragraph(" "));
                document.Add(new Paragraph("Toplamlar:", titleFont));

                foreach (var columnName in sumColumns)
                {
                    decimal total = 0;
                    string headerText = columnName; // default olaraq öz adını götürürük

                    // Columnun HeaderText-ni tapırıq
                    foreach (DataGridViewColumn col in dataGridView.Columns)
                    {
                        if (col.DataPropertyName == columnName || col.Name == columnName)
                        {
                            headerText = col.HeaderText;
                            break;
                        }
                    }

                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.IsNewRow) continue;
                        var value = row.Cells[columnName].Value;
                        if (value != null && decimal.TryParse(value.ToString(), out decimal decValue))
                        {
                            total += decValue;
                        }
                    }

                    document.Add(new Paragraph($"{headerText}: {total}", normalFont));
                }
            }

            document.Close();
        }
    }

    // Şirkət məlumatını əldə etmək
    private Dictionary<string, string> GetCompanyInfo()
    {
        Dictionary<string, string> info = new Dictionary<string, string>();

        using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
        {
            connection.Open();
            string query = "SELECT TOP 1 [NAME] FROM [COMPANY_INFO] WHERE STATUS = 1";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    info["NAME"] = reader["NAME"].ToString();
                }
            }
        }

        return info;
    }

    // Toplam sütunlarını əldə etmək
    private List<string> GetSumColumns()
    {
        List<string> columns = new List<string>();

        using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
        {
            connection.Open();
            string query = @"SELECT VALUE FROM APP_SETTINGS 
                             WHERE SECTION = 'PDF_EXPORT_REPORT' 
                             AND CODE = 'DOCUMENT_SUM_COLUMNS'";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string columnList = result.ToString();
                    columns.AddRange(columnList.Split(','));
                }
            }
        }

        return columns;
    }

    // Səhifə formatını (Portrait vs Landscape) əldə etmək
    private bool GetPageFormat()
    {
        using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
        {
            connection.Open();
            string query = @"SELECT VALUE FROM APP_SETTINGS 
                             WHERE SECTION = 'PDF_EXPORT_REPORT' 
                             AND CODE = 'PDF_FORMAT'";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string format = result.ToString().Trim().ToUpper();
                    return format == "L"; // L = Landscape, P = Portrait
                }
            }
        }

        return false; // Əgər tapılmasa default Portrait
    }
}

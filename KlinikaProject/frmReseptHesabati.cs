using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;
using iText.Kernel.Pdf.Canvas;
using Document = iTextSharp.text.Document;
using Paragraph = iTextSharp.text.Paragraph;
using Font = System.Drawing.Font; // Excel namespace

namespace POS_BACK_OFFICE
{
    public partial class frmReseptHesabati : Form
    {
        public frmReseptHesabati()
        {
            InitializeComponent();
        }
        private mssqlBaglanti sqlbaglan = new mssqlBaglanti();



        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgrvReseptHesabati.Rows.Count > 0) // DataGridView-də məlumat yoxlanışı
            {
                try
                {
                    // Excel tətbiqini başlat
                    Excel.Application excelApp = new Excel.Application();
                    Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                    Excel.Worksheet worksheet = workbook.Sheets[1];
                    worksheet = workbook.ActiveSheet;
                    worksheet.Name = "Kassa Hesabatı";

                    // DataGridView başlıqlarını Excel-ə əlavə et
                    for (int i = 1; i <= dgrvReseptHesabati.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i] = dgrvReseptHesabati.Columns[i - 1].HeaderText;
                    }

                    // DataGridView məlumatlarını Excel-ə əlavə et
                    for (int i = 0; i < dgrvReseptHesabati.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgrvReseptHesabati.Columns.Count; j++)
                        {
                            var cellValue = dgrvReseptHesabati.Rows[i].Cells[j].Value;
                            if (cellValue != null && cellValue.ToString() != "0") // 0-ları göstərməmək
                            {
                                worksheet.Cells[i + 2, j + 1] = cellValue.ToString();
                            }
                        }
                    }

                    // Excel-də məlumatları Table formasına çevirmək (Ctrl+T effekti)
                    Excel.Range dataRange = worksheet.UsedRange;
                    dataRange.Worksheet.ListObjects.Add(
                        Excel.XlListObjectSourceType.xlSrcRange,
                        dataRange,
                        Type.Missing,
                        Excel.XlYesNoGuess.xlYes,
                        Type.Missing
                    ).Name = "KassaHesabatTable";

                    // Table üslubu əlavə etmək
                    worksheet.ListObjects["KassaHesabatTable"].TableStyle = "TableStyleMedium9";

                    // Excel faylını istifadəçiyə saxlama yeri seçdirmək
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "Excel Files|*.xlsx;*.xls";
                    saveDialog.Title = "Excel Faylı Saxla";
                    saveDialog.FileName = "KassaHesabatı";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveDialog.FileName);
                        MessageBox.Show("Excel faylı uğurla saxlanıldı!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Excel tətbiqini bağla
                    workbook.Close(false, Type.Missing, Type.Missing);
                    excelApp.Quit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Xəta baş verdi: {ex.Message}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("DataGridView-də məlumat yoxdur!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (dgrvReseptHesabati.Rows.Count > 0) // DataGridView-də məlumat yoxlanışı
            {
                try
                {
                    // SQL-dən başlıq və footer məlumatlarını əldə et
                    string header = "";
                    string footer = "";
                    using (SqlConnection connection = new SqlConnection(this.sqlbaglan.conString))
                    {
                        connection.Open();

                        // Header üçün
                        using (SqlCommand cmd = new SqlCommand("SELECT NAME FROM company WHERE id = 1", connection))
                        {
                            header = cmd.ExecuteScalar()?.ToString() ?? "Klinika";
                        }

                        // Footer üçün
                        using (SqlCommand cmd = new SqlCommand("SELECT NAME FROM company WHERE id > 1", connection))
                        {
                            footer = cmd.ExecuteScalar()?.ToString() ?? "Footer məlumatı";
                        }
                    }

                    // SaveFileDialog açılır
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "PDF Files|*.pdf";
                    saveDialog.Title = "PDF Faylı Saxla";
                    saveDialog.FileName = "KassaHesabatı";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream stream = new FileStream(saveDialog.FileName, FileMode.Create))
                        {
                            // PDF Document yaradılır
                            iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10f, 10f, 100f, 50f);
                            iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(pdfDoc, stream);

                            // Şrift faylını tətbiqinizin Resources qovluğundan yükləyirik
                            string fontPath = Path.Combine(Application.StartupPath, "Resources", "arial.ttf"); // Şriftin yolu
                            BaseFont customFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                            iTextSharp.text.Font customTextFont = new iTextSharp.text.Font(customFont, 10);

                            // Header və Footer əlavə etmək üçün PdfPageEventHelper istifadəsi
                            writer.PageEvent = new PdfHeaderFooter(header, footer);

                            // PDF açılır
                            pdfDoc.Open();

                            // Başlıq mərkəzdə əlavə edilir
                            Paragraph title = new iTextSharp.text.Paragraph(header, customTextFont);
                            title.Alignment = Element.ALIGN_CENTER;
                            pdfDoc.Add(title);
                            pdfDoc.Add(new iTextSharp.text.Paragraph("\n"));

                            // DataGridView məlumatlarını PDF-ə əlavə et
                            PdfPTable pdfTable = new PdfPTable(dgrvReseptHesabati.Columns.Count);
                            pdfTable.WidthPercentage = 100;

                            // Sütun başlıqlarını əlavə et
                            foreach (DataGridViewColumn column in dgrvReseptHesabati.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, customTextFont));
                                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                                pdfTable.AddCell(cell);
                            }

                            // Sütun genişliklərini təyin edirik
                            // Burada Fullname sütununun genişliyini artırırıq (index 1 olduğunu qəbul edirik)
                            float[] columnWidths = new float[dgrvReseptHesabati.Columns.Count];
                            for (int i = 0; i < dgrvReseptHesabati.Columns.Count; i++)
                            {
                                if (dgrvReseptHesabati.Columns[i].HeaderText == "FullName")
                                {
                                    columnWidths[i] = 3f; // Fullname sütununun genişliyini artırırıq
                                }
                                else
                                {
                                    columnWidths[i] = 1f; // Digər sütunlar üçün standart genişlik
                                }
                            }
                            pdfTable.SetWidths(columnWidths);


                            // Sətir məlumatlarını əlavə et
                            foreach (DataGridViewRow row in dgrvReseptHesabati.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value != null && cell.Value.ToString() != "0") // 0-ları göstərməmək
                                    {
                                        pdfTable.AddCell(new Phrase(cell.Value.ToString(), customTextFont));
                                    }
                                    else
                                    {
                                        pdfTable.AddCell(""); // Boş hüceyrə
                                    }
                                }
                            }

                            // PDF sənədini əlavə edirik
                            pdfDoc.Add(pdfTable);
                            pdfDoc.Close();
                            stream.Close();

                            MessageBox.Show("PDF faylı uğurla yaradıldı!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Xəta baş verdi: {ex.Message}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("DataGridView-də məlumat yoxdur!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // Header və Footer üçün xüsusi PdfPageEventHelper sinfi
        public class PdfHeaderFooter : PdfPageEventHelper
        {
            private string _header;
            private string _footer;

            public PdfHeaderFooter(string header, string footer)
            {
                _header = header;
                _footer = footer;
            }

            // Header əlavə etmək
            public override void OnEndPage(iTextSharp.text.pdf.PdfWriter writer, Document document)
            {
                // Header mərkəzdə
                iTextSharp.text.Paragraph headerParagraph = new iTextSharp.text.Paragraph(_header, FontFactory.GetFont("Arial", 12));
                headerParagraph.Alignment = Element.ALIGN_CENTER;
                //headerParagraph.SetAbsolutePosition(270f, 800f); // yuxarıda mərkəzləşmiş

                document.Add(headerParagraph);

                // Footer əlavə etmək
                Paragraph footerParagraph = new Paragraph(_footer, FontFactory.GetFont("Arial", 10));
                footerParagraph.Alignment = Element.ALIGN_CENTER;
                //footerParagraph.SetAbsolutePosition(270f, 30f); // aşağıda mərkəzləşmiş

                document.Add(footerParagraph);
            }
        }

        private void btnRaporla_Click(object sender, EventArgs e)
        {
            // Prosedurdan gələn nəticələri saxlamaq üçün DataTable
            DataTable dt = new DataTable();

            // ComboBox-dan seçilən GroupCode dəyərini almaq
            string groupCode = cmbReseptGroup.SelectedItem?.ToString();

            try
            {
                // SQL bağlantısı açılır
                using (SqlConnection conn = new SqlConnection(this.sqlbaglan.conString))
                {
                    conn.Open();

                    // SQL komandası
                    using (SqlCommand cmd = new SqlCommand("SP_GetRecipesReport", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parametr əlavə olunur
                        cmd.Parameters.AddWithValue("@GroupCode", string.IsNullOrEmpty(groupCode) ? (object)DBNull.Value : groupCode);

                        // SQL məlumatlarını oxumaq üçün SqlDataAdapter istifadə olunur
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            // Nəticələr DataTable-ə yüklənir
                            adapter.Fill(dt);
                        }
                    }
                }

                // DataGridView-ə nəticələri əlavə etmək
                dgrvReseptHesabati.DataSource = dt;

                // CellFormatting hadisəsini qoşmaq
                dgrvReseptHesabati.CellFormatting += dgrvReseptHesabati_CellFormatting;
            }
            catch (Exception ex)
            {
                // Hər hansı bir xəta olarsa, mesaj göstərilir
                MessageBox.Show($"Xəta baş verdi: {ex.Message}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgrvReseptHesabati_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // "StokAd" sütununda "--------------------------------" olan sətrləri tapırıq
            if (dgrvReseptHesabati.Columns[e.ColumnIndex].Name == "StokAd" &&
                e.Value != null &&
                e.Value.ToString() == "--------------------------------")
            {
                // Bold və 12pt şrift tətbiq edirik
                dgrvReseptHesabati.Rows[e.RowIndex].DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                dgrvReseptHesabati.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void cmbReseptGroup_Enter(object sender, EventArgs e)
{
    try
    {
        // SQL bağlantısını açırıq
        using (SqlConnection conn = new SqlConnection(this.sqlbaglan.conString))
        {
            conn.Open();

            // Recipes cədvəlindən GroupCode dəyərlərini almaq üçün SQL sorğusu
            string query = "SELECT DISTINCT GroupCode FROM Recipes";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // ComboBox-u təmizləyirik
                    cmbReseptGroup.Items.Clear();

                    // Hər bir GroupCode-u ComboBox-a əlavə edirik
                    while (reader.Read())
                    {
                        cmbReseptGroup.Items.Add(reader["GroupCode"].ToString());
                    }
                }
            }
        }
    }
    catch (Exception ex)
    {
        // Hər hansı bir xəta olarsa, mesaj göstəririk
        MessageBox.Show($"Xəta baş verdi: {ex.Message}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

    }
}

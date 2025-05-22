using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Zuby.ADGV;
using DataTable = System.Data.DataTable;
using Point = System.Drawing.Point;
using ScrollBars = System.Windows.Forms.ScrollBars;
using Font = System.Drawing.Font;
using OfficeOpenXml;
using OfficeOpenXml.Style; // Bunu əlavə edin!
using System.Drawing;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace POS_BACK_OFFICE
{
    public partial class frmLiveStockBalance : Form
    {
        public frmLiveStockBalance()
        {
            InitializeComponent();
        }
        private mssqlBaglanti sqlbaglan = new mssqlBaglanti();

        private void frmLiveStockBalance_Load(object sender, EventArgs e)
        {

        }

        private DataTable GetInventoryData()
        {
            // SQL bağlantısı və prosedurun icrası
            using (SqlConnection connection = new SqlConnection(this.sqlbaglan.conString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SP_Report_Get_Live_InventoryData", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parametri əlavə edirik
                    command.Parameters.AddWithValue("@EndDate", DateTime.Now);

                    // DataAdapter ilə məlumatı DataTable-a yükləyirik
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        private void btnUpdateLiveStockBalance_Click(object sender, EventArgs e)
        {
            // SP-dən məlumatı alırıq
            DataTable dt = GetInventoryData(); // SP-dən məlumat gətirən metod

            // BindingSource yaradıb DataGridView-ə bağlayırıq
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            addgrvLiveStockBalance.DataSource = bs;
        }

        private void addgrvLiveStockBalance_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateStockInfo();
            UpdateFooterTotals();
        }

        private void addgrvLiveStockBalance_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateStockInfo();
            UpdateFooterTotals();
        }

        private void addgrvLiveStockBalance_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateStockInfo();
            UpdateFooterTotals();
        }

        private void UpdateStockInfo()
        {
            int stockCount = 0;
            decimal totalStockAmount = 0;

            foreach (DataGridViewRow row in addgrvLiveStockBalance.Rows)
            {
                if (!row.IsNewRow) // Yeni satır yoxdursa
                {
                    stockCount++; // InventoryItem_Id sütunu hər bir sıra üçün sayılır

                    if (row.Cells["Canli_Qaliq_Mebleg"].Value != null)
                    {
                        decimal value;
                        if (decimal.TryParse(row.Cells["Canli_Qaliq_Mebleg"].Value.ToString(), out value))
                        {
                            totalStockAmount += value;
                        }
                    }
                }
            }

            lblStockCount.Text = stockCount.ToString();
            lblTotalStockAmount.Text = totalStockAmount.ToString("N2"); // İki onluq rəqəmlə göstərmək üçün
        }

        // Cəmləri yeniləyən funksiya

        //Fotter Uchun
        private void chkFooterIncl_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFooterIncl.Checked)
            {
                InitializeFooterGrid(); // Əgər işarələnibsə, footeri göstər
            }
            else
            {
                RemoveFooterGrid(); // Əgər işarə götürülübsə, footeri sil
            }
        }

        private void RemoveFooterGrid()
        {
            if (footerGrid != null)
            {
                this.Controls.Remove(footerGrid); // Formdan çıxar
                footerGrid.Dispose(); // Xatirədən sil
                footerGrid = null; // Obyekti null et ki, yenidən istifadə oluna bilsin
            }
        }

        private void InitializeFooterGrid()
        {
            footerGrid = new DataGridView();
            footerGrid.Location = new Point(addgrvLiveStockBalance.Location.X, addgrvLiveStockBalance.Location.Y + addgrvLiveStockBalance.Height - 3);
            footerGrid.Size = new Size(addgrvLiveStockBalance.Width, 43);
            footerGrid.ReadOnly = true;
            footerGrid.AllowUserToAddRows = false;
            footerGrid.AllowUserToDeleteRows = false;
            footerGrid.RowHeadersVisible = false;
            footerGrid.ColumnHeadersVisible = false;
            footerGrid.ScrollBars = ScrollBars.None;
            footerGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Make the text in cells bold
            footerGrid.DefaultCellStyle.Font = new Font(footerGrid.Font, FontStyle.Bold);

            // Make the column headers bold and set background color to dark yellow
            footerGrid.ColumnHeadersDefaultCellStyle.Font = new Font(footerGrid.Font, FontStyle.Bold);
            footerGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGoldenrod; // Dark yellow color

            // Optional: If you want to change the font color of the column headers as well
            footerGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            footerGrid.ColumnHeadersVisible = true;

            // **Sütunları ancaq addgrvLiveStockBalance DataSource təyin ediləndən sonra kopyalayırıq**
            if (addgrvLiveStockBalance.Columns.Count > 0)
            {
                foreach (DataGridViewColumn col in addgrvLiveStockBalance.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    footerGrid.Columns.Add(col.Clone() as DataGridViewColumn);
                }
            }
            else
            {
                MessageBox.Show("Sütunlar hələ yaradılmayıb!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Footer üçün sətir əlavə et
            footerGrid.Rows.Add();

            this.Controls.Add(footerGrid);
        }
        private void UpdateFooterTotals()
        {
            if (footerGrid == null || footerGrid.Rows.Count == 0) return; // Əgər sətir yoxdursa, çıx

            for (int i = 0; i < addgrvLiveStockBalance.Columns.Count; i++)
            {
                // **Əgər sütun növü string və ya boşdursa, keç**
                if (addgrvLiveStockBalance.Columns[i].ValueType == typeof(string) ||
                    addgrvLiveStockBalance.Columns[i].ValueType == null)
                {
                    continue; // Heç bir əməliyyat etmədən növbəti sütuna keç
                }

                decimal total = 0;

                foreach (DataGridViewRow row in addgrvLiveStockBalance.Rows)
                {
                    if (row.Cells[i].Value != null && decimal.TryParse(row.Cells[i].Value.ToString(), out decimal value))
                    {
                        total += value;
                    }
                }

                // **Xətanın qarşısını almaq üçün yoxlama**
                if (i < footerGrid.Columns.Count)
                {
                    footerGrid.Rows[0].Cells[i].Value = total.ToString("N2"); // Məbləği formatla
                }
            }
        }

        private void btnExceleGonder_Click(object sender, EventArgs e)
        {
            try
            {
                // Faylın yerini seçmək üçün SaveFileDialog açırıq
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Excel faylını harada saxlamaq istəyirsiniz?";
                    saveFileDialog.FileName = "Stok Qalıqları Canlı.xlsx"; // Default fayl adı

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        // Lisenziya kontekstini qeyd edirik (pulsuz istifadə üçün)
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                        using (ExcelPackage excelPackage = new ExcelPackage())
                        {
                            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Stok Qalıqları");

                            // Başlıqları yazırıq
                            for (int col = 0; col < addgrvLiveStockBalance.Columns.Count; col++)
                            {
                                worksheet.Cells[1, col + 1].Value = addgrvLiveStockBalance.Columns[col].HeaderText;
                                worksheet.Cells[1, col + 1].Style.Font.Bold = true;
                                worksheet.Cells[1, col + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                                worksheet.Cells[1, col + 1].Style.Fill.BackgroundColor.SetColor(Color.DarkGoldenrod);
                                worksheet.Cells[1, col + 1].Style.Font.Color.SetColor(Color.White);
                            }

                            // Məlumatları yazırıq
                            for (int row = 0; row < addgrvLiveStockBalance.Rows.Count; row++)
                            {
                                for (int col = 0; col < addgrvLiveStockBalance.Columns.Count; col++)
                                {
                                    object value = addgrvLiveStockBalance.Rows[row].Cells[col].Value;

                                    // Əgər dəyər rəqəm tipidirsə, onu numeric formatda yazırıq
                                    if (value != null && decimal.TryParse(value.ToString(), out decimal numericValue))
                                    {
                                        worksheet.Cells[row + 2, col + 1].Value = numericValue;
                                        worksheet.Cells[row + 2, col + 1].Style.Numberformat.Format = "#,##0.00"; // Formatlama (minlik ayırıcı və iki onluq)
                                    }
                                    else
                                    {
                                        worksheet.Cells[row + 2, col + 1].Value = value?.ToString();
                                    }
                                }
                            }

                            // Numeric sütunların cəmini əlavə edirik
                            int totalRow = addgrvLiveStockBalance.Rows.Count + 2; // Cəmi üçün olan sətir

                            for (int col = 0; col < addgrvLiveStockBalance.Columns.Count; col++)
                            {
                                // Yalnız rəqəm olan sütunlara cəmi əlavə edirik
                                if (decimal.TryParse(addgrvLiveStockBalance.Rows[0].Cells[col].Value?.ToString(), out _))
                                {
                                    worksheet.Cells[totalRow, col + 1].Formula = $"SUM({worksheet.Cells[2, col + 1].Address}:{worksheet.Cells[totalRow - 1, col + 1].Address})";
                                    worksheet.Cells[totalRow, col + 1].Style.Font.Bold = true;
                                    worksheet.Cells[totalRow, col + 1].Style.Numberformat.Format = "#,##0.00"; // Minlik ayırıcı
                                }
                            }

                            // Seçilmiş fayl yerinə yazırıq
                            File.WriteAllBytes(filePath, excelPackage.GetAsByteArray());

                            MessageBox.Show("Excel faylı uğurla yaradıldı:\n" + filePath, "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveAsPDF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF sənədi (*.pdf)|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PdfReportExporter exporter = new PdfReportExporter(); // PdfReportExporter instansiyası yaradılır
                    exporter.Export(addgrvLiveStockBalance, saveFileDialog.FileName); // PDF-i yuxarıda qeyd etdiyimiz şəkildə ixrac edirik

                    MessageBox.Show("PDF sənədi uğurla yaradıldı!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        }
}


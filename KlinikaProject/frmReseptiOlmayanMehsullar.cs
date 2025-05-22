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
    public partial class frmReseptiOlmayanMehsullar : Form
    {
        public frmReseptiOlmayanMehsullar()
        {
            InitializeComponent();
        }
        private mssqlBaglanti sqlbaglan = new mssqlBaglanti();
        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadReseptiOlmayanMehsullar();
        }

        private void LoadReseptiOlmayanMehsullar()
        {
            string groupCode = txtMehsulAd.Text.Trim(); // İstifadəçinin daxil etdiyi dəyər

            string query = "SELECT * FROM VW_ReseptiOlmayanMehsullar";

            if (!string.IsNullOrEmpty(groupCode))
            {
                query += " WHERE LOWER(GroupCode) LIKE LOWER(@GroupCode)";
            }

            using (SqlConnection conn = new SqlConnection(this.sqlbaglan.conString)) // Bağlantı sinfindən gəlir
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(groupCode))
                    {
                        cmd.Parameters.AddWithValue("@GroupCode", "%" + groupCode + "%"); // LIKE %text% şəklində olur
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    addgrvReseptiOlmayanList.DataSource = dt; // Data yeniləndikdən sonra rənglər itir

                    // 📌 Griddə neçə satır olduğunu göstər
                    lblMenuItemCount.Text = "Məhsul Sayı: " + dt.Rows.Count.ToString();
                }
            }

            // 📌 Data yeniləndikdən sonra rəngləri yenidən tətbiq et
            ColorRows();
        }

        // 📌 DataGridView-də sətirlərin yazı rəngini dəyişən metod
        private void ColorRows()
        {
            foreach (DataGridViewRow row in addgrvReseptiOlmayanList.Rows)
            {
                if (row.Cells["HeYox"].Value != null) // NULL yoxlaması
                {
                    string status = row.Cells["HeYox"].Value.ToString().Trim(); // Dəyəri götür və boşluqları sil

                    if (status == "Resept Yoxdur")
                    {
                        row.DefaultCellStyle.ForeColor = Color.Red; // 🔴 Qırmızı yazı
                    }
                    else if (status == "Resept Var")
                    {
                        row.DefaultCellStyle.ForeColor = Color.Green; // 🟢 Yaşıl yazı
                    }
                }
            }
        }

        private void btnExceleGonder_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Excel faylını harada saxlamaq istəyirsiniz?";
                    saveFileDialog.FileName = "Resept Yoxlama.xlsx"; // 📌 Faylın adını dəyişdik

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                        using (ExcelPackage excelPackage = new ExcelPackage())
                        {
                            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Resept Yoxlama");

                            // 📌 Başlıqları Excel-ə yazırıq
                            for (int col = 0; col < addgrvReseptiOlmayanList.Columns.Count; col++)
                            {
                                worksheet.Cells[1, col + 1].Value = addgrvReseptiOlmayanList.Columns[col].HeaderText;
                                worksheet.Cells[1, col + 1].Style.Font.Bold = true;
                                worksheet.Cells[1, col + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                                worksheet.Cells[1, col + 1].Style.Fill.BackgroundColor.SetColor(Color.DarkGoldenrod);
                                worksheet.Cells[1, col + 1].Style.Font.Color.SetColor(Color.White);
                            }

                            // 📌 DataGridView məlumatlarını Excel-ə yazırıq
                            for (int row = 0; row < addgrvReseptiOlmayanList.Rows.Count; row++)
                            {
                                for (int col = 0; col < addgrvReseptiOlmayanList.Columns.Count; col++)
                                {
                                    object value = addgrvReseptiOlmayanList.Rows[row].Cells[col].Value;
                                    worksheet.Cells[row + 2, col + 1].Value = value?.ToString();

                                    // 📌 DataGridView-də olan rəngləri Excel-ə tətbiq edirik
                                    Color foreColor = addgrvReseptiOlmayanList.Rows[row].Cells[col].Style.ForeColor;
                                    if (foreColor != Color.Empty)
                                    {
                                        worksheet.Cells[row + 2, col + 1].Style.Font.Color.SetColor(foreColor);
                                    }
                                }
                            }

                            // 📌 Seçilmiş fayl yerinə yazırıq
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

        private void btnCreateAutoRecipe_Click(object sender, EventArgs e)
        {

        }
    }
}

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
using Zuby.ADGV;

namespace POS_BACK_OFFICE
{
    public partial class frmSaleList : Form
    {
        public static string SendUserID = "";
        public static string SendUsername = "";
        public frmSaleList()
        {
            InitializeComponent();
        }
        private mssqlBaglanti sqlbaglan = new mssqlBaglanti();
        private void frmSaleList_Load(object sender, EventArgs e)
        {
            lblUserName.Text = GirishFormu.SendUsername.ToString();
            lblUserId.Text = GirishFormu.SendUserID.ToString();

            // **Sütunları "ReadOnly" et (redaktəni qapat)**
            foreach (DataGridViewColumn column in adDgrvDocumentList.Columns)
            {
                column.ReadOnly = true;
            }

            foreach (DataGridViewColumn column in adDgrvDocumentDetail.Columns)
            {
                column.ReadOnly = true;
            }
            dtpDocStartDate.Value = DateTime.Today;
            dtpDocEndDate.Value = DateTime.Today;
            LoadDocumentList();
            LoadDocumentDetails(0);
            adDgrvDocumentDetail.FilterAndSortEnabled = false;




            DataGridViewTheme myTheme = new DataGridViewTheme();

            // Sənəd siyahısı üçün tətbiq et
            ThemeManager.ApplyTheme(adDgrvDocumentList, myTheme);

            // Sənəd detalları üçün tətbiq et
            ThemeManager.ApplyTheme(adDgrvDocumentDetail, myTheme);



        }
        private void frmSaleList_Activated(object sender, EventArgs e)
        {
            // Aktiv olanda hazırki seçilmiş DOCNO dəyərini yadda saxla
            string selectedDocNo = null;
            if (adDgrvDocumentList.CurrentRow != null)
            {
                selectedDocNo = adDgrvDocumentList.CurrentRow.Cells["DOCNO"].Value?.ToString();
            }

            // DOCNO dəyərini ötür
            LoadDocumentList(selectedDocNo);
        }





        private void createNewDoc_Click(object sender, EventArgs e)
        {
            frmSale frm = new frmSale();
            frm.StartPosition = FormStartPosition.CenterScreen;  // Ekranın ortasında aç
            frm.WindowState = FormWindowState.Normal;           // Əmin ol ki, minimizelənməyib
            frm.TopMost = true;                                 // Ən üstdə göstər
            frm.Show();                                         // Və ya ShowDialog() əgər modal olmalıdırsa

        }

        private void LoadDocumentList(string selectedDocNo = null)
        {
            int? docTypeId = string.IsNullOrEmpty(txtDocTypeId.Text) ? (int?)null : Convert.ToInt32(txtDocTypeId.Text);
            DateTime startDate = dtpDocStartDate.Value.Date;
            DateTime endDate = dtpDocEndDate.Value.Date;

            using (SqlConnection connection = new SqlConnection(this.sqlbaglan.conString))
            {
                connection.Open();

                using (SqlCommand cmdSetting = new SqlCommand("SELECT TOP 1 VALUE FROM APP_SETTINGS WHERE CODE = 'SALE_DOC_TYPE'", connection))
                {
                    object result = cmdSetting.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int parsedValue))
                    {
                        docTypeId = parsedValue;
                    }
                }

                using (SqlCommand cmd = new SqlCommand("SP_GetDocumentList", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DocTypeId", (object)docTypeId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    adDgrvDocumentList.DataSource = dt;

                    // 🔁 Seçilmiş DOCNO-ya fokuslan
                    if (!string.IsNullOrEmpty(selectedDocNo))
                    {
                        foreach (DataGridViewRow row in adDgrvDocumentList.Rows)
                        {
                            if (row.Cells["DOCNO"].Value?.ToString() == selectedDocNo)
                            {
                                row.Selected = true;

                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Visible)
                                    {
                                        adDgrvDocumentList.CurrentCell = cell;
                                        break;
                                    }
                                }

                                break;
                            }
                        }
                    }
                }
            }
        }



        private void txtDocTypeId_TextChanged(object sender, EventArgs e)
        {
            LoadDocumentList();
        }

        private void dtpDocStartDate_ValueChanged(object sender, EventArgs e)
        {
            LoadDocumentList();
        }

        private void dtpDocEndDate_ValueChanged(object sender, EventArgs e)
        {
            LoadDocumentList();
        }

        private void adDgrvDocumentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int doc_no = Convert.ToInt32(adDgrvDocumentList.Rows[e.RowIndex].Cells["DOCNO"].Value);

                // Sənəd detalları üçün məlumat yükləyirik
                using (SqlConnection connection = new SqlConnection(this.sqlbaglan.conString))
                {
                    connection.Open();

                    // Detalları göstərmək üçün
                    using (SqlCommand cmd = new SqlCommand("SP_GetDocumentDetailByDocNo", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DOC_NO", doc_no);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        adDgrvDocumentDetail.DataSource = dt;
                    }

                    // Stok cəmlərini göstərmək üçün
                    using (SqlCommand cmdStock = new SqlCommand(@"
                SELECT STOCK_ID, STOCK_NAME, COUNT(STOCK_ID) AS BOX_COUNT, SUM(TOTAL_QUANTITY) AS TOTAL,DEFAULT_PRICE PRICE,SUM(TOTAL_AMOUNT) TOTAL_SUM
                FROM VW_DOCUMENT_DETAIL
                WHERE DOC_NO = @DOC_NO
                GROUP BY STOCK_ID, STOCK_NAME,DEFAULT_PRICE", connection))
                    {
                        cmdStock.Parameters.AddWithValue("@DOC_NO", doc_no);

                        SqlDataAdapter daStock = new SqlDataAdapter(cmdStock);
                        DataTable dtStock = new DataTable();
                        daStock.Fill(dtStock);

                        adDgrvDocumentDetailStockSum.DataSource = dtStock;
                    }
                }

                UpdateTotals(); // Əgər ümumi cəmlər üçün əlavə funksiya varsa, onu da çağırırıq
            }
        }

        private void UpdateTotals()
        {
            decimal totalQuantity = 0;
            decimal totalAmount = 0;
            decimal subtotal = 0;

            // DataGridView-dəki bütün sətirləri yoxlayaq
            foreach (DataGridViewRow row in adDgrvDocumentDetail.Rows)
            {
                if (row.IsNewRow) continue;  // Yenisini nəzərə almayın

                // Hüceyrə dəyərlərini əldə edirik
                decimal quantity = Convert.ToDecimal(row.Cells["TOTAL_QUANTITY"].Value ?? 0);
                decimal defaultPrice = Convert.ToDecimal(row.Cells["DEFAULT_PRICE"].Value ?? 0);
                decimal totalAmountPerRow = Convert.ToDecimal(row.Cells["TOTAL_AMOUNT"].Value ?? 0);

                // Cəmləri hesablayırıq
                totalQuantity += quantity;
                totalAmount += totalAmountPerRow;
                subtotal += quantity * defaultPrice;
            }

            // Cəmləri `Label`-lərə yerləşdiririk
            lblTotalAmount.Text = $"Satış məbləğ: {totalAmount}";

            lblTotalAmount.Font = new Font("Arial", 12, FontStyle.Bold);
            lblTotalAmount.ForeColor = Color.Red;
            lblTotalAmount.BackColor = Color.Transparent;
            lblTotalAmount.TextAlign = ContentAlignment.MiddleLeft;  // Mətni sola düzəldirik
            lblTotalAmount.Padding = new Padding(0, 0, 0, 0);  // Sola bir az boşluq əlavə edirik (sol tərəfə 10px boşluq)

            // Label-lərin daha gözəl görünməsi üçün əlavə effektlər
            lblTotalAmount.MouseEnter += (sender, e) => { lblTotalAmount.ForeColor = Color.DarkRed; };
            lblTotalAmount.MouseLeave += (sender, e) => { lblTotalAmount.ForeColor = Color.Red; };
        }





        private void LoadDocumentDetails(int doc_no)
        {
            using (SqlConnection connection = new SqlConnection(this.sqlbaglan.conString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetDocumentDetailByDocNo", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DOC_NO", doc_no);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    adDgrvDocumentDetail.DataSource = dt;  // Detalları adDgrvDocumentDetail DataGridView-də göstəririk
                }
            }
        }
        private void btnDocEdit_Click(object sender, EventArgs e)
        {
            // Redaktə modunu aktivləşdir
            DocumentDetailActionsForEdit();

            // Yadda saxla düyməsini aktiv et
            btnSave.Enabled = true;
            adDgrvDocumentDetail.ReadOnly = false;
            adDgrvDocumentDetailStockSum.ReadOnly = false;

            // Düzəlişin edildiyini göstərmək üçün vizual dəyişikliklər
            btnDocEdit.BackColor = Color.Orange;   // Rəngi narıncı et
            btnDocEdit.ForeColor = Color.White;    // Mətnin rəngi ağ olsun
            btnDocEdit.Text = "Redaktə Modu ✅";    // Düymənin adını dəyiş

            // Əgər istəyirsinizsə, düyməni deaktiv edə bilərsiniz ki, təkrar basılmasın:
            btnDocEdit.Enabled = false;

            // **DatagridView-lərin redaktə moduna keçməsi üçün rəng dəyişdirmə**
            adDgrvDocumentList.DefaultCellStyle.BackColor = Color.LightYellow;  // Yüngül sarı rəng
            adDgrvDocumentList.DefaultCellStyle.ForeColor = Color.Black;        // Mətni qara rəng et

            adDgrvDocumentDetail.DefaultCellStyle.BackColor = Color.LightYellow; // Yüngül sarı rəng
            adDgrvDocumentDetail.DefaultCellStyle.ForeColor = Color.Black;       // Mətni qara rəng et

            // Sütunların redaktə edilə biləcəyini göstərmək üçün onlar aktiv edilə bilər (bu hissəni tənzimləyə bilərsiniz)
            foreach (DataGridViewColumn column in adDgrvDocumentList.Columns)
            {
                column.ReadOnly = false; // Sütunları redaktə edilə bilən et
            }

            foreach (DataGridViewColumn column in adDgrvDocumentDetail.Columns)
            {
                column.ReadOnly = false; // Sütunları redaktə edilə bilən et
            }
        }


        // **Sinif səviyyəsində dəyişənlər**
        private DataTable unitsTable = new DataTable();
        private bool isCellValueChanging = false; // Sonsuz döngünün qarşısını almaq üçün

        private void DocumentDetailActionsForEdit()
        {
            using (SqlConnection connection = new SqlConnection(this.sqlbaglan.conString))
            {
                connection.Open();

                // **Bütün sütunları read-only et, istisna edilənlərdən başqa**
                foreach (DataGridViewColumn column in adDgrvDocumentDetail.Columns)
                {
                    column.ReadOnly = true;
                }

                // **İcazə verilən sütunlar**
                string[] editableColumns = { "QUANTITY", "DEFAULT_PRICE", "PURCHASE_UNIT_NAME", "cmbPurchaseUnitName", "STATUS" };
                foreach (string colName in editableColumns)
                {
                    if (adDgrvDocumentDetail.Columns.Contains(colName))
                        adDgrvDocumentDetail.Columns[colName].ReadOnly = false;
                }

                // **UNITS cədvəlindən məlumatları gətir və global `unitsTable`-ı yenilə**
                unitsTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT ID, NAME, MULTIPLIER FROM UNITS WHERE MAIN_UNIT != 1", connection);
                adapter.Fill(unitsTable);

                // **ComboBox-a məlumatları doldur**
                if (adDgrvDocumentDetail.Columns["cmbPurchaseUnitName"] is DataGridViewComboBoxColumn purchaseUnitColumn)
                {
                    purchaseUnitColumn.DataSource = unitsTable;
                    purchaseUnitColumn.DisplayMember = "NAME";
                    purchaseUnitColumn.ValueMember = "ID";
                }

                // **CellValueChanged eventini tək bir dəfə qoş**
                adDgrvDocumentDetail.CellValueChanged -= DocumentDetail_CellValueChanged;
                adDgrvDocumentDetail.CellValueChanged += DocumentDetail_CellValueChanged;

                connection.Close();
            }
        }

        // **CellValueChanged hadisəsini ayrıca metod kimi yazırıq!**
        private void DocumentDetail_CellValueChanged(object sender, DataGridViewCellEventArgs ev)
        {
            if (isCellValueChanging) return; // Sonsuz döngünün qarşısını almaq üçün

            try
            {
                if (ev.RowIndex < 0 || ev.ColumnIndex < 0) return;

                DataGridViewRow row = adDgrvDocumentDetail.Rows[ev.RowIndex];

                // **Əgər "STATUS" sütunu dəyişilibsə**
                if (adDgrvDocumentDetail.Columns[ev.ColumnIndex].Name == "STATUS")
                {
                    bool isDeleted = Convert.ToBoolean(row.Cells["STATUS"].Value ?? false);
                    row.DefaultCellStyle.BackColor = isDeleted ? Color.Red : Color.White; // Seçiləndə qırmızı, seçilməyəndə ağ
                    return; // Qalan hesablamaları etmədən çıxırıq
                }

                // **Dəyərləri al**
                decimal quantity = Convert.ToDecimal(row.Cells["QUANTITY"].Value ?? 0);
                decimal price = Convert.ToDecimal(row.Cells["DEFAULT_PRICE"].Value ?? 0);
                decimal totalQuantity = quantity; // Default olaraq TotalQuantity = Quantity

                // **MULTIPLIER-ı əldə et və TotalQuantity yenilə**
                object selectedValue = row.Cells["cmbPurchaseUnitName"].Value;
                if (selectedValue != null && selectedValue != DBNull.Value && int.TryParse(selectedValue.ToString(), out int purchaseUnitId))
                {
                    DataRow[] selectedUnit = unitsTable.Select($"ID = {purchaseUnitId}");
                    if (selectedUnit.Length > 0)
                    {
                        decimal multiplier = Convert.ToDecimal(selectedUnit[0]["MULTIPLIER"]);
                        isCellValueChanging = true;
                        row.Cells["PURCHASE_UNIT"].Value = purchaseUnitId; // ID yenilə
                        isCellValueChanging = false;

                        totalQuantity = Math.Round(quantity * multiplier, 2);
                    }
                }

                row.Cells["TOTAL_QUANTITY"].Value = totalQuantity; // **TotalQuantity yenilə**
                decimal totalPrice = totalQuantity * price; // **Hesablamalar TotalQuantity üzərindən getsin**

                isCellValueChanging = true; // Sonsuz döngünün qarşısını al

                // **TotalAmount-u yenilə**
                decimal finalAmount = Math.Round(totalPrice - 0, 2);
                row.Cells["TOTAL_AMOUNT"].Value = finalAmount;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isCellValueChanging = false; // Hər ehtimala qarşı yenidən false edirik
            }

            UpdateTotals();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(this.sqlbaglan.conString))
            {
                connection.Open();

                int docNo = 0;

                if (adDgrvDocumentDetail.Rows.Count > 0 && adDgrvDocumentDetail.Rows[0].Cells["DOC_NO"].Value != null)
                {
                    docNo = Convert.ToInt32(adDgrvDocumentDetail.Rows[0].Cells["DOC_NO"].Value);
                }

                var row = adDgrvDocumentDetail.CurrentRow;
                if (row != null && row.Cells["DETAIL_ID"].Value != null && row.Cells["DOC_NO"].Value != null)
                {
                    int detailId = Convert.ToInt32(row.Cells["DETAIL_ID"].Value);
                    bool isDeleted = row.Cells["status"].Value is bool value && value;

                    using (SqlCommand cmd = new SqlCommand("SP_UpdateDocumentDetails", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@DocNo", docNo);
                        cmd.Parameters.AddWithValue("@DetailId", detailId);
                        cmd.Parameters.AddWithValue("@Quantity", Convert.ToDecimal(row.Cells["QUANTITY"].Value ?? 0));
                        cmd.Parameters.AddWithValue("@TotalQuantity", Convert.ToDecimal(row.Cells["TOTAL_QUANTITY"].Value ?? 0));
                        cmd.Parameters.AddWithValue("@DefaultPrice", Convert.ToDecimal(row.Cells["DEFAULT_PRICE"].Value ?? 0));
                        cmd.Parameters.AddWithValue("@PurchaseUnit", Convert.ToInt32(row.Cells["PURCHASE_UNIT"].Value ?? 0));
                        decimal totalAmount = Convert.ToDecimal(row.Cells["TOTAL_AMOUNT"].Value ?? 0);
                        cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        cmd.Parameters.AddWithValue("@Deleted", isDeleted);

                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows == 0)
                        {
                            MessageBox.Show("Heç bir sətir yenilənmədi. Parametrləri yoxlayın.", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    // Başlıq cədvəlini yenilə
                    using (SqlCommand cmd = new SqlCommand("SP_UpdateDocumentHeader", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DocNo", docNo);
                        cmd.Parameters.AddWithValue("@UserId", lblUserId.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                connection.Close();
            }

            MessageBox.Show("Seçilmiş sətr uğurla yeniləndi!", "Uğur", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Redaktə rejimindən çıx
            btnDocEdit.BackColor = SystemColors.Control;
            btnDocEdit.ForeColor = SystemColors.ControlText;
            btnDocEdit.Text = "DÜZƏLİŞ ✏️";
            btnDocEdit.Enabled = true;

            btnSave.Enabled = false;

            adDgrvDocumentList.DefaultCellStyle.BackColor = SystemColors.Window;
            adDgrvDocumentList.DefaultCellStyle.ForeColor = SystemColors.ControlText;

            adDgrvDocumentDetail.DefaultCellStyle.BackColor = SystemColors.Window;
            adDgrvDocumentDetail.DefaultCellStyle.ForeColor = SystemColors.ControlText;

            foreach (DataGridViewColumn column in adDgrvDocumentList.Columns)
            {
                column.ReadOnly = true;
            }

            foreach (DataGridViewColumn column in adDgrvDocumentDetail.Columns)
            {
                column.ReadOnly = true;
            }

            LoadDocumentList();
        }

        private void btnSaveAsPDF_Click(object sender, EventArgs e)
        {
            var settings = LoadAppSettingsFromDB(); // DB-dən AppSetting-ləri yükləyirsən

            var exporter = new PDFExporter(settings);

            string prefix = "DOCUMENTDETAIL";

            var headerFieldMap = exporter.GetHeaderFieldMap(prefix);
            var headerValues = new Dictionary<string, string>();

            // Header qiymətləri toplamağa davam edirik
            foreach (var key in headerFieldMap.Keys)
            {
                // DataPropertyName-i əsas götürərək uyğun Name-i tapırıq
                var column = adDgrvDocumentList.Columns
                    .Cast<DataGridViewColumn>()
                    .FirstOrDefault(c => c.DataPropertyName == key);

                if (column != null)
                {
                    var value = adDgrvDocumentList.CurrentRow?.Cells[column.Name]?.Value?.ToString();
                    headerValues[key] = value ?? "";
                }
                else
                {
                    headerValues[key] = ""; // Column tapılmayıbsa boş saxla
                }
            }

            // Fayl seçim dialoqunu açırıq
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf"; // Yalnız PDF faylları seçilsin
            saveFileDialog.Title = "Faylın saxlanacağı yeri seçin";
            saveFileDialog.FileName = $"faktura_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"; // Varsayılan fayl adı

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName; // İstifadəçi seçdiyi fayl yolunu alırıq

                // PDF-yə ixrac edirik
                exporter.ExportToPDF(adDgrvDocumentDetailStockSum, prefix, filePath, headerValues);

                // PDF faylının uğurla saxlandığını bildirən mesaj
                MessageBox.Show($"PDF faylı uğurla saxlanıldı: {filePath}", "Uğur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fayl saxlanmadı", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private List<AppSetting> LoadAppSettingsFromDB()
        {
            var list = new List<AppSetting>();

            using (SqlConnection connection = new SqlConnection(this.sqlbaglan.conString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT Section, Code, Value FROM APP_SETTINGS", connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new AppSetting
                        {
                            Section = reader["Section"].ToString(),
                            Code = reader["Code"].ToString(),
                            Value = reader["Value"].ToString()
                        });
                    }
                }
            }

            return list;
        }

        private void adDgrvDocumentDetailStockSum_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Sətir və sütun düzgündürsə davam et
            if (e.RowIndex >= 0 && adDgrvDocumentDetailStockSum.Columns[e.ColumnIndex].Name == "PRICE")
            {
                var row = adDgrvDocumentDetailStockSum.Rows[e.RowIndex];
                var stockId = row.Cells["STOK_ID"].Value?.ToString();
                var newPrice = row.Cells["PRICE"].Value;

                if (string.IsNullOrEmpty(stockId) || newPrice == null)
                    return;

                // detail grid-də bütün uyğun STOK_ID sətirlərini tap və PRICE sahəsini yenilə
                foreach (DataGridViewRow detailRow in adDgrvDocumentDetail.Rows)
                {
                    var detailStockId = detailRow.Cells["STOCK_ID"].Value?.ToString();
                    if (detailStockId == stockId)
                    {
                        detailRow.Cells["DEFAULT_PRICE"].Value = newPrice;
                    }
                }
            }
        }

    }
}
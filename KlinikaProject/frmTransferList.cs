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

namespace POS_BACK_OFFICE
{
    public partial class frmTransferList : Form
    {
        public static string SendUserID = "";
        public static string SendUsername = "";
        public frmTransferList()
        {
            InitializeComponent();
        }
        private mssqlBaglanti sqlbaglan = new mssqlBaglanti();
        private void frmTransferList_Load(object sender, EventArgs e)
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

            DataGridViewTheme myTheme = new DataGridViewTheme();

            // Sənəd siyahısı üçün tətbiq et
            ThemeManager.ApplyTheme(adDgrvDocumentList, myTheme);

            // Sənəd detalları üçün tətbiq et
            ThemeManager.ApplyTheme(adDgrvDocumentDetail, myTheme);

        }



        private void createNewDoc_Click(object sender, EventArgs e)
        {
            // Open frmTransfer form
            frmTransfer ft = new frmTransfer();
            ft.Show();
        }

        private void LoadDocumentList()
        {
            int? sourceWarehouseId = string.IsNullOrEmpty(txtSourceWarehouseId.Text) ? (int?)null : Convert.ToInt32(txtSourceWarehouseId.Text);
            int? targetWarehouseId = string.IsNullOrEmpty(txtSourceWarehouseId.Text) ? (int?)null : Convert.ToInt32(txtTargetWarehouseId.Text);
            DateTime startDate = dtpDocStartDate.Value.Date;
            DateTime endDate = dtpDocEndDate.Value.Date;

            using (SqlConnection connection = new SqlConnection(this.sqlbaglan.conString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetTransferList", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Source_Warehouse_Id", (object)sourceWarehouseId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Target_Warehouse_Id", (object)targetWarehouseId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    adDgrvDocumentList.DataSource = dt;  // Yenilənmiş DataGridView adı
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
            // Seçilmiş sətirdəki DOC_NO sütununun dəyərini alırıq
            if (e.RowIndex >= 0)
            {
                int doc_no = Convert.ToInt32(adDgrvDocumentList.Rows[e.RowIndex].Cells["DOCNO"].Value);

                // Yükləmək üçün LoadDocumentDetails metodunu çağırırıq
                LoadDocumentDetails(doc_no);
                UpdateTotals();


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
            lblTotalAmount.Text = $"Transfer məbləğ: {totalAmount}";

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
                using (SqlCommand cmd = new SqlCommand("SP_GetTransferDetailByDocNo", connection))
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
                string[] editableColumns = { "QUANTITY", "DEFAULT_PRICE", "PURCHASE_UNIT_NAME", "cmbPurchaseUnitName","DELETED" };
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

                // **Əgər "Deleted" sütunu dəyişilibsə**
                if (adDgrvDocumentDetail.Columns[ev.ColumnIndex].Name == "DELETED")
                {
                    bool isDeleted = Convert.ToBoolean(row.Cells["DELETED"].Value ?? false);
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

                foreach (DataGridViewRow row in adDgrvDocumentDetail.Rows)
                {
                    if (row.Cells["DETAIL_ID"].Value == null || row.Cells["DOC_NO"].Value == null) continue;

                    int detailId = Convert.ToInt32(row.Cells["DETAIL_ID"].Value);
                    bool isDeleted = row.Cells["Deleted"] is DataGridViewCheckBoxCell checkbox && checkbox.Value != null && (bool)checkbox.Value;


                    using (SqlCommand cmd = new SqlCommand("SP_UpdateTransferDetails", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@DocNo", docNo);
                        cmd.Parameters.AddWithValue("@DetailId", detailId);
                        cmd.Parameters.AddWithValue("@Quantity", Convert.ToDecimal(row.Cells["QUANTITY"].Value ?? 0));
                        cmd.Parameters.AddWithValue("@TotalQuantity", Convert.ToDecimal(row.Cells["TOTAL_QUANTITY"].Value ?? 0));
                        cmd.Parameters.AddWithValue("@DefaultPrice", Convert.ToDecimal(row.Cells["DEFAULT_PRICE"].Value ?? 0));
                        cmd.Parameters.AddWithValue("@PurchaseUnit", Convert.ToInt32(row.Cells["PURCHASE_UNIT"].Value ?? 0));
                        // Həmin hissədə `TOTAL_AMOUNT`-ı yoxlayırıq ki, NULL göndərilməsin
                        decimal totalAmount = Convert.ToDecimal(row.Cells["TOTAL_AMOUNT"].Value ?? 0);
                        cmd.Parameters.AddWithValue("@TotalAmount", totalAmount == 0 ? 0 : totalAmount); // NULL yerinə 0 göndəririk

                        cmd.Parameters.AddWithValue("@Deleted", isDeleted ? 1 : 0);

                        cmd.ExecuteNonQuery();
                    }
                }

                // `DOCUMENT_HEADER` cədvəlində TOTAL_AMOUNT-u yenilə
                using (SqlCommand cmd = new SqlCommand("SP_UpdateTransferHeader", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DocNo", docNo);
                    cmd.Parameters.AddWithValue("@UserId", lblUserId.Text);
                    
                    cmd.ExecuteNonQuery();
                }

                connection.Close();
            }

            MessageBox.Show("Bütün dəyişikliklər uğurla yadda saxlandı!", "Uğur", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // **Redaktə rejimindən çıx**
            btnDocEdit.BackColor = SystemColors.Control;  // Standart rəngə qaytar
            btnDocEdit.ForeColor = SystemColors.ControlText;
            btnDocEdit.Text = "DÜZƏLİŞ ✏️";  // Əvvəlki adına qaytar
            btnDocEdit.Enabled = true; // Yenidən aktiv et

            // **btnSave düyməsini deaktiv et**
            btnSave.Enabled = false;

            // **DatagridView-ləri əvvəlki vəziyyətinə qaytar**
            adDgrvDocumentList.DefaultCellStyle.BackColor = SystemColors.Window;
            adDgrvDocumentList.DefaultCellStyle.ForeColor = SystemColors.ControlText;

            adDgrvDocumentDetail.DefaultCellStyle.BackColor = SystemColors.Window;
            adDgrvDocumentDetail.DefaultCellStyle.ForeColor = SystemColors.ControlText;

            // **Sütunları yenidən "ReadOnly" et (redaktəni qapat)**
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
}
}
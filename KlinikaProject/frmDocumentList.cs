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
    public partial class frmDocumentList : Form
    {
        public static string SendUserID = "";
        public static string SendUsername = "";
        public frmDocumentList()
        {
            InitializeComponent();
        }
        private mssqlBaglanti sqlbaglan = new mssqlBaglanti();
        private void frmDocumentList_Load(object sender, EventArgs e)
        {
            lblUserName.Text = GirishFormu.SendUsername.ToString();
            lblUserId.Text = GirishFormu.SendUserID.ToString();

            // **Sütunları "ReadOnly" et (redaktəni qapat)**
            foreach (DataGridViewColumn column in adDgrvDocumentList.Columns)
            {
                column.ReadOnly = true;
            }


            FillDocTypeComboBox();
            dtpDocStartDate.Value = DateTime.Today;
            dtpDocEndDate.Value = DateTime.Today;
            LoadDocumentList();
            LoadDocumentDetails(0);




            DataGridViewTheme myTheme = new DataGridViewTheme();

            // Sənəd siyahısı üçün tətbiq et
            ThemeManager.ApplyTheme(adDgrvDocumentList, myTheme);

            // Sənəd detalları üçün tətbiq et
            ThemeManager.ApplyTheme(adDgrvDocumentDetail, myTheme);

            LoadDocumentList();
            //ThemeManager.ApplyTheme(adDgrvDocumentList, myTheme);



        }
        private void frmDocumentList_Activated(object sender, EventArgs e)
        {
            LoadDocumentList();
        }


        private void createNewDoc_Click(object sender, EventArgs e)
        {
            frmWarehouseIncome frm = new frmWarehouseIncome();
            frm.StartPosition = FormStartPosition.CenterScreen;  // Ekranın ortasında aç
            frm.WindowState = FormWindowState.Normal;           // Əmin ol ki, minimizelənməyib
            frm.TopMost = true;                                 // Ən üstdə göstər
            frm.ShowDialog();                                         // Və ya ShowDialog() əgər modal olmalıdırsa

        }

        private void cmbDocType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(this.sqlbaglan.conString);
                connection.Open();
                string queryFill = "SELECT ID FROM DOCUMENT_TYPE WHERE Type_Name = @name";

                SqlCommand commandFill = new SqlCommand(queryFill, connection);
                commandFill.Parameters.AddWithValue("@name", cmbDocType.Text);

                // Execute the SQL query and retrieve the result using SqlDataReader
                SqlDataReader readerFill = commandFill.ExecuteReader();

                if (readerFill.Read()) // Check if there is data to read
                {
                    // Fill textboxes with data from the query
                    txtDocTypeId.Text = readerFill["ID"].ToString();
                }

                // Close the reader and the connection
                readerFill.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void FillDocTypeComboBox()
        {
            string query = "select Type_Name from DOCUMENT_TYPE where Status = 1";

            SqlConnection conn = new SqlConnection(this.sqlbaglan.conString);
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbDocType.Items.Add(reader["Type_Name"].ToString());
                }

                reader.Close();
            }
        }

        private void LoadDocumentList()
        {
            //txtDocTypeId.Text boşdursa null, yoxsa rəqəmə çevir
            int? docTypeId = string.IsNullOrEmpty(txtDocTypeId.Text) ? (int?)null : Convert.ToInt32(txtDocTypeId.Text);
            DateTime startDate = dtpDocStartDate.Value.Date;
            DateTime endDate = dtpDocEndDate.Value.Date;

            using (SqlConnection connection = new SqlConnection(this.sqlbaglan.conString))
            {
                connection.Open();

                // APP_SETTINGS-dən CODE = 'INC_DOC_TYPE' olan dəyəri götür
                using (SqlCommand cmdSetting = new SqlCommand("SELECT TOP 1 VALUE FROM APP_SETTINGS WHERE CODE = 'INC_DOC_TYPE'", connection))
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
                    //parametrik oldu secim olmasın, istəsən əvvəlki vəziyyətə qaytar
                    cmd.Parameters.AddWithValue("@DocTypeId", (object)docTypeId ?? DBNull.Value);
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
            decimal totalDiscount = 0;
            decimal totalAmount = 0;
            decimal subtotal = 0;

            // DataGridView-dəki bütün sətirləri yoxlayaq
            foreach (DataGridViewRow row in adDgrvDocumentDetail.Rows)
            {
                if (row.IsNewRow) continue;  // Yenisini nəzərə almayın

                // Hüceyrə dəyərlərini əldə edirik
                decimal quantity = Convert.ToDecimal(row.Cells["TOTAL_QUANTITY"].Value ?? 0);
                decimal defaultPrice = Convert.ToDecimal(row.Cells["DEFAULT_PRICE"].Value ?? 0);
                decimal discountAmount = Convert.ToDecimal(row.Cells["DISCOUNT_AMOUNT"].Value ?? 0);
                decimal totalAmountPerRow = Convert.ToDecimal(row.Cells["TOTAL_AMOUNT"].Value ?? 0);

                // Cəmləri hesablayırıq
                totalQuantity += quantity;
                totalDiscount += discountAmount;
                totalAmount += totalAmountPerRow;
                subtotal += quantity * defaultPrice;
            }

            // Cəmləri `Label`-lərə yerləşdiririk
            lblSubtotal.Text = $"Ara cəm: {subtotal}";
            lblDiscount.Text = $"Endirim: {totalDiscount}";
            lblTotalAmount.Text = $"Ümumi məbləğ: {totalAmount}";

            // Stil təyin edirik
            lblSubtotal.Font = new Font("Arial", 12, FontStyle.Bold);
            lblSubtotal.ForeColor = Color.DarkOrange;
            lblSubtotal.BackColor = Color.Transparent;
            lblSubtotal.TextAlign = ContentAlignment.MiddleLeft;  // Mətni sola düzəldirik
            lblSubtotal.Padding = new Padding(0, 0, 0, 0);  // Sola bir az boşluq əlavə edirik (sol tərəfə 10px boşluq)

            lblDiscount.Font = new Font("Arial", 12, FontStyle.Bold);
            lblDiscount.ForeColor = Color.ForestGreen;
            lblDiscount.BackColor = Color.Transparent;
            lblDiscount.TextAlign = ContentAlignment.MiddleLeft;  // Mətni sola düzəldirik
            lblDiscount.Padding = new Padding(0, 0, 0, 0);  // Sola bir az boşluq əlavə edirik (sol tərəfə 10px boşluq)

            lblTotalAmount.Font = new Font("Arial", 12, FontStyle.Bold);
            lblTotalAmount.ForeColor = Color.Red;
            lblTotalAmount.BackColor = Color.Transparent;
            lblTotalAmount.TextAlign = ContentAlignment.MiddleLeft;  // Mətni sola düzəldirik
            lblTotalAmount.Padding = new Padding(0, 0, 0, 0);  // Sola bir az boşluq əlavə edirik (sol tərəfə 10px boşluq)

            // Label-lərin daha gözəl görünməsi üçün əlavə effektlər
            lblSubtotal.MouseEnter += (sender, e) => { lblSubtotal.ForeColor = Color.Orange; };
            lblSubtotal.MouseLeave += (sender, e) => { lblSubtotal.ForeColor = Color.DarkOrange; };
            lblDiscount.MouseEnter += (sender, e) => { lblDiscount.ForeColor = Color.LimeGreen; };
            lblDiscount.MouseLeave += (sender, e) => { lblDiscount.ForeColor = Color.ForestGreen; };
            lblTotalAmount.MouseEnter += (sender, e) => { lblTotalAmount.ForeColor = Color.DarkRed; };
            lblTotalAmount.MouseLeave += (sender, e) => { lblTotalAmount.ForeColor = Color.Red; };
        }





        private void LoadDocumentDetails(int doc_no)
        {
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

                    adDgrvDocumentDetail.DataSource = dt; // Detalları göstəririk
                }

                // Stok cəmlərini göstərmək üçün
                using (SqlCommand cmdStock = new SqlCommand(@"
            SELECT STOCK_ID, STOCK_NAME, COUNT(STOCK_ID) AS BOX_COUNT, SUM(TOTAL_QUANTITY) AS TOTAL
            FROM VW_DOCUMENT_DETAIL
            WHERE DOC_NO = @DOC_NO
            GROUP BY STOCK_ID, STOCK_NAME", connection))
                {
                    cmdStock.Parameters.AddWithValue("@DOC_NO", doc_no);

                    SqlDataAdapter daStock = new SqlDataAdapter(cmdStock);
                    DataTable dtStock = new DataTable();
                    daStock.Fill(dtStock);

                    adDgrvDocumentDetailStockSum.DataSource = dtStock; // Stok cəmlərini göstəririk
                }
            }
        }

        private void btnDocEdit_Click(object sender, EventArgs e)
        {
            // Redaktə modunu aktivləşdir
            DocumentDetailActionsForEdit();
            adDgrvDocumentDetail.ReadOnly = false;
            adDgrvDocumentDetailStockSum.ReadOnly = false;

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
                string[] editableColumns = { "QUANTITY", "DEFAULT_PRICE", "DISCOUNT_AMOUNT", "PURCHASE_UNIT_NAME", "DISCOUNT_PER_CENT", "cmbPurchaseUnitName", "DELETED" };
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
                decimal discountPerCent = Convert.ToDecimal(row.Cells["DISCOUNT_PER_CENT"].Value ?? 0);
                decimal discountValue = Convert.ToDecimal(row.Cells["DISCOUNT_AMOUNT"].Value ?? 0);

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

                // **Əgər istifadəçi faiz dəyərini dəyişibsə**
                if (ev.ColumnIndex == row.Cells["DISCOUNT_PER_CENT"].ColumnIndex)
                {
                    discountValue = Math.Round(totalPrice * (discountPerCent / 100), 2);
                    row.Cells["DISCOUNT_AMOUNT"].Value = discountValue;
                }
                // **Əgər istifadəçi məbləği dəyişibsə**
                else if (ev.ColumnIndex == row.Cells["DISCOUNT_AMOUNT"].ColumnIndex)
                {
                    discountPerCent = (totalPrice != 0) ? Math.Round((discountValue / totalPrice) * 100, 2) : 0;
                    row.Cells["DISCOUNT_PER_CENT"].Value = discountPerCent;
                }

                // **TotalAmount-u yenilə**
                decimal finalAmount = Math.Round(totalPrice - discountValue, 2);
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

                    using (SqlCommand cmd = new SqlCommand("SP_UpdateDocumentDetails", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@DocNo", docNo);
                        cmd.Parameters.AddWithValue("@DetailId", detailId);
                        cmd.Parameters.AddWithValue("@Quantity", Convert.ToDecimal(row.Cells["QUANTITY"].Value ?? 0));
                        cmd.Parameters.AddWithValue("@TotalQuantity", Convert.ToDecimal(row.Cells["TOTAL_QUANTITY"].Value ?? 0));
                        cmd.Parameters.AddWithValue("@DefaultPrice", Convert.ToDecimal(row.Cells["DEFAULT_PRICE"].Value ?? 0));
                        cmd.Parameters.AddWithValue("@PurchaseUnit", Convert.ToInt32(row.Cells["PURCHASE_UNIT"].Value ?? 0));
                        //cmd.Parameters.AddWithValue("@DiscountPerCent", Convert.ToDecimal(row.Cells["DISCOUNT_PER_CENT"].Value ?? 0));
                        //cmd.Parameters.AddWithValue("@DiscountAmount", Convert.ToDecimal(row.Cells["DISCOUNT_AMOUNT"].Value ?? 0));
                        // Həmin hissədə `TOTAL_AMOUNT`-ı yoxlayırıq ki, NULL göndərilməsin
                        decimal totalAmount = Convert.ToDecimal(row.Cells["TOTAL_AMOUNT"].Value ?? 0);
                        cmd.Parameters.AddWithValue("@TotalAmount", totalAmount == 0 ? 0 : totalAmount); // NULL yerinə 0 göndəririk

                        cmd.Parameters.AddWithValue("@Deleted", isDeleted ? 1 : 0);

                        cmd.ExecuteNonQuery();
                    }
                }

                // `DOCUMENT_HEADER` cədvəlində TOTAL_AMOUNT-u yenilə
                using (SqlCommand cmd = new SqlCommand("SP_UpdateDocumentHeader", connection))
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

        private void btnBarcodeIntegration_Click(object sender, EventArgs e)
        {
            // frmWarehouseIncome formunu açırıq
            frmWarehouseIncome warehouseIncomeForm = new frmWarehouseIncome();
            warehouseIncomeForm.Show(); // Normal açılacaq
                                        // warehouseIncomeForm.ShowDialog(); // Modal açılacaq
        }
    }
}
using System.Data;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using Font = System.Drawing.Font;
using Microsoft.Identity.Client;
using System.Globalization;
using System.Threading;

namespace POS_BACK_OFFICE
{   public partial class frmSale : Form
    {

        public static string SendUserID = "";
        public static string SendUsername = "";

        public frmSale()

        {
            // ✅ Decimal parsing üçün Azərbaycan mədəniyyəti təyin edilir
            CultureInfo azCulture = new CultureInfo("az-Latn-AZ");
            Thread.CurrentThread.CurrentCulture = azCulture;
            Thread.CurrentThread.CurrentUICulture = azCulture;
            InitializeComponent();
        }
        private mssqlBaglanti sqlbaglan = new mssqlBaglanti();

        //Dogum Tarixi Uchun
        private bool _isHandlingTextChanged = false;

        private void SearchCompanies()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.sqlbaglan.conString))
                {
                    connection.Open();

                    string query = @"SELECT ID, ACC_NAME as [Kontragent Ad], 
                                    Company_Code as [Kodu], 
                                    TAX_NUMBER as [V.Ö.E.N.], 
                                    Last_Purchase_Date As [Son Alis Tarixi] 
                             FROM Accounts
                             WHERE (@Ad IS NOT NULL AND ACC_NAME LIKE @Ad)
                                OR (@CompanyCode IS NOT NULL AND Company_Code LIKE @CompanyCode)
                                --OR (@TaxNumber IS NOT NULL AND TAX_NUMBER LIKE @TaxNumber
                                      ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametrləri düzgün təyin edirik
                        string companyName = string.IsNullOrWhiteSpace(txtCompanyName.Text) ? null : "" + txtCompanyName.Text + "%";
                        string companyCode = string.IsNullOrWhiteSpace(txtCompanyCode.Text) ? null : "%" + txtCompanyCode.Text + "%";

                        command.Parameters.AddWithValue("@Ad", (object)companyName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CompanyCode", (object)companyCode ?? DBNull.Value);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta: " + ex.Message);
            }
        }


        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
            SearchCompanies();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            SearchCompanies();
        }

        private void txtAtaAd_TextChanged(object sender, EventArgs e)
        {
            SearchCompanies();
        }
        private void txtFinKod_TextChanged(object sender, EventArgs e)
        {
            SearchCompanies();
        }


        private void chkDupCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDupCustomer.Checked)
            {
                dataGridView1.Visible = true;
                lblUnvan.Visible = false;
                txtUnvan.Visible = false;
                lblTelefon.Visible = false;
                txtTelefon.Visible = false;
                lblQeyd.Visible = false;
                txtQeyd.Visible = false;
                lblEmail.Visible = false;
                txtEmail.Visible = false;
            }
            else
            {
                // Checkbox işarə olmadıqda ediləcək əməliyyatlar
                dataGridView1.Visible = false;
                //lblUnvan.Visible = true;
                //txtUnvan.Visible = true;
                //lblTelefon.Visible = true;
                //txtTelefon.Visible = true;
                lblQeyd.Visible = true;
                //txtQeyd.Visible = true;
                //txtEmail.Visible = true;
                //lblDocType.Visible = true;
                //cmbDocType.Visible = true;
            }

        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Visible = false;
            //lblUnvan.Visible = true;
            //txtUnvan.Visible = true;
            //lblTelefon.Visible = true;
            //txtTelefon.Visible = true;
            lblQeyd.Visible = true;
            txtQeyd.Visible = true;
            //lblEmail.Visible = true;
            //txtEmail.Visible = true;
            //lblDocType.Visible = true;
            //cmbDocType.Visible = true;

            // Tıklanan sətirin indeksini alırıq
            int rowIndex = e.RowIndex;

            // DataGridView-də hər hansı bir sətir seçilibsə, ID-ni götürürük
            if (rowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);

                // ID-ni istifadə edərək verilənlər bazasından məlumatları götürürük
                FetchCompanyDetails(id);
            }
        }

        private void FetchCompanyDetails(int id)
        {
            SqlConnection connectionString = new SqlConnection(this.sqlbaglan.conString);
            // Verilənlər bazası bağlantı sətrinizi bura əlavə edin
            string query = "SELECT * FROM ACCOUNTS WHERE id = @id";


            SqlConnection conn = new SqlConnection(this.sqlbaglan.conString);
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    AccountID.Text = reader["id"].ToString();
                    txtCompanyName.Text = reader["ACC_NAME"].ToString();
                    txtCompanyCode.Text = reader["Company_Code"].ToString();
                    dtpLastPurchaseDate.Text = reader["Last_Purchase_Date"].ToString();
                    txtUnvan.Text = reader["ADDRESS"].ToString();
                    txtTelefon.Text = reader["PHONE"].ToString();
                    txtEmail.Text = reader["EMAIL"].ToString();
                    txtQeyd.Text = reader["NOTE"].ToString();

                }

                reader.Close();
            }


        }


        private ContextMenuStrip contextMenu;

        private void frmQeydiyyat_Load(object sender, EventArgs e)
        {
            dtpDocDate.Value = DateTime.Today;
            lblUserName.Text = GirishFormu.SendUsername.ToString();
            lblUserId.Text = GirishFormu.SendUserID.ToString();

            // Initialize and set up the context menu
            InitializeContextMenu();

            // Assign the context menu to the DataGridView
            dgrvDocument.ContextMenuStrip = contextMenu;

            // Digər ComboBox-lar üçün də uyğun item-ləri əlavə edin
            //FillXestelikComboBox();
            // FillSigortaComboBox();
            // FillSigortaSirketComboBox();
            FillDocTypeComboBox();
            FillWarehouseComboBox();
            DocumentDetailActions();



            SqlConnection connection = new SqlConnection(this.sqlbaglan.conString);

            connection.Open();
            string query0 = "SELECT ISNULL(MAX(DOC_NO), 0) + 1 AS NEW_DOC_NO FROM DOCUMENT_HEADER";
            txtSifarisNomresi.Clear();
            SqlCommand command0 = new SqlCommand(query0, connection);
            SqlDataReader reader0 = command0.ExecuteReader();

            if (reader0.Read())  // Using if instead of while since we only expect one row
            {
                txtSifarisNomresi.Text = reader0["NEW_DOC_NO"].ToString();
            }

            else
            {
                txtSifarisNomresi.Text = "1";
            }
            reader0.Close();
            connection.Close();


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


        private void FillWarehouseComboBox()
        {
            string query = "select Name from WAREHOUSE where Status = 1";

            SqlConnection conn = new SqlConnection(this.sqlbaglan.conString);
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbWarehouse.Items.Add(reader["Name"].ToString());
                }

                reader.Close();
            }
        }
        private void cmbWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(this.sqlbaglan.conString);
                connection.Open();
                string queryFill = "SELECT ID FROM WAREHOUSE WHERE NAME = @name";

                SqlCommand commandFill = new SqlCommand(queryFill, connection);
                commandFill.Parameters.AddWithValue("@name", cmbWarehouse.Text);

                // Execute the SQL query and retrieve the result using SqlDataReader
                SqlDataReader readerFill = commandFill.ExecuteReader();

                if (readerFill.Read()) // Check if there is data to read
                {
                    // Fill textboxes with data from the query
                    txtWarehouseId.Text = readerFill["ID"].ToString();
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

        private void dgrvDocument_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateTotals();

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var columns = dgrvDocument.Columns;
            if (columns["Discount"] == null || columns["Price"] == null || columns["TotalAmount"] == null || columns["Quantity"] == null) return;

            if (e.ColumnIndex == columns["Discount"].Index)
            {
                var row = dgrvDocument.Rows[e.RowIndex];

                if (decimal.TryParse(row.Cells["Price"].Value?.ToString(), out decimal price) &&
                    decimal.TryParse(row.Cells["TotalQuantity"].Value?.ToString(), out decimal quantity) &&
                    decimal.TryParse(row.Cells["Discount"].Value?.ToString(), out decimal discount))
                {
                    decimal total = price * quantity;
                    if (discount > total)
                    {
                        MessageBox.Show("Endirim ümumi məbləğdən çox ola bilməz. Zəhmət olmasa düzəldin.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Xanada qalmağa davam et, istifadəçiyə düzəltmə imkanı ver
                        dgrvDocument.BeginEdit(true);
                        return;
                    }

                    row.Cells["TotalAmount"].Value = total - discount;
                }
            }

        }

        private void UpdateTotals()
        {
            decimal totalQuantity = 0;
            decimal totalDiscount = 0;
            decimal totalAmount = 0;
            decimal subtotal = 0;

            // DataGridView-dəki bütün sətirləri yoxlayaq
            foreach (DataGridViewRow row in dgrvDocument.Rows)
            {
                if (row.IsNewRow) continue;  // Yenisini nəzərə almayın

                // Hüceyrə dəyərlərini əldə edirik
                decimal quantity = Convert.ToDecimal(row.Cells["TotalQuantity"].Value ?? 0);
                decimal defaultPrice = Convert.ToDecimal(row.Cells["Price"].Value ?? 0);
                decimal discountAmount = Convert.ToDecimal(row.Cells["Discount"].Value ?? 0);
                decimal totalAmountPerRow = Convert.ToDecimal(row.Cells["TotalAmount"].Value ?? 0);

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




        private void InitializeContextMenu()
        {
            contextMenu = new ContextMenuStrip();
            var deleteMenuItem = new ToolStripMenuItem("Delete");
            deleteMenuItem.Click += DeleteMenuItem_Click;
            contextMenu.Items.Add(deleteMenuItem);
        }

        // Handle the context menu item click event for deleting a row
        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (dgrvDocument.CurrentRow != null && !dgrvDocument.CurrentRow.IsNewRow)
            {
                dgrvDocument.Rows.Remove(dgrvDocument.CurrentRow);
            }
        }

        // Optional: If you want to show the context menu only when right-clicking on a row
        private void dgrvSatis_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dgrvDocument.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    dgrvDocument.ClearSelection();
                    dgrvDocument.Rows[hitTestInfo.RowIndex].Selected = true;
                    dgrvDocument.CurrentCell = dgrvDocument.Rows[hitTestInfo.RowIndex].Cells[0]; // Set the current cell to the first cell of the selected row
                    contextMenu.Show(dgrvDocument, e.Location);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if any of the required text boxes are empty
            if (string.IsNullOrWhiteSpace(txtCompanyName.Text) ||
                string.IsNullOrWhiteSpace(txtCompanyCode.Text) 
                //||
                //string.IsNullOrWhiteSpace(txtWarehouseId.Text)
                )

            {
                // Display a message to the user
                MessageBox.Show("Vacib komponentlər doldurulmayıb!.", "Təsdiqləmə xətası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if required fields are empty
            }

            // Check if the PasientID exists in the database
            if (IsAccountIDExists(AccountID.Text))
            {
                // Display a message to the user
                //MessageBox.Show("The Pasient ID already exists. Cannot insert duplicate ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SaveData2();
            }
            else
            {
                // Proceed with the save operation
                SaveData1();
                SaveData2();
            }
        }




        private bool IsAccountIDExists(string AccountID)
        {
            SqlConnection connection = new SqlConnection(this.sqlbaglan.conString);

            string query = "SELECT Id FROM Accounts WHERE Id = @AccountID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountID", AccountID);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                // AccountID exists in the database
                return true;
            }
            else
            {
                // AccountID does not exist in the database
                return false;
            }


        }


        private void SaveData1()
        {

            // Get the selected date and time from the DateTimePicker
            DateTime selectedDateTime1 = dtpLastPurchaseDate.Value;

            // Convert the selected date and time to the SQL Server datetime format
            string formattedDateTime1 = selectedDateTime1.ToString("yyyy-MM-dd");

            using (SqlConnection connection = new SqlConnection(this.sqlbaglan.conString))
            {
                using (SqlCommand command = new SqlCommand("[SP_InsertAccount]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parametrləri əlavə edirik
                    command.Parameters.AddWithValue("@ACC_NAME", txtCompanyName.Text);
                    command.Parameters.AddWithValue("@Company_Code", txtCompanyCode.Text);
                    command.Parameters.AddWithValue("@Last_Purchase_Date", selectedDateTime1);
                    command.Parameters.AddWithValue("@ADDRESS", txtUnvan.Text);
                    command.Parameters.AddWithValue("@PHONE", txtTelefon.Text);
                    command.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                    command.Parameters.AddWithValue("@NOTE", txtQeyd.Text);
                    try
                    {
                        // Bağlantını açırıq
                        connection.Open();

                        // Proseduru icra edirik və yeni əlavə edilən ID-ni alırıq
                        var newId = command.ExecuteScalar();

                        // Yeni ID-ni PasientID textbox-na yazırıq
                        AccountID.Text = newId.ToString();

                        // Proseduru icra edirik
                        //command.ExecuteNonQuery();

                        // Məlumat uğurla əlavə olundu mesajını göstəririk
                        //MessageBox.Show("Məlumat uğurla əlavə olundu.");

                    }
                    catch (SqlException ex)
                    {
                        // Xəta mesajını göstərə bilərsiz və ya sadəcə olaraq ignor edə bilərsiz
                        MessageBox.Show("Məlumat əlavə edilə bilmədi: " + ex.Message);
                        //MessageBox.Show("Pasientdə ad, familiya, ata adı, doğumtarixi eynidir.: ");
                    }
                    finally
                    {
                        // Bağlantını bağlayırıq
                        connection.Close();
                    }
                }
            }

            // MessageBox.Show("Məlumat uğurla əlavə olundu.");

        }
        private void SaveData2()
        {
            // DocType oxunur
            string docTypeValue = string.Empty;
            using (SqlConnection conn = new SqlConnection(this.sqlbaglan.conString))
            {
                conn.Open();
                string query = "SELECT TOP 1 VALUE FROM APP_SETTINGS WHERE CODE = 'SALE_DOC_TYPE'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        docTypeValue = result.ToString();
                    }
                }
                conn.Close();
            }

            foreach (DataGridViewRow row in dgrvDocument.Rows)
            {
                if (!row.IsNewRow)
                {
                    DateTime Tarix = dtpDocDate.Value;

                    int StockId = row.Cells["StockId"].Value != null ? Convert.ToInt32(row.Cells["StockId"].Value) : 0;
                    int BaseUnitId = row.Cells["BaseUnitId"].Value != null ? Convert.ToInt32(row.Cells["BaseUnitId"].Value) : 0;
                    int PurchaseUnitId = row.Cells["PurchaseUnitId"].Value != null ? Convert.ToInt32(row.Cells["PurchaseUnitId"].Value) : 0;

                    // ✅ Decimal-ları vergül problemini həll edərək oxuyuruq
                    string quantityStr = row.Cells["Quantity"].Value?.ToString()?.Replace(",", ".") ?? "0";
                    decimal Quantity = decimal.Parse(quantityStr, CultureInfo.InvariantCulture);

                    string totalQuantityStr = row.Cells["TotalQuantity"].Value?.ToString()?.Replace(",", ".") ?? "0";
                    decimal TotalQuantity = decimal.Parse(totalQuantityStr, CultureInfo.InvariantCulture);

                    string priceStr = row.Cells["Price"].Value?.ToString()?.Replace(",", ".") ?? "0";
                    decimal Price = decimal.Parse(priceStr, CultureInfo.InvariantCulture);

                    string discountStr = row.Cells["Discount"].Value?.ToString()?.Replace(",", ".") ?? "0";
                    decimal Discount = decimal.Parse(discountStr, CultureInfo.InvariantCulture);

                    string discountPercentStr = row.Cells["DiscountPerCent"].Value?.ToString()?.Replace(",", ".") ?? "0";
                    decimal DiscountPerCent = decimal.Parse(discountPercentStr, CultureInfo.InvariantCulture);

                    string totalAmountStr = row.Cells["TotalAmount"].Value?.ToString()?.Replace(",", ".") ?? "0";
                    decimal TotalAmount = decimal.Parse(totalAmountStr, CultureInfo.InvariantCulture);

                    string barcode = row.Cells["Barcode"]?.Value?.ToString() ?? string.Empty;

                    using (SqlConnection conn = new SqlConnection(this.sqlbaglan.conString))
                    {
                        using (SqlCommand cmd = new SqlCommand("[SP_InsertDocuments]", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Doc_No", txtSifarisNomresi.Text);
                            cmd.Parameters.AddWithValue("@DocType", docTypeValue);
                            cmd.Parameters.AddWithValue("@AccountID", AccountID.Text);
                            cmd.Parameters.AddWithValue("@Tarix", Tarix);
                            cmd.Parameters.AddWithValue("@StockId", StockId);
                            cmd.Parameters.AddWithValue("@Barcode", barcode);
                            cmd.Parameters.AddWithValue("@BaseUnitId", BaseUnitId);
                            cmd.Parameters.AddWithValue("@PurchaseUnitId", PurchaseUnitId);

                            // ✅ Decimal tiplər AddWithValue yox, doğru SqlDbType ilə
                            cmd.Parameters.Add("@Quantity", SqlDbType.Decimal).Value = Quantity;
                            cmd.Parameters.Add("@TotalQuantity", SqlDbType.Decimal).Value = TotalQuantity;
                            //cmd.Parameters.Add("@Price", SqlDbType.Decimal).Value = Price;
                            cmd.Parameters.Add("@Price", SqlDbType.Decimal).Precision = 18;
                            cmd.Parameters["@Price"].Scale = 2;
                            cmd.Parameters["@Price"].Value = Price;


                            cmd.Parameters.Add("@Discount", SqlDbType.Decimal).Value = Discount;
                            cmd.Parameters.Add("@DiscountPerCent", SqlDbType.Decimal).Value = DiscountPerCent;
                            cmd.Parameters.Add("@TotalAmount", SqlDbType.Decimal).Value = TotalAmount;

                            cmd.Parameters.AddWithValue("@UserID", lblUserId.Text);
                            cmd.Parameters.AddWithValue("@WaehouseId", txtWarehouseId.Text);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                }
            }

            // ✅ UI təmizləmə
            AccountID.Clear();
            txtSifarisNomresi.Clear();
            dgrvDocument.Rows.Clear();
            dgrvDocumentSumStock.Rows.Clear();
            dtpLastPurchaseDate.Text = string.Empty;
            txtCompanyCode.Clear();
            txtUnvan.Clear();
            txtTelefon.Clear();
            txtQeyd.Clear();
            txtEmail.Clear();
            txtCompanyName.Clear();
            chkDupCustomer.Checked = false;

            MessageBox.Show("Sifarişiniz uğurla tamamlandı.");

            // ✅ Yeni sifariş nömrəsi
            SqlConnection CNN = new SqlConnection(this.sqlbaglan.conString);
            CNN.Open();
            string query0 = "SELECT ISNULL(MAX(DOC_NO), 0) + 1 AS NEWSNO FROM DOCUMENT_HEADER";
            txtSifarisNomresi.Clear();
            SqlCommand command0 = new SqlCommand(query0, CNN);
            SqlDataReader reader0 = command0.ExecuteReader();

            if (reader0.Read())
            {
                txtSifarisNomresi.Text = reader0["NEWSNO"].ToString();
            }
            else
            {
                txtSifarisNomresi.Text = "1";
            }
            reader0.Close();
            CNN.Close();
        }













        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Məlumatlar uğurla daxil edildikdən sonra textboxları və datagridview-i təmizləyirik
            AccountID.Clear();
            //txtSifarisNomresi.Clear();
            AccountID.Clear();
            dgrvDocument.Rows.Clear();
            dgrvDocumentSumStock.Rows.Clear();
            dtpLastPurchaseDate.Text = string.Empty;
            txtCompanyCode.Clear();
            txtUnvan.Clear();
            txtTelefon.Clear();

            txtQeyd.Clear(); ;
            txtEmail.Clear();
        }
        private void DocumentDetailActions()
        {
            string username = lblUserId.Text;
            using (SqlConnection connection = new SqlConnection(this.sqlbaglan.conString))
            {
                connection.Open();

                // Bütün sütunları redaktə edilməz hala gətir
                foreach (DataGridViewColumn column in dgrvDocument.Columns)
                {
                    column.ReadOnly = true;
                }

                // Redaktə edilə bilən sütunlar
                dgrvDocument.Columns["Quantity"].ReadOnly = false;
                dgrvDocument.Columns["Price"].ReadOnly = false;
                dgrvDocument.Columns["Discount"].ReadOnly = false;
                dgrvDocument.Columns["PurchaseUnit"].ReadOnly = false;
                dgrvDocument.Columns["DiscountPerCent"].ReadOnly = false;
                dgrvDocument.Columns["TotalQuantity"].ReadOnly = true;
                dgrvDocument.Columns["PurchaseUnitId"].ReadOnly = true;

                // **UNITS cədvəlindən məlumatları gətir və PurchaseUnit combobox-a doldur**
                SqlCommand cmd = new SqlCommand("SELECT ID, NAME, MULTIPLIER FROM UNITS WHERE MAIN_UNIT != 1", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable unitsTable = new DataTable();
                adapter.Fill(unitsTable);

                // Əgər "PurchaseUnit" artıq ComboBox-dırsa, DataSource-u yenilə
                if (dgrvDocument.Columns["PurchaseUnit"] is DataGridViewComboBoxColumn purchaseUnitColumn)
                {
                    purchaseUnitColumn.DataSource = unitsTable;
                    purchaseUnitColumn.DisplayMember = "NAME";
                    purchaseUnitColumn.ValueMember = "ID";
                }

                // DataGridView-in CellValueChanged hadisəsini dinlə
                dgrvDocument.CellValueChanged += (s, ev) =>
                {
                    try
                    {
                        if (ev.RowIndex < 0) return;

                        DataGridViewRow row = dgrvDocument.Rows[ev.RowIndex];

                        // Məcburi yoxlamalar
                        decimal quantity = Convert.ToDecimal(row.Cells["Quantity"].Value ?? 0);
                        decimal price = Convert.ToDecimal(row.Cells["Price"].Value ?? 0);
                        decimal discountPerCent = Convert.ToDecimal(row.Cells["DiscountPerCent"].Value ?? 0);
                        decimal discountValue = Convert.ToDecimal(row.Cells["Discount"].Value ?? 0);
                        decimal totalQuantity = quantity; // Default olaraq TotalQuantity = Quantity

                        // **MULTIPLIER-ı əldə et və TotalQuantity yenilə**
                        object selectedValue = row.Cells["PurchaseUnit"].Value;
                        if (selectedValue != null)
                        {
                            DataRow[] selectedUnit = unitsTable.Select($"ID = {selectedValue}");
                            if (selectedUnit.Length > 0)
                            {
                                decimal multiplier = Convert.ToDecimal(selectedUnit[0]["MULTIPLIER"]);
                                row.Cells["PurchaseUnitId"].Value = Convert.ToInt32(selectedUnit[0]["ID"]); // ID yenilə
                                totalQuantity = Math.Round(quantity * multiplier, 2);
                            }
                        }

                        row.Cells["TotalQuantity"].Value = totalQuantity; // **TotalQuantity həmişə yenilənir**

                        // **Endirim və endirim faizi yenilə**
                        decimal totalPrice = totalQuantity * price; // **Hesablamalar TotalQuantity üzərindən getsin**
                        discountValue = Math.Round(totalPrice * (discountPerCent / 100), 2);
                        row.Cells["Discount"].Value = discountValue;

                        // **TotalAmount-u yenilə**
                        decimal finalAmount = Math.Round(totalPrice - discountValue, 2);
                        row.Cells["TotalAmount"].Value = finalAmount;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xəta baş verdi: " + ex.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };

                connection.Close();
            }
        }

        //BARCODE
        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barcode = txtBarcode.Text.Trim();

                // ✅ 13 simvolluq barkod yoxlanışı
                if (barcode.Length == 13)
                {
                    string productCode = barcode.Substring(4, 3);   // 🔹 Məhsul kodu (4–6-cı simvollar)
                    string weightStr = barcode.Substring(7, 6);     // 🔹 Çəki hissəsi (7–12-ci simvollar)

                    // 🔍 Çəki ədədi formata çevrilir
                    if (decimal.TryParse(weightStr, out decimal weight))
                    {
                        decimal weightKg = weight / 10000m;         // ✅ Qramdan kiloya çevrilir

                        using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
                        {
                            try
                            {
                                connection.Open();

                                // 🔎 Məhsulun ID-si tapılır
                                string queryStockId = "SELECT ID FROM STOCK WHERE CODE = @Code";
                                string stockId = null;

                                using (SqlCommand cmd = new SqlCommand(queryStockId, connection))
                                {
                                    cmd.Parameters.AddWithValue("@Code", productCode);
                                    object result = cmd.ExecuteScalar();

                                    if (result == null)
                                    {
                                        MessageBox.Show("Məhsul tapılmadı!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        txtBarcode.Clear();
                                        return;
                                    }

                                    stockId = result.ToString();
                                }

                                // 🔍 Məhsul detalları alınır
                                string queryDetails = "SELECT NAME, LAST_PURCHASE_PRICE, BASE_UNIT FROM VW_STOCK WHERE ID = @ID";

                                using (SqlCommand cmd = new SqlCommand(queryDetails, connection))
                                {
                                    cmd.Parameters.AddWithValue("@ID", stockId);

                                    using (SqlDataReader reader = cmd.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            string name = reader["NAME"].ToString();
                                            string priceStr = reader["LAST_PURCHASE_PRICE"].ToString();
                                            string baseUnit = reader["BASE_UNIT"].ToString();

                                            // 🔢 Qiymət çevrilməsi
                                            if (!decimal.TryParse(priceStr, out decimal price))
                                                price = 0;

                                            decimal total = price * weightKg;

                                            // ✅ Satır əlavə olunur:
                                            // | Date | StockID | Barcode | Name | Qty | Price | TotalQty | TotalAmount | BaseUnit |
                                            dgrvDocument.Rows.Insert(0,
                                                DateTime.Now,
                                                stockId,
                                                barcode,
                                                name,
                                                weightKg,
                                                price,
                                                weightKg,
                                                total,
                                                baseUnit
                                            );

                                            UpdateTotals();        // 🧮 Toplam məbləğ və saylar yenilənir
                                            UpdateSumStockGrid();  // 📊 Əlavə göstəricilər yenilənir
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Xəta baş verdi: " + ex.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }

                txtBarcode.Clear();         // 🔄 Barkod sahəsi təmizlənir
                e.SuppressKeyPress = true;  // ⛔️ Səs və ya beep olmaması üçün
            }
        }


        private void UpdateSumStockGrid()
        {
            // Temp dictionary: <StockName, (count, totalQuantity)>
            Dictionary<string, (int count, decimal totalQuantity)> summary = new();

            foreach (DataGridViewRow row in dgrvDocument.Rows)
            {
                if (row.IsNewRow) continue;

                string stockName = row.Cells["StockName"].Value?.ToString();
                decimal quantity = 0;
                decimal.TryParse(row.Cells["Quantity"]?.Value?.ToString(), out quantity);

                if (!string.IsNullOrEmpty(stockName))
                {
                    if (summary.ContainsKey(stockName))
                    {
                        var current = summary[stockName];
                        summary[stockName] = (current.count + 1, current.totalQuantity + quantity);
                    }
                    else
                    {
                        summary[stockName] = (1, quantity);
                    }
                }
            }

            // Köhnə onePrice dəyərlərini yadda saxla
            Dictionary<string, decimal> oldPrices = new();
            foreach (DataGridViewRow row in dgrvDocumentSumStock.Rows)
            {
                string name = row.Cells["Stock_Name"]?.Value?.ToString();
                if (!string.IsNullOrEmpty(name) && decimal.TryParse(row.Cells["onePrice"]?.Value?.ToString(), out decimal price))
                {
                    oldPrices[name] = price;
                }
            }

            // Cədvəli təmizlə
            dgrvDocumentSumStock.Rows.Clear();

            // Yeni sətirləri əlavə et
            foreach (var item in summary)
            {
                string stockName = item.Key;
                int count = item.Value.count;
                decimal totalQty = item.Value.totalQuantity;

                decimal onePrice = oldPrices.ContainsKey(stockName) ? oldPrices[stockName] : 0;
                decimal totalSum = totalQty * onePrice;

                dgrvDocumentSumStock.Rows.Add(stockName, count, totalQty, onePrice, totalSum);
            }
        }


        private void dgrvDocumentSumStock_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgrvDocumentSumStock.Columns[e.ColumnIndex].Name == "onePrice")
            {
                DataGridViewRow changedRow = dgrvDocumentSumStock.Rows[e.RowIndex];

                string stockName = changedRow.Cells["Stock_Name"].Value?.ToString();
                string priceText = changedRow.Cells["onePrice"].Value?.ToString();

                // Azərbaycan kültürü
                CultureInfo azCulture = new CultureInfo("az-Latn-AZ");

                // Qəbul edilən qiyməti normallaşdırırıq (vergülü nöqtə ilə əvəz edirik)
                priceText = priceText?.Replace(".", ",");

                // Normalizasiya edilmiş qiyməti decimal olaraq oxuyuruq
                if (!string.IsNullOrEmpty(stockName) && decimal.TryParse(priceText, NumberStyles.Any, azCulture, out decimal newPrice))
                {
                    if (decimal.TryParse(changedRow.Cells["Total_Quantity"]?.Value?.ToString(), NumberStyles.Any, azCulture, out decimal totalQtySum))
                    {
                        decimal newTotalSum = totalQtySum * newPrice;
                        changedRow.Cells["totalSum"].Value = newTotalSum;
                    }

                    foreach (DataGridViewRow row in dgrvDocument.Rows)
                    {
                        if (!row.IsNewRow && row.Cells["StockName"].Value?.ToString() == stockName)
                        {
                            row.Cells["Price"].Value = newPrice;

                            if (decimal.TryParse(row.Cells["TotalQuantity"]?.Value?.ToString(), NumberStyles.Any, azCulture, out decimal totalQty))
                            {
                                row.Cells["TotalAmount"].Value = newPrice * totalQty;
                            }
                        }
                    }
                }
            }
        }





    }
}


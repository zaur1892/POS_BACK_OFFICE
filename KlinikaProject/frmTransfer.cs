using System.Data;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace POS_BACK_OFFICE
{
    public partial class frmTransfer : Form
    {
        public static string SendUserID = "";
        public static string SendUsername = "";

        public frmTransfer()

        {
            InitializeComponent();
        }
        private mssqlBaglanti sqlbaglan = new mssqlBaglanti();


        private ContextMenuStrip contextMenu;

        private void frmTransfer_Load(object sender, EventArgs e)
        {
            dtpDocDate.Value = DateTime.Today;
            lblUserName.Text = GirishFormu.SendUsername.ToString();
            lblUserId.Text = GirishFormu.SendUserID.ToString();

            // Initialize and set up the context menu
            InitializeContextMenu();

            // Assign the context menu to the DataGridView
            dgrvDocument.ContextMenuStrip = contextMenu;
            FillWarehousesComboBox();
            DocumentDetailActions();



            SqlConnection connection = new SqlConnection(this.sqlbaglan.conString);

            connection.Open();
            string query0 = "SELECT ISNULL(MAX(DOC_NO), 0) + 1 AS NEW_DOC_NO FROM TRANSFER_HEADER";
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


        private void FillWarehousesComboBox()
        {
            string query = "select Name from WAREHOUSE where Status = 1";

            SqlConnection conn = new SqlConnection(this.sqlbaglan.conString);
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbSourceWarehouse.Items.Add(reader["Name"].ToString());
                    cmbTargetWarehouse.Items.Add(reader["Name"].ToString());
                }

                reader.Close();
            }
        }
        private void cmbSourceWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(this.sqlbaglan.conString);
                connection.Open();
                string queryFill = "SELECT ID FROM WAREHOUSE WHERE NAME = @name";

                SqlCommand commandFill = new SqlCommand(queryFill, connection);
                commandFill.Parameters.AddWithValue("@name", cmbSourceWarehouse.Text);

                // Execute the SQL query and retrieve the result using SqlDataReader
                SqlDataReader readerFill = commandFill.ExecuteReader();

                if (readerFill.Read()) // Check if there is data to read
                {
                    // Fill textboxes with data from the query
                    txtSourceWarehouseId.Text = readerFill["ID"].ToString();
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
        private void cmbTargetWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(this.sqlbaglan.conString);
                connection.Open();
                string queryFill = "SELECT ID FROM WAREHOUSE WHERE NAME = @name";

                SqlCommand commandFill = new SqlCommand(queryFill, connection);
                commandFill.Parameters.AddWithValue("@name", cmbTargetWarehouse.Text);

                // Execute the SQL query and retrieve the result using SqlDataReader
                SqlDataReader readerFill = commandFill.ExecuteReader();

                if (readerFill.Read()) // Check if there is data to read
                {
                    // Fill textboxes with data from the query
                    txtTargetWarehouseId.Text = readerFill["ID"].ToString();
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
            if (string.IsNullOrWhiteSpace(txtSourceWarehouseId.Text) ||
                string.IsNullOrWhiteSpace(txtTargetWarehouseId.Text)
                )

            {
                // Display a message to the user
                MessageBox.Show("DEPO komponentləri doldurulmayıb!.", "Təsdiqləmə xətası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if required fields are empty
            }
         SaveData();
        }



        private void SaveData()
        {
            foreach (DataGridViewRow row in dgrvDocument.Rows)
            {
                if (!row.IsNewRow)
                {
                    DateTime Tarix = dtpDocDate.Value;
                    int StockId = row.Cells["StockId"].Value != null ? int.Parse(row.Cells["StockId"].Value.ToString()) : 0;
                    int BaseUnitId = row.Cells["BaseUnitId"].Value != null ? int.Parse(row.Cells["BaseUnitId"].Value.ToString()) : 0;

                    // NULL yoxlaması ilə PurchaseUnitId
                    int PurchaseUnitId = 0;
                    if (row.Cells["PurchaseUnitId"].Value != null)
                    {
                        int.TryParse(row.Cells["PurchaseUnitId"].Value.ToString(), out PurchaseUnitId);
                    }

                    decimal Quantity = 0m;
                    decimal.TryParse(row.Cells["Quantity"]?.Value?.ToString(), out Quantity);

                    decimal TotalQuantity = 0m;
                    decimal.TryParse(row.Cells["TotalQuantity"]?.Value?.ToString(), out TotalQuantity);

                    decimal Price = 0m;
                    decimal.TryParse(row.Cells["Price"]?.Value?.ToString(), out Price);

                    decimal TotalAmount = 0m;
                    decimal.TryParse(row.Cells["TotalAmount"]?.Value?.ToString(), out TotalAmount);

                    using (SqlConnection conn = new SqlConnection(this.sqlbaglan.conString))
                    {
                        using (SqlCommand cmd = new SqlCommand("[SP_InsertTransfers]", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Doc_No", txtSifarisNomresi.Text);
                            cmd.Parameters.AddWithValue("@Tarix", Tarix);
                            cmd.Parameters.AddWithValue("@StockId", StockId);
                            cmd.Parameters.AddWithValue("@BaseUnitId", BaseUnitId);
                            cmd.Parameters.AddWithValue("@PurchaseUnitId", PurchaseUnitId);
                            cmd.Parameters.AddWithValue("@Quantity", Quantity);
                            cmd.Parameters.AddWithValue("@TotalQuantity", TotalQuantity);
                            cmd.Parameters.AddWithValue("@Price", Price);
                            cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                            cmd.Parameters.AddWithValue("@UserID", lblUserId.Text);
                            cmd.Parameters.AddWithValue("@SourceWarehouseId", txtSourceWarehouseId.Text);
                            cmd.Parameters.AddWithValue("@TargetWarehouseId", txtTargetWarehouseId.Text);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                }
            }

            // UI təmizləmə
            txtSifarisNomresi.Clear();
            dgrvDocument.Rows.Clear();
            txtStockGroup.Clear();
            txtStockGroupId.Clear();
            txtStock.Clear();
            txtStockId.Clear();

            MessageBox.Show("Sifarişiniz uğurla tamamlandı.");

            // Yeni sifariş nömrəsini formalaşdırmaq
            SqlConnection CNN = new SqlConnection(this.sqlbaglan.conString);
            CNN.Open();
            string query0 = "SELECT ISNULL(MAX(DOC_NO), 0) + 1 AS NEWSNO FROM TRANSFER_HEADER";
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
            //txtSifarisNomresi.Clear();
            dgrvDocument.Rows.Clear();
            txtStockGroup.Clear();
            txtStockGroupId.Clear();
            txtStock.Clear();
            txtStockId.Clear();
            
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
                dgrvDocument.Columns["PurchaseUnit"].ReadOnly = false;
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
                       

                        // **TotalAmount-u yenilə**
                        decimal finalAmount = Math.Round(totalPrice - 0, 2);
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

        private void txtStockGroup_TextChanged(object sender, EventArgs e)
        {
            // Axtarış üçün açar sözü əldə edin
            string textToSearch = txtStockGroup.Text.ToLower();

            // ListBox-u gizlət
            lstStockGroup.Visible = false;

            if (string.IsNullOrEmpty(textToSearch))
                return; // Əgər açar söz boşdursa, ListBox-u gizli saxlayın

            // SQL sorğusu
            string query = "SELECT NAME FROM STOCKGROUP WHERE NAME LIKE @NAME";
            List<string> results = new List<string>();

            // Verilənlər bazasına qoşulmaq və sorğunu yerinə yetirmək
            using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametri əlavə etmək
                    command.Parameters.AddWithValue("@NAME", textToSearch + "%");

                    // Əlaqəni açmaq
                    connection.Open();

                    // Sorğunu yerinə yetirmək və nəticələri oxumaq
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(reader["NAME"].ToString());
                        }
                    }
                }
            }

            // Əgər heç bir nəticə tapılmayıbsa, ListBox-u gizli saxlayın
            if (results.Count == 0)
                return;

            // ListBox-u yeniləyin və görünən edin
            lstStockGroup.Items.Clear(); // Əlavə etmədən əvvəl təmizləməyi unutmayın
            lstStockGroup.Items.AddRange(results.ToArray());
            lstStockGroup.Visible = true; // ListBox-u yenidən görünən edin
        }

        private void lstStockGroup_Click(object sender, EventArgs e)
        {
            if (lstStockGroup.SelectedItem != null)
            {
                // Seçilmiş adı alırıq
                string selectedTamadi = lstStockGroup.SelectedItem.ToString();

                // SQL bağlantısını qururuq
                using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
                {
                    // SQL sorğusu, parametr ilə
                    string query = "SELECT ID, NAME FROM STOCKGROUP WHERE NAME = @NAME";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametri əlavə etmək
                        command.Parameters.AddWithValue("@NAME", selectedTamadi);

                        // Əlaqəni açmaq
                        connection.Open();

                        // Sorğunu yerinə yetirmək və nəticələri oxumaq
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // ID-ni və Tamadi-ni alırıq
                                txtStockGroupId.Text = reader["ID"].ToString();
                                txtStockGroup.Text = reader["NAME"].ToString();
                            }
                        }
                    }
                }

                // ListBox-u gizlədirik
                lstStockGroup.Visible = false;
            }
        }



        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            // Axtarış üçün açar sözü əldə edin
            string textToSearch = txtStock.Text.Trim().ToLower(); // Trim() boşluqları silir

            // ListBox-u gizlət
            lstStock.Visible = false;

            // Əgər açar söz boşdursa, bütün nəticələri gətir
            bool getAll = string.IsNullOrEmpty(textToSearch);

            // SQL sorğusu
            string query = "SELECT NAME FROM STOCK WHERE GROUP_ID = @StockGroupId AND (@NAME IS NULL OR NAME LIKE @NAME)";
            List<string> results = new List<string>();

            // Verilənlər bazasına qoşulmaq və sorğunu yerinə yetirmək
            using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StockGroupId", txtStockGroupId.Text);

                    if (getAll)
                        command.Parameters.AddWithValue("@NAME", DBNull.Value); // Bütün nəticələri gətir
                    else
                        command.Parameters.AddWithValue("@NAME", textToSearch + "%"); // Ad uyğunluğu üçün LIKE

                    // Əlaqəni açmaq
                    connection.Open();

                    // Sorğunu yerinə yetirmək və nəticələri oxumaq
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(reader["NAME"].ToString());
                        }
                    }
                }
            }

            // Əgər heç bir nəticə tapılmayıbsa, ListBox-u gizli saxlayın
            if (results.Count == 0)
                return;

            // ListBox-u yeniləyin və görünən edin
            lstStock.Items.Clear(); // Əlavə etmədən əvvəl təmizləməyi unutmayın
            lstStock.Items.AddRange(results.ToArray());
            lstStock.Visible = true; // ListBox-u yenidən görünən edin
        }

        private void lstStock_Click(object sender, EventArgs e)
        {
            if (lstStock.SelectedItem != null)
            {
                // Seçilmiş adı alırıq
                string selectedTamadi = lstStock.SelectedItem.ToString();

                // SQL bağlantısını qururuq
                using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
                {
                    // SQL sorğusu, parametr ilə
                    string query = "SELECT ID, NAME, LAST_PURCHASE_PRICE,BASE_UNIT,UNIT_NAME FROM VW_STOCK WHERE NAME = @NAME";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametri əlavə etmək
                        command.Parameters.AddWithValue("@NAME", selectedTamadi);

                        // Əlaqəni açmaq
                        connection.Open();

                        // Sorğunu yerinə yetirmək və nəticələri oxumaq
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // ID-ni, adını və son alış qiymətini alırıq
                                string stockId = reader["ID"].ToString();
                                string name = reader["NAME"].ToString();
                                string unitId = reader["BASE_UNIT"].ToString();
                                string unitname = reader["UNIT_NAME"].ToString();
                                string price = reader["LAST_PURCHASE_PRICE"].ToString();

                                // TextBox-lara yerləşdiririk
                                txtStockId.Text = stockId;
                                txtStock.Text = name;

                                // Məlumatları DataGridView-a əlavə edirik
                                AddNameToDataGridView(stockId, unitId, unitname, name, price);
                            }
                        }
                    }
                }

                // ListBox-u gizlədirik
                lstStock.Visible = false;
            }
        }



        //AddNameToDataGridView(xidmetID, selectedName, Qiymet, XidmetNovu, Endirim);
        private void AddNameToDataGridView(string stockId, string unitId, string unitname, string name, string price)
        {
            int rowIndex = dgrvDocument.Rows.Add();
            DataGridViewRow newRow = dgrvDocument.Rows[rowIndex];
            newRow.Cells["Date"].Value = DateTime.Now;
            newRow.Cells["StockId"].Value = stockId; // Assuming you have a column named Column1 for ID
            newRow.Cells["BaseUnitId"].Value = unitId; // Assuming you have a column named Column1 for ID
            newRow.Cells["DefaultUnit"].Value = unitname; // Assuming you have a column named Column1 for ID
            newRow.Cells["StockName"].Value = name;    // Assuming you have a column named Column2 for Name
            newRow.Cells["Price"].Value = price;    // Assuming you have a column named Column2 for Name
        }
    }
}


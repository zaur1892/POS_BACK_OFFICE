using iTextSharp.text.pdf;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_BACK_OFFICE
{
    public partial class frmWarehouseIncome : Form
    {
        private List<Product> productList = new List<Product>();
        private string offlineFolder = Path.Combine(Application.StartupPath, "OfflineDocs");
        private mssqlBaglanti sqlbaglan = new mssqlBaglanti();

        public frmWarehouseIncome()
        {
            InitializeComponent();
            Directory.CreateDirectory(offlineFolder);
        }

        //private void frmWarehouseIncome_Load(object sender, EventArgs e)
        //{
        //    //dtpDocDate1.Value = DateTime.Now;
        //    //dtpDocDate2.Value = DateTime.Now;
        //    LoadProducts();
        //    LoadOfflineDocuments();
        //    UpdateConnectionStatus();
        //    timerConnectionCheck.Start();


        //}

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barcode = txtBarcode.Text.Trim();

                if (barcode.Length == 13)
                {
                    string productCode = barcode.Substring(4, 3);
                    string weightStr = barcode.Substring(7, 6);

                    if (decimal.TryParse(weightStr, out decimal weight))
                    {
                        decimal weightKg = weight / 10000m; // <-- BURADA DÜZƏLDİM
                        string productName = GetProductNameByCode(productCode);

                        dataGridView1.Rows.Insert(0, barcode, productName, weightKg);
                        dataGridView1.Rows[0].Tag = productCode;
                    }
                }

                txtBarcode.Clear();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private string GetProductNameByCode(string code)
        {
            var product = productList.FirstOrDefault(p => p.Code.Trim() == code.Trim());
            return product != null ? product.Name : "Naməlum məhsul";
        }

        private void LoadProducts()
        {
            string path = Path.Combine(Application.StartupPath, "products.json");
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                productList = JsonSerializer.Deserialize<List<Product>>(json);
            }
        }
        private void btnSaveOffline_Click(object sender, EventArgs e)
        {
            int docNumber = GetNextDocNumber();
            string filePath = Path.Combine(offlineFolder, $"{docNumber}.json");

            List<OfflineItem> items = new List<OfflineItem>();

            // Yalnız məlumat daxil edilmiş sətirləri əlavə edirik
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    // Boş sətir daxil edildikdə, onu əlavə etmirik
                    if (string.IsNullOrWhiteSpace(row.Cells[0].Value?.ToString()) ||
                        string.IsNullOrWhiteSpace(row.Cells[1].Value?.ToString()) ||
                        row.Cells[2].Value == null)
                    {
                        continue; // Boş sətir varsa, onu əlavə etməmək üçün davam edirik
                    }

                    items.Add(new OfflineItem
                    {
                        Barcode = row.Cells[0].Value?.ToString(),
                        Name = row.Cells[1].Value?.ToString(),
                        Quantity = Convert.ToDecimal(row.Cells[2].Value),
                        Date = DateTime.Now,
                        Code = row.Tag?.ToString(),
                        IsSent = false
                    });
                }
            }

            // Əgər heç bir məlumatlı sətir yoxdursa, saxlanılmağı dayandırırıq
            if (items.Count == 0)
            {
                MessageBox.Show("Heç bir məlumat daxil edilməyib. Sənəd saxlanıla bilməz.");
                return;
            }

            // JSON-u saxlayırıq
            string json = JsonSerializer.Serialize(items, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);

            MessageBox.Show($"Sənəd #{docNumber} yadda saxlanıldı.");
            dataGridView1.Rows.Clear();
            LoadOfflineDocuments();
        }


        private int GetNextDocNumber()
        {
            var files = Directory.GetFiles(offlineFolder, "*.json");

            int maxNumber = 0;
            foreach (var file in files)
            {
                string fileName = Path.GetFileNameWithoutExtension(file); // Məs: "56"
                if (int.TryParse(fileName, out int num))
                {
                    if (num > maxNumber)
                        maxNumber = num;
                }
            }

            return maxNumber + 1;
        }


        private void LoadOfflineDocuments()
        {
            lstOfflineDocuments.Items.Clear();
            var files = Directory.GetFiles(offlineFolder, "*.json");

            DateTime startDate = dtpDocDate1.Value.Date;
            DateTime endDate = dtpDocDate2.Value.Date;

            foreach (var file in files)
            {
                string json = File.ReadAllText(file);
                var items = JsonSerializer.Deserialize<List<OfflineItem>>(json);

                // Əgər heç bir item yoxdursa, bu sənədi keç
                if (items == null || items.Count == 0)
                    continue;

                // Tarix aralığına uyğunluq yoxlanışı (ən azı bir item uyğun gəlirsə, göstər)
                if (!items.Any(x => x.Date.Date >= startDate && x.Date.Date <= endDate))
                    continue;

                string name = Path.GetFileNameWithoutExtension(file);
                bool allSent = items.All(x => x.IsSent);
                string displayText = $"Sənəd #{name}" + (allSent ? " (Göndərildi)" : "");
                lstOfflineDocuments.Items.Add(displayText);
            }
        }

        private void btnSendToWarehouse_Click(object sender, EventArgs e)
        {
            if (lstOfflineDocuments.SelectedItem == null) return;

            int selectedIndex = lstOfflineDocuments.SelectedIndex;
            string selectedText = lstOfflineDocuments.SelectedItem.ToString();

            if (selectedText.Contains("(Göndərildi)"))
            {
                CustomAlertForm.ShowAlert("Diqqət!", "Bu sənəd artıq göndərilib.", AlertType.Warning);
                return;
            }

            string docNumberText = selectedText.Replace("Sənəd #", "").Replace("(Göndərildi)", "").Trim();
            string filePath = Path.Combine(offlineFolder, docNumberText + ".json");

            // ✅ UI-də əvvəlcədən işarələyirik
            lstOfflineDocuments.Items[selectedIndex] = $"{selectedText} (Göndərildi)";
            lstOfflineDocuments.Refresh();

            try
            {
                if (!File.Exists(filePath))
                {
                    CustomAlertForm.ShowAlert("Xəta", "Sənəd faylı tapılmadı.", AlertType.Error);
                    lstOfflineDocuments.Items[selectedIndex] = selectedText;
                    return;
                }

                // 📦 Fayl LOCK ilə oxunur
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    string json;
                    using (StreamReader reader = new StreamReader(fs))
                    {
                        json = reader.ReadToEnd();
                    }

                    var items = JsonSerializer.Deserialize<List<OfflineItem>>(json);

                    int newDocNo = GetNextDocNumberFromDatabase();
                    if (newDocNo == -1)
                    {
                        CustomAlertForm.ShowAlert("Xəta", "Yeni sənəd nömrəsi alınmadı.", AlertType.Error);
                        lstOfflineDocuments.Items[selectedIndex] = selectedText;
                        return;
                    }

                    txtSifarisNomresi.Text = newDocNo.ToString(); // ✅ Yeni sənəd nömrəsi UI-ya da yazılır

                    bool isSuccess = AddToWarehouse(items, newDocNo, selectedText); // 🆕 doğru parametrlərlə çağırılır

                    if (!isSuccess)
                    {
                        lstOfflineDocuments.Items[selectedIndex] = selectedText;
                    }
                    else
                    {
                        foreach (var item in items)
                        {
                            item.IsSent = true;
                        }

                        string updatedJson = JsonSerializer.Serialize(items, new JsonSerializerOptions { WriteIndented = true });
                        File.WriteAllText(filePath, updatedJson);

                        CustomAlertForm.ShowAlert("Uğurlu Əməliyyat", $"Sənəd #{docNumberText} uğurla göndərildi.", AlertType.Success);
                    }
                }
            }
            catch (IOException)
            {
                CustomAlertForm.ShowAlert("Xəta", "Fayl hazırda istifadə olunur və ya kilidlənib.", AlertType.Warning);
                lstOfflineDocuments.Items[selectedIndex] = selectedText;
            }
            catch (Exception ex)
            {
                CustomAlertForm.ShowAlert("Xəta", "Sənəd göndərilərkən xəta baş verdi:\n" + ex.Message, AlertType.Error);
                lstOfflineDocuments.Items[selectedIndex] = selectedText;
            }
        }

        private bool AddToWarehouse(List<OfflineItem> items, int docNum, string offlineDocNo)
        {
            SqlTransaction transaction = null;
            try
            {
                DateTime docDate = dtpDocDate1.Value;

                using (SqlConnection conn = new SqlConnection(this.sqlbaglan.conString))
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    foreach (var item in items)
                    {
                        SqlCommand cmd = new SqlCommand("SP_InsertDocumentsFromBarcode", conn)
                        {
                            CommandType = CommandType.StoredProcedure,
                            Transaction = transaction
                        };

                        cmd.Parameters.AddWithValue("@Doc_No", docNum);
                        cmd.Parameters.AddWithValue("@Tarix", docDate);
                        cmd.Parameters.AddWithValue("@Barcode", item.Barcode);
                        cmd.Parameters.AddWithValue("@Code", item.Code);
                        cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                        cmd.Parameters.AddWithValue("@TotalQuantity", item.Quantity);
                        cmd.Parameters.AddWithValue("@Price", 0);
                        cmd.Parameters.AddWithValue("@OfflineDocNo", offlineDocNo);

                        int result = cmd.ExecuteNonQuery();
                        if (result <= 0)
                        {
                            continue;
                        }

                        item.IsSent = true;
                    }

                    transaction.Commit();
                }

                return true;
            }
            catch (SqlException sqlEx)
            {
                transaction?.Rollback();
                MessageBox.Show($"SQL Error: {sqlEx.Message}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show($"Error: {ex.Message}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

















        private void timerConnectionCheck_Tick(object sender, EventArgs e)
        {
            UpdateConnectionStatus();
        }

        private async void UpdateConnectionStatus()
        {
            bool isConnected = await CheckConnectionAsync();

            if (isConnected)
            {
                lblStatus.Text = "🟢 Online";
                lblStatus.ForeColor = Color.Green;
                btnSendToWarehouse.Enabled = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;

                // Sifariş nömrəsi yalnız bir dəfə alınır, əgər hələ təyin olunmayıbsa
                if (string.IsNullOrWhiteSpace(txtSifarisNomresi.Text) || txtSifarisNomresi.Text.StartsWith("OFFLINE"))
                {
                    try
                    {
                        //GetNextDocNumberFromDatabase();
                    }
                    catch
                    {
                        txtSifarisNomresi.Text = "OFFLINE-" + DateTime.Now.ToString("yyyyMMddHHmmss");
                    }
                }
            }
            else
            {
                lblStatus.Text = "";
                btnSendToWarehouse.Enabled = false;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;

                // Offline rejimində sifariş nömrəsi offline formatında göstərilir
                txtSifarisNomresi.Text = "OFFLINE-" + DateTime.Now.ToString("yyyyMMddHHmmss");
            }
        }

        private int GetNextDocNumberFromDatabase()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(this.sqlbaglan.conString))
                {
                    connection.Open();
                    string query = "SELECT ISNULL(MAX(DOC_NO), 0) + 1 AS NEW_DOC_NO FROM DOCUMENT_HEADER";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        return Convert.ToInt32(result);
                    }
                }
            }
            catch
            {
                return -1; // Bazaya çıxmaq olmursa, -1 göndər
            }
        }




        private async Task<bool> CheckConnectionAsync()
        {
            return await Task.Run(() =>
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(this.sqlbaglan.conString))
                    {
                        conn.Open();
                        return conn.State == ConnectionState.Open;
                        
                    }
                }
                catch
                {
                    return false;
                }
            });
        }

        private void lstOfflineDocuments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOfflineDocuments.SelectedItem == null) return;

            string selectedText = lstOfflineDocuments.SelectedItem.ToString();
            string docNumber = selectedText.Replace("Sənəd #", "").Replace(" (Göndərildi)", "");
            string filePath = Path.Combine(offlineFolder, docNumber + ".json");

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var items = JsonSerializer.Deserialize<List<OfflineItem>>(json);

                dgvDocDetails.Rows.Clear();
                dgvDocDetails.Columns.Clear();

                dgvDocDetails.Columns.Add("Barcode", "Barkod");
                dgvDocDetails.Columns.Add("Code", "Kod");
                dgvDocDetails.Columns.Add("Name", "Məhsul Adı");
                dgvDocDetails.Columns.Add("Quantity", "Miqdar");
                dgvDocDetails.Columns.Add("Date", "Tarix");

                foreach (var item in items)
                {
                    dgvDocDetails.Rows.Add(item.Barcode, item.Code, item.Name, item.Quantity, item.Date.ToString("yyyy-MM-dd HH:mm"));
                }

                // JSON faylındakı ən erkən tarixi istifadə et
                //dtpDocDate.Value = items.Min(x => x.Date);
            }
        }

        private void btnOpenProductForm_Click(object sender, EventArgs e)
        {
            frmProductManager productManager = new frmProductManager();
            productManager.StartPosition = FormStartPosition.Manual; // Manual olaraq yer təyin edirik
            productManager.Location = new Point(10, 10); // Soldan 10px, yuxarıdan 10px
            productManager.ShowDialog();
            LoadProducts();
        }


        private void frmWarehouseIncome_Load_1(object sender, EventArgs e)
        {
            dtpDocDate1.Value = DateTime.Now;
            dtpDocDate2.Value = DateTime.Now;
            lstOfflineDocuments.DrawMode = DrawMode.OwnerDrawFixed;
            lstOfflineDocuments.DrawItem += lstOfflineDocuments_DrawItem;

            LoadProducts();
        }

        private void lstOfflineDocuments_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            string itemText = lstOfflineDocuments.Items[e.Index].ToString();
            bool isSent = itemText.Contains("(Göndərildi)");

            e.DrawBackground();

            using (Brush brush = new SolidBrush(isSent ? Color.Red : Color.Black))
            {
                e.Graphics.DrawString(itemText, e.Font, brush, e.Bounds);
            }

            e.DrawFocusRectangle();
        }

        private void dtpDocDate_ValueChanged(object sender, EventArgs e)
        {
            LoadOfflineDocuments();
        }
        private void dtpDocDate2_ValueChanged(object sender, EventArgs e)
        {
            LoadOfflineDocuments();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridView1.HitTest(e.X, e.Y);

                if (hit.RowIndex >= 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[hit.RowIndex].Selected = true; // Sağ kliklənən sətri seçirik
                    contextMenuStrip1.Show(dataGridView1, e.Location);
                }
            }
        }
        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }
    }
}

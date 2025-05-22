using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using DataTable = System.Data.DataTable;
using System.Collections;
using iTextSharp.text;
using com.itextpdf.text.pdf;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Data.SqlClient;
using POS_BACK_OFFICE;

namespace POS_BACK_OFFICE
{
    public partial class frmDetalliSatisAnaliz : Form
    {
        public frmDetalliSatisAnaliz()
        {
            InitializeComponent();
        }
        private mssqlBaglanti sqlbaglan = new mssqlBaglanti();

        private void btnGoster_Click(object sender, EventArgs e)
        {
            // Get the selected date and time from the DateTimePicker
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            string formattedDateTime1 = startDate.ToString("yyyy-MM-dd");
            string formattedDateTime2 = endDate.ToString("yyyy-MM-dd");

            // Define the connection string (adjust as needed for your database)
            SqlConnection connection = new SqlConnection(this.sqlbaglan.conString);

            // Define the query with a parameter placeholder
            string query = @"
        Select * from InventoryTransactions 
        WHERE Date >= @StartDate 
        AND Date <= @EndDate";

            // Create a new DataTable to hold the query results
            DataTable dataTable = new DataTable();

            // Create a new SqlDataAdapter
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                // Add the parameter to the SqlCommand object of the SqlDataAdapter
                //adapter.SelectCommand.Parameters.AddWithValue("@SaheId", txtSaheId.Text + "%");
                //adapter.SelectCommand.Parameters.AddWithValue("@XidmetNovuId", txtServiceCatId.Text + "%");
                //adapter.SelectCommand.Parameters.AddWithValue("@XidmetId", txtServiceId.Text + "%");
                //adapter.SelectCommand.Parameters.AddWithValue("@PasientId", txtPasientId.Text + "%");
                //adapter.SelectCommand.Parameters.AddWithValue("@GhekimId", txtGonderenHekimId.Text + "%");
                //adapter.SelectCommand.Parameters.AddWithValue("@MuayineHekimId", txtMuayineHekimId.Text + "%");
                //adapter.SelectCommand.Parameters.AddWithValue("@Sifarisno", txtSifarisNo.Text + "%");
                adapter.SelectCommand.Parameters.AddWithValue("@StartDate", formattedDateTime1);
                adapter.SelectCommand.Parameters.AddWithValue("@EndDate", formattedDateTime2);

                // Open the connection
                connection.Open();

                // Fill the DataTable with the query results
                adapter.Fill(dataTable);
            }

            // Bind the DataTable to the DataGridView
            addgrvDetalliSatis.DataSource = dataTable;
       

            // btnGoster Click hadisəsi
            // Məlumatları göstərmək üçün digər əməliyyatlar...
            // Məsələn, DataGridView-ə məlumatların yüklənməsi kodu buraya daxil ola bilər.

            // Məlumatlar yeniləndikdən sonra toplamları yeniləmək
            HesablaVeGoster();
        }


        //LABELLERI UPDATE ETMEK - SATIS ENDIRIM - NET SATIS MEBLEGLERI

        // Mebleg, Endirim və Cəm toplamlarını hesablayıb müvafiq etiketlərə yazan metod
        private void HesablaVeGoster()
        {
            decimal toplamMebleg = 0;
            decimal toplamEndirim = 0;
            decimal toplamCem = 0;
            int xidmetSay = 0;
            HashSet<string> sifarisNoSet = new HashSet<string>();

            foreach (DataGridViewRow row in addgrvDetalliSatis.Rows)
            {
                // Sətirin boş olmadığını yoxlamaq
                if (!row.IsNewRow)
                {
                    xidmetSay++;

                    if (row.Cells["TotalPrice"].Value != DBNull.Value)
                        toplamMebleg += Convert.ToDecimal(row.Cells["TotalPrice"].Value);

                    if (row.Cells["TotalPrice"].Value != DBNull.Value)
                        toplamEndirim += Convert.ToDecimal(row.Cells["TotalPrice"].Value);

                    if (row.Cells["TotalPrice"].Value != DBNull.Value)
                        toplamCem += Convert.ToDecimal(row.Cells["TotalPrice"].Value);

                    // Sifarisno-nu yığan və təkrarlanmayandan hesablayan hissə
                    string sifarisNo = row.Cells["TotalPrice"].Value?.ToString();
                    if (!string.IsNullOrEmpty(sifarisNo))
                    {
                        sifarisNoSet.Add(sifarisNo);
                    }
                }
            }

            // Hesablanmış toplamları label-lərə yazmaq
            lblSatisMebleg.Text = toplamMebleg.ToString("N2");
            lblEndirimMebleg.Text = toplamEndirim.ToString("N2");
            lblNetSatisMebleg.Text = toplamCem.ToString("N2");

            // Xidmet sayını və təkrarlanmayan sifariş sayını göstərmək
            lblXidmetSay.Text = xidmetSay.ToString();
            lblSifarisSay.Text = sifarisNoSet.Count.ToString();
        }



        private void frmDetalliSatisAnaliz_Load(object sender, EventArgs e)
        {
            string query = "Select * from DOCUMENT_HEADER";
            SqlConnection connection = new SqlConnection(sqlbaglan.conString);
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                List<string> names = new List<string>();

                while (reader.Read())
                {
                    names.Add(reader["DOC_DATE"].ToString());
                }

                reader.Close();
                cmbSahe.Items.Clear();
                cmbSahe.Items.AddRange(names.ToArray());
            }

        }

        private void cmbSahe_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.sqlbaglan.conString);
            connection.Open();
            string queryFill = "SELECT ID FROM ServiceGroup WHERE name = @name";

            SqlCommand commandFill = new SqlCommand(queryFill, connection);
            commandFill.Parameters.AddWithValue("@name", cmbSahe.Text);

            // Execute the SQL query and retrieve the result using SqlDataReader
            SqlDataReader readerFill = commandFill.ExecuteReader();

            if (readerFill.Read()) // Check if there is data to read
            {
                // Fill textboxes with data from the query
                txtSaheId.Text = readerFill["ID"].ToString();
            }
        }

        private void cmbServiceCat_Enter(object sender, EventArgs e)
        {
            string query = "SELECT Name FROM Services WHERE tip = @tip and cat = ''  and status = 2";
            SqlConnection connection = new SqlConnection(sqlbaglan.conString);
            {
                SqlCommand command = new SqlCommand(query, connection);
                // Adding a parameter for the txtSaheId value
                command.Parameters.AddWithValue("@tip", txtSaheId.Text);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                List<string> names = new List<string>();

                while (reader.Read())
                {
                    names.Add(reader["Name"].ToString());
                }

                reader.Close();
                cmbServiceCat.Items.Clear();
                cmbServiceCat.Items.AddRange(names.ToArray());
            }

        }

        private void cmbServiceCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.sqlbaglan.conString);
            connection.Open();
            string queryFill = "SELECT ID FROM Services WHERE name = @name and status = 2";

            SqlCommand commandFill = new SqlCommand(queryFill, connection);
            commandFill.Parameters.AddWithValue("@name", cmbServiceCat.Text);

            // Execute the SQL query and retrieve the result using SqlDataReader
            SqlDataReader readerFill = commandFill.ExecuteReader();

            if (readerFill.Read()) // Check if there is data to read
            {
                // Fill textboxes with data from the query
                txtServiceCatId.Text = readerFill["ID"].ToString();
            }
        }

        private void cmbService_Enter(object sender, EventArgs e)
        {
            listBox1.Visible = false; // ListBox-u görünMEZ edin

            SqlConnection connection = new SqlConnection(sqlbaglan.conString);
            {
                string query = "SELECT Name FROM Services WHERE SUB LIKE @SUB AND CAT !='' and status = 2";
                SqlCommand command = new SqlCommand(query, connection);
                // Adding a parameter for the txtSaheId value
                command.Parameters.AddWithValue("@SUB", txtServiceCatId.Text + "%");

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                List<string> names = new List<string>();

                while (reader.Read())
                {
                    names.Add(reader["Name"].ToString());
                }

                reader.Close();
                cmbService.Items.Clear();
                cmbService.Items.AddRange(names.ToArray());

                listBox1.Visible = false; // ListBox-u görünMEZ edin
            }
        }

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.sqlbaglan.conString);
            connection.Open();
            string queryFill = "SELECT ID FROM Services WHERE name = @name and status = 2";

            SqlCommand commandFill = new SqlCommand(queryFill, connection);
            commandFill.Parameters.AddWithValue("@name", cmbService.Text);

            // Execute the SQL query and retrieve the result using SqlDataReader
            SqlDataReader readerFill = commandFill.ExecuteReader();

            if (readerFill.Read()) // Check if there is data to read
            {
                // Fill textboxes with data from the query
                txtServiceId.Text = readerFill["ID"].ToString();
            }
        }

        private void cmbService_TextChanged(object sender, EventArgs e)
        {
            // Axtarış üçün açar sözü əldə edin
            string textToSearch = cmbService.Text.ToLower();
            listBox1.Visible = false; // ListBox-u gizlət

            if (string.IsNullOrEmpty(textToSearch))
                return; // Əgər açar söz boşdursa, ListBox-u gizli saxlayın

            // SQL sorğusu
            string query = "SELECT Name FROM Services WHERE Name LIKE @Name AND Tip like @Tip and SUB LIKE @SUB  and Status = 2";
            List<string> results = new List<string>();

            // Verilənlər bazasına qoşulmaq və sorğunu yerinə yetirmək
            using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametri əlavə etmək
                    command.Parameters.AddWithValue("@Name", textToSearch + "%");
                    command.Parameters.AddWithValue("@Tip", txtSaheId.Text + "%");
                    command.Parameters.AddWithValue("@SUB", txtServiceCatId.Text + "%");

                    // Əlaqəni açmaq
                    connection.Open();

                    // Sorğunu yerinə yetirmək və nəticələri oxumaq
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(reader["Name"].ToString());
                        }
                    }
                }
            }

            // Əgər heç bir nəticə tapılmayıbsa, ListBox-u gizli saxlayın
            if (results.Count == 0)
                return;

            // ListBox-u yeniləyin və görünən edin
            listBox1.Items.Clear(); // Əlavə etmədən əvvəl təmizləməyi unutmayın
            listBox1.Items.AddRange(results.ToArray());
            listBox1.Visible = true; // ListBox-u yenidən görünən edin
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                // Seçilmiş adı alırıq
                string selectedName = listBox1.SelectedItem.ToString();

                // SQL bağlantısını qururuq
                using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
                {
                    // SQL sorğusu, parametr ilə
                    string query = "SELECT ID FROM Services WHERE Name = @Name";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametri əlavə etmək
                        command.Parameters.AddWithValue("@Name", selectedName);

                        // Əlaqəni açmaq
                        connection.Open();

                        // Sorğunu yerinə yetirmək və nəticəni oxumaq
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            // ID-ni TextBox-a yazırıq
                            txtServiceId.Text = result.ToString();
                        }
                    }
                }

                // ComboBox-a seçilmiş adı yazırıq
                cmbService.Text = selectedName;

                // ListBox-u gizlədirik
                listBox1.Visible = false;
            }
        }

        private void cmbService_Leave(object sender, EventArgs e)
        {
            //listBox1.Visible = false; // ListBox-u görünMEZ edin
        }

        private void txtPasient_TextChanged(object sender, EventArgs e)
        {
            // Axtarış üçün açar sözü əldə edin
            string textToSearch = txtPasient.Text.ToLower();

            // ListBox-u gizlət
            lstPasient.Visible = false;

            if (string.IsNullOrEmpty(textToSearch))
                return; // Əgər açar söz boşdursa, ListBox-u gizli saxlayın

            // SQL sorğusu
            string query = "SELECT Tamadi FROM Vw_Aktiv_Pasientler WHERE Tamadi LIKE @Tamadi";
            List<string> results = new List<string>();

            // Verilənlər bazasına qoşulmaq və sorğunu yerinə yetirmək
            using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametri əlavə etmək
                    command.Parameters.AddWithValue("@Tamadi", textToSearch + "%");

                    // Əlaqəni açmaq
                    connection.Open();

                    // Sorğunu yerinə yetirmək və nəticələri oxumaq
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(reader["Tamadi"].ToString());
                        }
                    }
                }
            }

            // Əgər heç bir nəticə tapılmayıbsa, ListBox-u gizli saxlayın
            if (results.Count == 0)
                return;

            // ListBox-u yeniləyin və görünən edin
            lstPasient.Items.Clear(); // Əlavə etmədən əvvəl təmizləməyi unutmayın
            lstPasient.Items.AddRange(results.ToArray());
            lstPasient.Visible = true; // ListBox-u yenidən görünən edin

        }

        private void lstPasient_DoubleClick(object sender, EventArgs e)
        {
            if (lstPasient.SelectedItem != null)
            {
                // Seçilmiş adı alırıq
                string selectedTamadi = lstPasient.SelectedItem.ToString();

                // SQL bağlantısını qururuq
                using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
                {
                    // SQL sorğusu, parametr ilə
                    string query = "SELECT id, Tamadi FROM Vw_Aktiv_Pasientler WHERE Tamadi = @Tamadi";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametri əlavə etmək
                        command.Parameters.AddWithValue("@Tamadi", selectedTamadi);

                        // Əlaqəni açmaq
                        connection.Open();

                        // Sorğunu yerinə yetirmək və nəticələri oxumaq
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // ID-ni və Tamadi-ni alırıq
                                txtPasientId.Text = reader["id"].ToString();
                                txtPasient.Text = reader["Tamadi"].ToString();
                            }
                        }
                    }
                }

                // ListBox-u gizlədirik
                lstPasient.Visible = false;
            }
        }

        private void txtGonderenHekim_TextChanged(object sender, EventArgs e)
        {
            // Axtarış üçün açar sözü əldə edin
            string textToSearch = txtGonderenHekim.Text.ToLower();

            // ListBox-u gizlət
            lstGonderenHekim.Visible = false;

            if (string.IsNullOrEmpty(textToSearch))
                return; // Əgər açar söz boşdursa, ListBox-u gizli saxlayın

            // SQL sorğusu
            string query = "SELECT Adsoyad FROM SenderDoctor WHERE Adsoyad LIKE @Adsoyad";
            List<string> results = new List<string>();

            // Verilənlər bazasına qoşulmaq və sorğunu yerinə yetirmək
            using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametri əlavə etmək
                    command.Parameters.AddWithValue("@Adsoyad", textToSearch + "%");

                    // Əlaqəni açmaq
                    connection.Open();

                    // Sorğunu yerinə yetirmək və nəticələri oxumaq
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(reader["Adsoyad"].ToString());
                        }
                    }
                }
            }

            // Əgər heç bir nəticə tapılmayıbsa, ListBox-u gizli saxlayın
            if (results.Count == 0)
                return;

            // ListBox-u yeniləyin və görünən edin
            lstGonderenHekim.Items.Clear(); // Əlavə etmədən əvvəl təmizləməyi unutmayın
            lstGonderenHekim.Items.AddRange(results.ToArray());
            lstGonderenHekim.Visible = true; // ListBox-u yenidən görünən edin
        }

        private void lstGonderenHekim_DoubleClick(object sender, EventArgs e)
        {
            if (lstGonderenHekim.SelectedItem != null)
            {
                // Seçilmiş adı alırıq
                string selectedName = lstGonderenHekim.SelectedItem.ToString();

                // SQL bağlantısını qururuq
                using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
                {
                    // SQL sorğusu, parametr ilə
                    string query = "SELECT id,Adsoyad FROM SenderDoctor WHERE Adsoyad = @Adsoyad";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametri əlavə etmək
                        command.Parameters.AddWithValue("@Adsoyad", selectedName);

                        // Əlaqəni açmaq
                        connection.Open();

                        // Sorğunu yerinə yetirmək və nəticələri oxumaq
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // ID-ni və Name-i alırıq
                                txtGonderenHekimId.Text = reader["id"].ToString();
                                txtGonderenHekim.Text = reader["Adsoyad"].ToString();
                            }
                        }
                    }
                }

                // ListBox-u gizlədirik
                lstGonderenHekim.Visible = false;
            }
        }

        private void lstGonderenHekim_DoubleClick_1(object sender, EventArgs e)
        {
            if (lstGonderenHekim.SelectedItem != null)
            {
                // Seçilmiş adı alırıq
                string selectedName = lstGonderenHekim.SelectedItem.ToString();

                // SQL bağlantısını qururuq
                using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
                {
                    // SQL sorğusu, parametr ilə
                    string query = "Select id,Adsoyad From SenderDoctor WHERE Adsoyad = @Adsoyad";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametri əlavə etmək
                        command.Parameters.AddWithValue("@Adsoyad", selectedName);

                        // Əlaqəni açmaq
                        connection.Open();

                        // Sorğunu yerinə yetirmək və nəticələri oxumaq
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // ID-ni və Name-i alırıq
                                txtGonderenHekimId.Text = reader["id"].ToString();
                                txtGonderenHekim.Text = reader["Adsoyad"].ToString();
                            }
                        }
                    }
                }

                // ListBox-u gizlədirik
                lstGonderenHekim.Visible = false;
            }

        }

        private void txtMuayineHekim_TextChanged(object sender, EventArgs e)
        {
            // Axtarış üçün açar sözü əldə edin
            string textToSearch = txtMuayineHekim.Text.ToLower();

            // ListBox-u gizlət
            lstMuayineHekim.Visible = false;

            if (string.IsNullOrEmpty(textToSearch))
                return; // Əgər açar söz boşdursa, ListBox-u gizli saxlayın

            // SQL sorğusu
            string query = "SELECT Adsoyad FROM SenderDoctor WHERE Adsoyad LIKE @Adsoyad";
            List<string> results = new List<string>();

            // Verilənlər bazasına qoşulmaq və sorğunu yerinə yetirmək
            using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametri əlavə etmək
                    command.Parameters.AddWithValue("@Adsoyad", textToSearch + "%");

                    // Əlaqəni açmaq
                    connection.Open();

                    // Sorğunu yerinə yetirmək və nəticələri oxumaq
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(reader["Adsoyad"].ToString());
                        }
                    }
                }
            }

            // Əgər heç bir nəticə tapılmayıbsa, ListBox-u gizli saxlayın
            if (results.Count == 0)
                return;

            // ListBox-u yeniləyin və görünən edin
            lstMuayineHekim.Items.Clear(); // Əlavə etmədən əvvəl təmizləməyi unutmayın
            lstMuayineHekim.Items.AddRange(results.ToArray());
            lstMuayineHekim.Visible = true; // ListBox-u yenidən görünən edin
        }

        private void lstMuayineHekim_DoubleClick(object sender, EventArgs e)
        {
            if (lstMuayineHekim.SelectedItem != null)
            {
                // Seçilmiş adı alırıq
                string selectedName = lstMuayineHekim.SelectedItem.ToString();

                // SQL bağlantısını qururuq
                using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
                {
                    // SQL sorğusu, parametr ilə
                    string query = "Select id,Adsoyad From SenderDoctor WHERE Adsoyad = @Adsoyad";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametri əlavə etmək
                        command.Parameters.AddWithValue("@Adsoyad", selectedName);

                        // Əlaqəni açmaq
                        connection.Open();

                        // Sorğunu yerinə yetirmək və nəticələri oxumaq
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // ID-ni və Name-i alırıq
                                txtMuayineHekimId.Text = reader["id"].ToString();
                                txtMuayineHekim.Text = reader["Adsoyad"].ToString();
                            }
                        }
                    }
                }

                // ListBox-u gizlədirik
                lstMuayineHekim.Visible = false;
            }
        }

        private void cmbTarixFiltr_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilmiş elementi alırıq
            string selectedFilter = cmbTarixFiltr.SelectedItem.ToString();

            // Bugünkü tarixi alırıq
            DateTime today = DateTime.Today;

            // Uyğun tarixləri təyin edirik
            switch (selectedFilter)
            {
                case "Dünən":
                    dateTimePicker1.Value = today.AddDays(-1);
                    dateTimePicker2.Value = today.AddDays(-1);
                    break;
                case "Keçən Həftə":
                    dateTimePicker1.Value = today.AddDays(-(int)today.DayOfWeek - 6);
                    dateTimePicker2.Value = today.AddDays(-(int)today.DayOfWeek);
                    break;
                case "Bu Ay":
                    dateTimePicker1.Value = new DateTime(today.Year, today.Month, 1);
                    dateTimePicker2.Value = today;
                    break;
                case "Keçən Ay":
                    DateTime firstDayOfLastMonth = new DateTime(today.Year, today.Month, 1).AddMonths(-1);
                    dateTimePicker1.Value = firstDayOfLastMonth;
                    dateTimePicker2.Value = firstDayOfLastMonth.AddMonths(1).AddDays(-1);
                    break;
                case "Bu il":
                    dateTimePicker1.Value = new DateTime(today.Year, 1, 1);
                    dateTimePicker2.Value = today;
                    break;
                case "Keçən İl":
                    dateTimePicker1.Value = new DateTime(today.Year - 1, 1, 1);
                    dateTimePicker2.Value = new DateTime(today.Year - 1, 12, 31);
                    break;
                case "Son On İllik":
                    dateTimePicker1.Value = today.AddYears(-10);
                    dateTimePicker2.Value = today;
                    break;
                default:
                    // Seçimlər arasında olmayan dəyərlər üçün bir şey etməyə ehtiyac yoxdur
                    break;
            }

        }

        private void btnMHekimiDeyish_Click(object sender, EventArgs e)
        {
            // DataGridView-dən seçilmiş sətirin ID-sini əldə etmək
            if (adaddgrvDetalliSatis.SelectedRows.Count > 0)
            {
                int selectedRowIndex = adaddgrvDetalliSatis.SelectedRows[0].Index;
                int id = Convert.ToInt32(adaddgrvDetalliSatis.Rows[selectedRowIndex].Cells["ID"].Value);

                // TextBox-dan müayinə hekimi əldə etmək
                string muayineHekimId = txtMuayineHekimId.Text;

                // Müayinə həkimi seçilmişdirsə
                if (!string.IsNullOrEmpty(muayineHekimId))
                {
                    // Dəyişiklikləri təsdiqləmə mesajı
                    DialogResult result = MessageBox.Show("Qeyd edilən sətrdə qeyd olunan Müayinə Həkimi dəyişəcək. Əminsiniz mi?", "Təsdiq", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // SQL bağlantısını açmaq və proseduru çağırmaq
                        using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
                        {
                            using (SqlCommand command = new SqlCommand("SP_MHekimDeyis", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                // Prosedur parametrlərini əlavə etmək
                                command.Parameters.AddWithValue("@id", id);
                                command.Parameters.AddWithValue("@muayinehekim", muayineHekimId);

                                // Əlaqəni açmaq
                                connection.Open();

                                // Proseduru icra etmək
                                command.ExecuteNonQuery();
                            }
                        }
                        // TextBox-ları təmizləmək
                        txtMuayineHekimId.Text = "";
                        txtMuayineHekim.Text = "";

                        // btnGoster düyməsini basmaq
                        btnGoster.PerformClick();

                        // Məlumatları yenilədikdən sonra əvvəlki seçimi bərpa etmək
                        if (selectedRowIndex >= 0 && selectedRowIndex < adaddgrvDetalliSatis.Rows.Count)
                        {
                            adaddgrvDetalliSatis.ClearSelection();
                            adaddgrvDetalliSatis.Rows[selectedRowIndex].Selected = true;
                            adaddgrvDetalliSatis.FirstDisplayedScrollingRowIndex = selectedRowIndex;
                        }
                    }
                }
            }
        }

        private void btnGHekimiDeyish_Click(object sender, EventArgs e)
        {
            // DataGridView-dən seçilmiş sətirin ID-sini əldə etmək
            if (adaddgrvDetalliSatis.SelectedRows.Count > 0)
            {
                int selectedRowIndex = adaddgrvDetalliSatis.SelectedRows[0].Index;
                int sifarisno = Convert.ToInt32(adaddgrvDetalliSatis.Rows[selectedRowIndex].Cells["Sifarisno"].Value);

                // TextBox-dan müayinə hekimi əldə etmək
                string gonderenHekimId = txtGonderenHekimId.Text;

                // Müayinə həkimi seçilmişdirsə
                if (!string.IsNullOrEmpty(gonderenHekimId))
                {
                    // Dəyişiklikləri təsdiqləmə mesajı
                    DialogResult result = MessageBox.Show("Qeyd edilən sətrdə qeyd olunan Göndərən Həkimi bütün sifarişdə! dəyişəcək. Əminsiniz mi?", "Təsdiq", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // SQL bağlantısını açmaq və proseduru çağırmaq
                        using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
                        {
                            using (SqlCommand command = new SqlCommand("SP_GHekimDeyis", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                // Prosedur parametrlərini əlavə etmək
                                command.Parameters.AddWithValue("@sifarisno", sifarisno);
                                command.Parameters.AddWithValue("@Ghekim", gonderenHekimId);

                                // Əlaqəni açmaq
                                connection.Open();

                                // Proseduru icra etmək
                                command.ExecuteNonQuery();
                            }
                        }
                        // TextBox-ları təmizləmək
                        txtGonderenHekimId.Text = "";
                        txtGonderenHekim.Text = "";

                        // btnGoster düyməsini basmaq
                        btnGoster.PerformClick();

                        // Məlumatları yenilədikdən sonra əvvəlki seçimi bərpa etmək
                        if (selectedRowIndex >= 0 && selectedRowIndex < adaddgrvDetalliSatis.Rows.Count)
                        {
                            adaddgrvDetalliSatis.ClearSelection();
                            adaddgrvDetalliSatis.Rows[selectedRowIndex].Selected = true;
                            adaddgrvDetalliSatis.FirstDisplayedScrollingRowIndex = selectedRowIndex;
                        }
                    }
                }
            }

        }

        private void btnExceleGonder_Click(object sender, EventArgs e)
        {
            // Excel application obyektini yaratmaq
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = false;

            // Yeni bir iş kitabı (workbook) yaratmaq
            Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);

            // İlk iş vərəqini (worksheet) seçmək
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

            // DataGridView başlıqlarını Excel-ə yazmaq
            for (int i = 0; i < addgrvDetalliSatis.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = adaddgrvDetalliSatis.Columns[i].HeaderText;
            }

            // DataGridView məlumatlarını Excel-ə yazmaq
            for (int i = 0; i < adaddgrvDetalliSatis.Rows.Count; i++)
            {
                for (int j = 0; j < adaddgrvDetalliSatis.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = adaddgrvDetalliSatis.Rows[i].Cells[j].Value?.ToString();

                    // WrapText-i deaktiv etmək
                    ((Excel.Range)worksheet.Cells[i + 2, j + 1]).WrapText = false;
                }
            }

            // Mebleg, Endirim və Cəm sütunları üçün toplamları hesablamaq
            int lastRow = adaddgrvDetalliSatis.Rows.Count + 1; // Sütun başlıqları ilə birlikdə
            decimal toplamMebleg = 0;
            decimal toplamEndirim = 0;
            decimal toplamCem = 0;

            foreach (DataGridViewRow row in adaddgrvDetalliSatis.Rows)
            {
                if (row.Cells["Mebleg"].Value != DBNull.Value)
                    toplamMebleg += Convert.ToDecimal(row.Cells["Mebleg"].Value);

                if (row.Cells["Endirim"].Value != DBNull.Value)
                    toplamEndirim += Convert.ToDecimal(row.Cells["Endirim"].Value);

                if (row.Cells["Cəm"].Value != DBNull.Value)
                    toplamCem += Convert.ToDecimal(row.Cells["Cəm"].Value);
            }

            // Toplamları Excel-ə yazmaq
            worksheet.Cells[lastRow + 1, adaddgrvDetalliSatis.Columns["Mebleg"].Index + 1] = toplamMebleg.ToString("N2");
            worksheet.Cells[lastRow + 1, adaddgrvDetalliSatis.Columns["Endirim"].Index + 1] = toplamEndirim.ToString("N2");
            worksheet.Cells[lastRow + 1, adaddgrvDetalliSatis.Columns["Cəm"].Index + 1] = toplamCem.ToString("N2");

            // WrapText-i toplamlar üçün də deaktiv etmək
            ((Excel.Range)worksheet.Cells[lastRow + 1, adaddgrvDetalliSatis.Columns["Mebleg"].Index + 1]).WrapText = false;
            ((Excel.Range)worksheet.Cells[lastRow + 1, adaddgrvDetalliSatis.Columns["Endirim"].Index + 1]).WrapText = false;
            ((Excel.Range)worksheet.Cells[lastRow + 1, adaddgrvDetalliSatis.Columns["Cəm"].Index + 1]).WrapText = false;

            // Excel iş kitabını göstərmək
            excelApp.Visible = true;

            // Excel obyektlərini təmizləmək
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        }

        private void adaddgrvDetalliSatis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKmHesabla_Click(object sender, EventArgs e)
        {
            // TextBox-da bir dəyər olub olmadığını yoxlayın
            if (!string.IsNullOrEmpty(txtSifarisNo.Text))
            {
                // SQL bağlantısını yarat
                using (SqlConnection conn = new SqlConnection(sqlbaglan.conString))
                {
                    try
                    {
                        conn.Open();

                        // Proseduru çağıran SqlCommand yaradın
                        using (SqlCommand cmd = new SqlCommand("SP_KM_Yeniden_Hesabla_Sifaris", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Parametri əlavə edin
                            cmd.Parameters.AddWithValue("@Sifarisno", Convert.ToInt32(txtSifarisNo.Text));

                            // Proseduru işə sal
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Prosedur müvəffəqiyyətlə yerinə yetirildi!");
                    }
                    catch (Exception ex)
                    {
                        // Xətanı göstər
                        MessageBox.Show("Xəta baş verdi: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfən Sifariş nömrəsini daxil edin.");
            }
        }

        private void cmbSahe_Enter(object sender, EventArgs e)
        {
                        string query = "SELECT Name FROM Services WHERE tip = @tip and cat = ''  and status = 2";
            SqlConnection connection = new SqlConnection(sqlbaglan.conString);
            {
                SqlCommand command = new SqlCommand(query, connection);
                // Adding a parameter for the txtSaheId value
                command.Parameters.AddWithValue("@tip", txtSaheId.Text);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                List<string> names = new List<string>();

                while (reader.Read())
                {
                    names.Add(reader["Name"].ToString());
                }

                reader.Close();
                cmbServiceCat.Items.Clear();
                cmbServiceCat.Items.AddRange(names.ToArray());
            }
        }
    }
}

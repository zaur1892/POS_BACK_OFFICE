using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_BACK_OFFICE
{
    public partial class frmAddDoctor : Form
    {
        public frmAddDoctor()
        {
            InitializeComponent();
        }
        private mssqlBaglanti sqlbaglan = new mssqlBaglanti();
        private void frmAddDoctor_Load(object sender, EventArgs e)
        {
            // Veritabanı bağlantısını aç
            using (SqlConnection conn = new SqlConnection(this.sqlbaglan.conString))
            {
                conn.Open();

                // cmbVezife'yi doldurmak için SQL sorgusu
                using (SqlCommand cmdVezife = new SqlCommand("SELECT name FROM PositionTypes WHERE status = 2", conn))
                {
                    using (SqlDataReader reader = cmdVezife.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbVezife.Items.Add(reader["name"].ToString());
                        }
                    }
                }

                // cmbXestexana'yı doldurmak için SQL sorgusu
                using (SqlCommand cmdXestexana = new SqlCommand("SELECT ID, Name FROM Hospitals WHERE status = 2", conn))
                {
                    using (SqlDataReader reader = cmdXestexana.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbXestexana.Items.Add(new KeyValuePair<int, string>((int)reader["ID"], reader["Name"].ToString()));
                        }
                    }
                }
            }

            // Varsayılan olarak ilk öğeyi seç (eğer varsa)
            if (cmbVezife.Items.Count > 0)
            {
                cmbVezife.SelectedIndex = 0;
            }
            if (cmbXestexana.Items.Count > 0)
            {
                cmbXestexana.SelectedIndex = 0;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Tüm kontrollerin dolu olup olmadığını kontrol et
            if (!ValidateForm())
            {
                return; // Eğer kontrollerden biri boşsa, kaydetme işlemi durdurulur.
            }

            // Textbox'lardan ve combobox'tan gelen değerleri al
            string adSoyad = txtHekimAdSoyad.Text;
            string telefon = txtTelefon.Text;
            DateTime dogumTarixi;

            // Tarihi düzgün formatta çeviremezsek bir hata mesajı gösterebiliriz
            if (!DateTime.TryParse(dtpDogumTarixi.Text, out dogumTarixi))
            {
                MessageBox.Show("Doğum tarixini düzgün daxil edin.");
                return;
            }

            string vezife = cmbVezife.SelectedItem?.ToString(); // comboboxdan seçilmiş değer
            string username = txtUsername.Text;
            string unvan = txtUnvan.Text;

            // Seçilen xestexana'nın ID'sini al
            int xestexanaID = ((KeyValuePair<int, string>)cmbXestexana.SelectedItem).Key;

            // Veritabanı bağlantısını aç
            using (SqlConnection conn = new SqlConnection(this.sqlbaglan.conString))
            {
                conn.Open();

                // Saklı yordamı çağır
                using (SqlCommand cmd = new SqlCommand("SP_AddNewDoctor", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parametreleri ekle
                    cmd.Parameters.AddWithValue("@AdSoyad", adSoyad);
                    cmd.Parameters.AddWithValue("@Telefon", telefon);
                    cmd.Parameters.AddWithValue("@DogumTarixi", dogumTarixi);
                    cmd.Parameters.AddWithValue("@Vezife", vezife);
                    cmd.Parameters.AddWithValue("@Unvan", unvan);
                    cmd.Parameters.AddWithValue("@xestexana", xestexanaID);

                    // Saklı yordamı çalıştır
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Doktor başarıyla eklendi!");
            // Tüm TextBox ve ComboBox'ları temizle
            ClearForm();
        }

        private bool ValidateForm()
        {
            // Her kontrolü kontrol et ve boş olan varsa mesaj göster
            if (string.IsNullOrEmpty(txtHekimAdSoyad.Text))
            {
                MessageBox.Show("Həkim adı daxil edilməyib. Zəhmət olmasa adı daxil edin.");
                txtHekimAdSoyad.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtTelefon.Text))
            {
                MessageBox.Show("Telefon nömrəsi daxil edilməyib. Zəhmət olmasa telefon nömrəsini daxil edin.");
                txtTelefon.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(dtpDogumTarixi.Text))
            {
                MessageBox.Show("Doğum tarixi daxil edilməyib. Zəhmət olmasa doğum tarixini daxil edin.");
                dtpDogumTarixi.Focus();
                return false;
            }

            //if (string.IsNullOrEmpty(txtUsername.Text))
            //{
            //    MessageBox.Show("İstifadəçi adı daxil edilməyib. Zəhmət olmasa istifadəçi adını daxil edin.");
            //    txtUsername.Focus();
            //    return false;
            //}

            if (string.IsNullOrEmpty(txtUnvan.Text))
            {
                MessageBox.Show("Ünvan daxil edilməyib. Zəhmət olmasa ünvanı daxil edin.");
                txtUnvan.Focus();
                return false;
            }

            if (cmbVezife.SelectedIndex == -1)
            {
                MessageBox.Show("Vəzifə seçilməyib. Zəhmət olmasa vəzifəni seçin.");
                cmbVezife.Focus();
                return false;
            }

            if (cmbXestexana.SelectedIndex == -1)
            {
                MessageBox.Show("Xəstəxana seçilməyib. Zəhmət olmasa xəstəxananı seçin.");
                cmbXestexana.Focus();
                return false;
            }

            // Eğer tüm kontroller doluysa, true döndür
            return true;
        }


        private void ClearForm()
        {
            // Tüm TextBox kontrollerini temizle
            txtHekimAdSoyad.Text = string.Empty;
            txtTelefon.Text = string.Empty;
            dtpDogumTarixi.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtUnvan.Text = string.Empty;

            // Tüm ComboBox'ları sıfırla
            cmbVezife.SelectedIndex = -1;
            cmbXestexana.SelectedIndex = -1;
        }

    }
}

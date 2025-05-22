using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Globalization;

namespace POS_BACK_OFFICE
{
    public partial class frmHekimFaizlerininTeyini : Form
    {
        public frmHekimFaizlerininTeyini()
        {
            InitializeComponent();
        }
        private mssqlBaglanti sqlbaglan = new mssqlBaglanti();

        private void txtHekim_TextChanged(object sender, EventArgs e)
        {
            // Axtarış üçün açar sözü əldə edin
            string textToSearch = txtHekim.Text.ToLowerInvariant();

            // Azərbaycan dilinə uyğun hərfləri əvəz edin
            textToSearch = textToSearch
                .Replace("ı", "i")
                .Replace("İ", "i")
                .Replace("I", "i");

            // ListBox-u gizlət
            lstHekim.Visible = false;

            if (string.IsNullOrEmpty(textToSearch))
                return; // Əgər açar söz boşdursa, ListBox-u gizli saxlayın

            // SQL sorğusu
            string query = "SELECT Adsoyad FROM SenderDoctor WHERE LOWER(Adsoyad) LIKE @Adsoyad";
            List<string> results = new List<string>();

            // Verilənlər bazasına qoşulmaq və sorğunu yerinə yetirmək
            using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametri əlavə etmək
                    command.Parameters.AddWithValue("@Adsoyad", "%" + textToSearch + "%");

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
            lstHekim.Items.Clear(); // Əlavə etmədən əvvəl təmizləməyi unutmayın
            lstHekim.Items.AddRange(results.ToArray());
            lstHekim.Visible = true; // ListBox-u yenidən görünən edin
        }



        private void lstHekim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHekim.SelectedItem != null)
            {
                // Seçilmiş adı alırıq
                string selectedName = lstHekim.SelectedItem.ToString();

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
                                txtHekimId.Text = reader["id"].ToString();
                                txtHekim.Text = reader["Adsoyad"].ToString();
                            }
                        }
                    }


                }

                // ListBox-u gizlədirik
                lstHekim.Visible = false;
            }
        }


        private void cmbSahe_Enter(object sender, EventArgs e)
        {
            // txtHekimId boşdursa, istifadəçiyə xəbərdarlıq mesajı göstərin və funksiyanı bitirin
            if (string.IsNullOrEmpty(txtHekimId.Text))
            {
                MessageBox.Show("Zəhmət olmasa birinci həkim seçin.", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Əgər txtHekimId boş deyilsə, məlumatları çəkin və cmbSahe-ni yeniləyin
            string query = "SELECT Name FROM ServiceGroup WHERE status = 2";
            using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<string> names = new List<string>();

                        while (reader.Read())
                        {
                            names.Add(reader["Name"].ToString());
                        }

                        cmbSahe.Items.Clear();
                        cmbSahe.Items.AddRange(names.ToArray());
                    }
                }
            }
        }


        private void cmbSahe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // SQL bağlantısını qururuq
            using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
            {
                // İlk SQL sorğusu: ServiceGroup tablosundan ID alınması
                string queryFill = "SELECT ID FROM ServiceGroup WHERE name = @name";
                using (SqlCommand commandFill = new SqlCommand(queryFill, connection))
                {
                    connection.Open();
                    commandFill.Parameters.AddWithValue("@name", cmbSahe.Text);

                    // Sorğunu yerinə yetirmək və nəticələri oxumaq
                    using (SqlDataReader readerFill = commandFill.ExecuteReader())
                    {
                        if (readerFill.Read()) // Məlumat varsa, TextBox-u doldur
                        {
                            txtSaheId.Text = readerFill["ID"].ToString();
                        }
                        else
                        {
                            // Məlumat yoxdursa, TextBox-ları boşalt
                            txtSaheId.Text = string.Empty;
                        }
                    }
                }

                // İkinci SQL sorğusu: FN_GetHekimSaheFaizleri fonksiyonundan gelen verilerin alınması
                string hekimFaizQuery = "SELECT * FROM FN_GetHekimSaheFaizleri(@HekimId, @SaheId)";
                using (SqlCommand faizCommand = new SqlCommand(hekimFaizQuery, connection))
                {
                    // Parametri əlavə etmək
                    faizCommand.Parameters.AddWithValue("@HekimId", txtHekimId.Text);
                    faizCommand.Parameters.AddWithValue("@SaheId", txtSaheId.Text);

                    // Sorğunu yerinə yetirmək və nəticələri oxumaq
                    using (SqlDataReader faizReader = faizCommand.ExecuteReader())
                    {
                        if (faizReader.Read()) // Fonksiyondan gelen verileri textboxlara doldur
                        {
                            txtSaheFaizId.Text = faizReader["ID"].ToString();
                            txtSaheGonderisFaiz.Text = faizReader["GonderisFaiz"].ToString();
                            txtSaheGonderisPul.Text = faizReader["GonderisMebleg"].ToString();
                            txtSaheMuayineFaiz.Text = faizReader["MuayineFaiz"].ToString();
                            txtSaheMuayinePul.Text = faizReader["MuayineMebleg"].ToString();
                            txtSaheEdv.Text = faizReader["EDV"].ToString();
                        }
                        else
                        {
                            // Məlumat yoxdursa, bütün TextBox-ları boşalt
                            txtSaheFaizId.Text = string.Empty;
                            txtSaheGonderisFaiz.Text = string.Empty;
                            txtSaheGonderisPul.Text = string.Empty;
                            txtSaheMuayineFaiz.Text = string.Empty;
                            txtSaheMuayinePul.Text = string.Empty;
                            txtSaheEdv.Text = string.Empty;
                        }
                    }
                }

                connection.Close();
            }
        }

        private void txtXidmetNovu_TextChanged(object sender, EventArgs e)
        {
            // Axtarış üçün açar sözü əldə edin
            string textToSearch = txtXidmetNovu.Text.ToLower();

            // ListBox-u gizlət
            lstXidmetNovu.Visible = false;

            // SQL sorğusu
            string query = "SELECT Name FROM Services WHERE tip = @tip and cat = '' and status = 2";

            if (!string.IsNullOrEmpty(textToSearch.Trim()))
            {
                // Əgər açar söz boş deyilsə və sadəcə boşluqdan ibarət deyilsə
                query += " and name like @name";
            }

            List<string> results = new List<string>();

            // Verilənlər bazasına qoşulmaq və sorğunu yerinə yetirmək
            using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametri əlavə etmək
                    command.Parameters.AddWithValue("@tip", txtSaheId.Text);

                    if (!string.IsNullOrEmpty(textToSearch.Trim()))
                    {
                        // Əgər açar söz boş deyilsə və sadəcə boşluqdan ibarət deyilsə
                        command.Parameters.AddWithValue("@name", "%" + textToSearch + "%");
                    }

                    // Əlaqəni açmaq
                    connection.Open();

                    // Sorğunu yerinə yetirmək və nəticələri oxumaq
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(reader["name"].ToString());
                        }
                    }
                }
            }

            // Əgər heç bir nəticə tapılmayıbsa, ListBox-u gizli saxlayın
            if (results.Count == 0)
                return;

            // ListBox-u yeniləyin və görünən edin
            lstXidmetNovu.Items.Clear(); // Əlavə etmədən əvvəl təmizləməyi unutmayın
            lstXidmetNovu.Items.AddRange(results.ToArray());
            lstXidmetNovu.Visible = true; // ListBox-u yenidən görünən edin
        }

        private void lstXidmetNovu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstXidmetNovu.SelectedItem != null)
            {
                // Seçilmiş adı alırıq
                string selectedName = lstXidmetNovu.SelectedItem.ToString();

                // SQL bağlantısını qururuq
                using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
                {
                    // SQL sorğusu, parametr ilə
                    string query = "Select id,name From Services WHERE name = @name";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametri əlavə etmək
                        command.Parameters.AddWithValue("@name", selectedName);

                        // Əlaqəni açmaq
                        connection.Open();

                        // Sorğunu yerinə yetirmək və nəticələri oxumaq
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // ID-ni və Name-i alırıq
                                txtXidmetNovuId.Text = reader["id"].ToString();
                                txtXidmetNovu.Text = reader["name"].ToString();
                            }
                        }
                    }
                }

                // ListBox-u gizlədirik
                lstXidmetNovu.Visible = false;
                //DataGridE XIDMETLERI GETIRME METODUNU CAGIRMAQ
                LoadDataToGrid();
                LoadXidmetNovuHekimFaizDetails();
            }
        }


        private void LoadXidmetNovuHekimFaizDetails()
        {
            string hekimFaizQuery = "SELECT * FROM FN_GetHekimXidmetNovuFaizleri(@HekimId, @XidmetNovuId)";

            using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
            {
                using (SqlCommand faizCommand = new SqlCommand(hekimFaizQuery, connection))
                {
                    // Parametreleri ekliyoruz
                    faizCommand.Parameters.AddWithValue("@HekimId", txtHekimId.Text);
                    faizCommand.Parameters.AddWithValue("@XidmetNovuId", txtXidmetNovuId.Text);

                    connection.Open();

                    // Sorguyu çalıştırıyoruz ve sonuçları okuyup TextBox'lara dolduruyoruz
                    using (SqlDataReader faizReader = faizCommand.ExecuteReader())
                    {
                        if (faizReader.Read()) // Fonksiyondan gelen verileri TextBox'lara doldur
                        {
                            txtXnFaizId.Text = faizReader["ID"].ToString();
                            txtXnGonderisFaiz.Text = faizReader["GonderisFaiz"].ToString();
                            txtXnGonderisPul.Text = faizReader["GonderisMebleg"].ToString();
                            txtXnMuayineFaiz.Text = faizReader["MuayineFaiz"].ToString();
                            txtXnMuayinePul.Text = faizReader["MuayineMebleg"].ToString();
                            txtXnEdv.Text = faizReader["EDV"].ToString();
                        }
                        else
                        {
                            // Məlumat yoxdursa, bütün TextBox-ları boşalt
                            txtXnFaizId.Text = string.Empty;
                            txtXnGonderisFaiz.Text = string.Empty;
                            txtXnGonderisPul.Text = string.Empty;
                            txtXnMuayineFaiz.Text = string.Empty;
                            txtXnMuayinePul.Text = string.Empty;
                            txtXnEdv.Text = string.Empty;
                        }
                    }
                }
            }
        }

        //DataGridE XIDMETLERI GETIRME METODU
        private void LoadDataToGrid()
        {
            // SQL bağlantısı
            using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
            {
                // SQL sorğusu
                string query = "SELECT * FROM dbo.FN_GetHekimXidmetFaizleri(@SUB, @Hekim) ORDER BY XidmetId;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametri əlavə etmək
                    command.Parameters.AddWithValue("@SUB", txtXidmetNovuId.Text + "%");
                    command.Parameters.AddWithValue("@Hekim", txtHekimId.Text);

                    // SqlDataAdapter istifadə edərək məlumatları doldurun
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    // Bağlantını açın və məlumatları doldurun
                    connection.Open();
                    adapter.Fill(dataTable);

                    // DataGridView-ə məlumatları bağlayın
                    dgrvHekimFaizTeyini.DataSource = dataTable;
                }
            }
        }

        private void dgrvHekimFaizTeyini_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgrvHekimFaizTeyini.CurrentRow != null)
            {
                SqlConnection connection = new SqlConnection(this.sqlbaglan.conString);
                connection.Open();
                DataGridViewRow dgvrow = dgrvHekimFaizTeyini.CurrentRow;
                SqlCommand sqlcmd = new SqlCommand("SP_AddEditHekimXidmetFaizleri", connection);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                if (dgvrow.Cells["ID"].Value == DBNull.Value)
                    sqlcmd.Parameters.AddWithValue("@ID", 0);
                else
                    sqlcmd.Parameters.AddWithValue("@ID", Convert.ToInt32(dgvrow.Cells["ID"].Value));

                sqlcmd.Parameters.AddWithValue("@Xidmet", dgvrow.Cells["XidmetId"].Value == DBNull.Value ? "" : dgvrow.Cells["XidmetId"].Value.ToString());
                sqlcmd.Parameters.AddWithValue("@XususiQiymet", dgvrow.Cells["XususiQiymet"].Value == DBNull.Value ? "" : dgvrow.Cells["XususiQiymet"].Value.ToString());
                sqlcmd.Parameters.AddWithValue("@GonderisFaiz", dgvrow.Cells["GonderisFaiz"].Value == DBNull.Value ? "" : dgvrow.Cells["GonderisFaiz"].Value.ToString());
                sqlcmd.Parameters.AddWithValue("@GonderisMebleg", dgvrow.Cells["GonderisMebleg"].Value == DBNull.Value ? "" : dgvrow.Cells["GonderisMebleg"].Value.ToString());
                sqlcmd.Parameters.AddWithValue("@MuayineFaiz", dgvrow.Cells["MuayineFaiz"].Value == DBNull.Value ? "" : dgvrow.Cells["MuayineFaiz"].Value.ToString());
                sqlcmd.Parameters.AddWithValue("@MuayineMebleg", dgvrow.Cells["MuayineMebleg"].Value == DBNull.Value ? "" : dgvrow.Cells["MuayineMebleg"].Value.ToString());
                sqlcmd.Parameters.AddWithValue("@XususiFaiz", dgvrow.Cells["XususiFaiz"].Value == DBNull.Value ? "" : dgvrow.Cells["XususiFaiz"].Value.ToString());
                sqlcmd.Parameters.AddWithValue("@XususiMebleg", dgvrow.Cells["XususiMebleg"].Value == DBNull.Value ? "" : dgvrow.Cells["XususiMebleg"].Value.ToString());
                sqlcmd.Parameters.AddWithValue("@EDV", dgvrow.Cells["EDV"].Value == DBNull.Value ? "" : dgvrow.Cells["EDV"].Value.ToString());
                sqlcmd.Parameters.AddWithValue("@DgrvHekim", dgvrow.Cells["Hekim"].Value == DBNull.Value ? "" : dgvrow.Cells["Hekim"].Value.ToString());
                sqlcmd.Parameters.AddWithValue("@Hekim", txtHekimId.Text);

                sqlcmd.ExecuteNonQuery();
                LoadDataToGrid();
            }

            
        }


        private void btnSaheFaizSave_Click(object sender, EventArgs e)
        {
            // SQL bağlantısını qururuq
            using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
            {
                // Proseduru çağırmaq üçün SQL komutunu hazırlayırıq
                using (SqlCommand command = new SqlCommand("SP_AddEditHekimSaheFaizleri", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parametrləri əlavə etmək
                    command.Parameters.AddWithValue("@ID", string.IsNullOrEmpty(txtSaheFaizId.Text) ? (object)DBNull.Value : txtSaheFaizId.Text);
                    command.Parameters.AddWithValue("@Xidmet", txtSaheId.Text);  // Xidmet ID'si (Service ID)
                    command.Parameters.AddWithValue("@GonderisFaiz", txtSaheGonderisFaiz.Text);
                    command.Parameters.AddWithValue("@GonderisMebleg", txtSaheGonderisPul.Text);
                    command.Parameters.AddWithValue("@MuayineFaiz", txtSaheMuayineFaiz.Text);
                    command.Parameters.AddWithValue("@MuayineMebleg", txtSaheMuayinePul.Text);
                    command.Parameters.AddWithValue("@EDV", txtSaheEdv.Text);
                    command.Parameters.AddWithValue("@Hekim", txtHekimId.Text); // Hekim ID'si

                    // Əlaqəni açmaq
                    connection.Open();

                    // Proseduru yerinə yetirmək
                    command.ExecuteNonQuery();

                    // Əlaqəni bağlamaq
                    connection.Close();
                }
            }

            // Prosedurdan sonra istifadəçiyə məlumat vermək üçün bir mesaj göstərə bilərsiniz
            MessageBox.Show("Məlumat uğurla saxlanıldı", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXidmetNovuFaizSave_Click(object sender, EventArgs e)
        {
            // SQL bağlantısını qururuq
            using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
            {
                // Proseduru çağırmaq üçün SQL komutunu hazırlayırıq
                using (SqlCommand command = new SqlCommand("SP_AddEditHekimXnFaizleri", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parametrləri əlavə etmək
                    command.Parameters.AddWithValue("@ID", string.IsNullOrEmpty(txtXnFaizId.Text) ? (object)DBNull.Value : txtXnFaizId.Text);
                    command.Parameters.AddWithValue("@Xidmet", txtXidmetNovuId.Text);  // Xidmet ID'si (Service ID)
                    command.Parameters.AddWithValue("@GonderisFaiz", txtXnGonderisFaiz.Text);
                    command.Parameters.AddWithValue("@GonderisMebleg", txtXnGonderisPul.Text);
                    command.Parameters.AddWithValue("@MuayineFaiz", txtXnMuayineFaiz.Text);
                    command.Parameters.AddWithValue("@MuayineMebleg", txtXnMuayinePul.Text);
                    command.Parameters.AddWithValue("@EDV", txtXnEdv.Text);
                    command.Parameters.AddWithValue("@Hekim", txtHekimId.Text); // Hekim ID'si

                    // Əlaqəni açmaq
                    connection.Open();

                    // Proseduru yerinə yetirmək
                    command.ExecuteNonQuery();

                    // Əlaqəni bağlamaq
                    connection.Close();
                }
            }

            // Prosedurdan sonra istifadəçiyə məlumat vermək üçün bir mesaj göstərə bilərsiniz
            MessageBox.Show("Məlumat uğurla saxlanıldı", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

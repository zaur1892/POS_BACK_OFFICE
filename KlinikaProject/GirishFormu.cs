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
    public partial class GirishFormu : Form
    {
        public static string SendUserID = "";
        public static string SendUsername = "";

        public GirishFormu()
        {
            InitializeComponent();
        }

        private mssqlBaglanti sqlbaglan = new mssqlBaglanti();
        private void btnGirish_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(this.sqlbaglan.conString);
                connection.Open();

                string cmdText = "SELECT id FROM users WHERE name = @name AND PinCode = @Sifre";
                SqlParameter mySqlParameter1 = new SqlParameter("@name", this.txtUsername.Text.Trim());
                SqlParameter mySqlParameter2 = new SqlParameter("@Sifre", this.txtPass.Text.Trim());

                SqlCommand selectCommand = new SqlCommand(cmdText, connection);
                selectCommand.Parameters.Add(mySqlParameter1);
                selectCommand.Parameters.Add(mySqlParameter2);

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read())
                {
                    int userId = reader.GetInt32(0); // Assuming the id column is the first column in the select statement
                    lblUserId.Text = userId.ToString();

                    SendUsername = txtUsername.Text;
                    SendUserID = lblUserId.Text;
                    new AnaForm().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sehv kredenşl Parolu sehv yazdiz");
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            //KILITLE ZAMANI LOCK OLMUSH FORM-LARI ACHMAQ
            List<Form> openForms = new List<Form>(System.Windows.Forms.Application.OpenForms.Cast<Form>());

            // Mevcut form dışındaki tüm açık formları devre dışı bırak
            foreach (Form form in openForms)
            {
                if (form != this)
                {
                    form.Enabled = true;
                }
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            // Əgər Enter düyməsinə basılıbsa
            if (e.KeyCode == Keys.Enter)
            {
                // Düğmeye fokus ver
                btnGirish.Focus();

                // Düğmeni klik etdirmək üçün aşağıdakı satırı istifadə edə bilərsiniz
                btnGirish.PerformClick();
            }
        }
    }
}

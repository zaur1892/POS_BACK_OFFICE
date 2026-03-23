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
    public partial class frmSearchEngine : Form
    {
        public static string SendUserID = "";
        public static string SendUsername = "";
        public frmSearchEngine()
        {
            InitializeComponent();
        }
        private mssqlBaglanti sqlbaglan = new mssqlBaglanti();
        private void frmSearchEngine_Load(object sender, EventArgs e)
        {

            lblUserName.Text = GirishFormu.SendUsername.ToString();
            lblUserId.Text = GirishFormu.SendUserID.ToString();
            dtpDocStartDate.Value = DateTime.Today;
            dtpDocEndDate.Value = DateTime.Today;
            LoadSearchResults();

            DataGridViewTheme myTheme = new DataGridViewTheme();


            // Sənəd detalları üçün tətbiq et
            ThemeManager.ApplyTheme(adDgrvSearchEngineDetail, myTheme);
        }


        private void dtpDocStartDate_ValueChanged(object sender, EventArgs e)
        {
            LoadSearchResults();
        }
        private void dtpDocEndDate_ValueChanged(object sender, EventArgs e)
        {
            LoadSearchResults();
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            string textToSearch = txtCustomer.Text.Trim();
            bool getAll = string.IsNullOrEmpty(textToSearch);

            string query = "SELECT ACC_NAME FROM ACCOUNTS WHERE (@ACC_NAME IS NULL OR ACC_NAME LIKE @ACC_NAME)";
            var parameters = new[]
            {
        new SqlParameter("@ACC_NAME", getAll ? DBNull.Value : (object)(textToSearch + "%"))
    };

            LoadListBoxBySearch(query, parameters, lstCustomer, "ACC_NAME");
            LoadSearchResults();
        }

        private void txtDocType_TextChanged(object sender, EventArgs e)
        {
            string textToSearch = txtDocType.Text.Trim();
            bool getAll = string.IsNullOrEmpty(textToSearch);

            string query = "SELECT TYPE_NAME FROM DOCUMENT_TYPE WHERE STATUS = 1 AND (@TYPE_NAME IS NULL OR TYPE_NAME LIKE @TYPE_NAME)";
            var parameters = new[]
            {
        new SqlParameter("@TYPE_NAME", getAll ? DBNull.Value : (object)(textToSearch + "%"))
    };

            LoadListBoxBySearch(query, parameters, lstDocType, "TYPE_NAME");
            LoadSearchResults();
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            string textToSearch = txtStock.Text.Trim();
            bool getAll = string.IsNullOrEmpty(textToSearch);

            string query = "SELECT NAME FROM STOCK WHERE (@NAME IS NULL OR NAME LIKE @NAME)";
            var parameters = new[]
            {
        new SqlParameter("@StockId", txtStock.Text),
        new SqlParameter("@NAME", getAll ? DBNull.Value : (object)(textToSearch + "%"))
    };

            LoadListBoxBySearch(query, parameters, lstStock, "NAME");
            LoadSearchResults();
        }
        private void txtDocNo_TextChanged(object sender, EventArgs e)
        {
            LoadSearchResults();
        }

        private void LoadListBoxBySearch(string query, SqlParameter[] parameters, ListBox listBox, string columnToRead)
        {
            List<string> results = new List<string>();
            listBox.Visible = false;

            using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddRange(parameters);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(reader[columnToRead].ToString());
                    }
                }
            }

            if (results.Count > 0)
            {
                listBox.Items.Clear();
                listBox.Items.AddRange(results.ToArray());
                listBox.Visible = true;
            }
        }



        private void LoadSearchResults()
        {
            int? accountId = null;
            int? stockId = null;
            int? docTypeId = null;

            if (int.TryParse(txtCustomerID.Text, out int accId))
                accountId = accId;

            if (int.TryParse(txtStockId.Text, out int stkId))
                stockId = stkId;

            if (int.TryParse(txtDocType.Text, out int docId))
                docTypeId = docId;



            string docNo = txtDocNo.Text.Trim();
            DateTime startDate = dtpDocStartDate.Value;
            DateTime endDate = dtpDocEndDate.Value;

            using (SqlConnection conn = new SqlConnection(this.sqlbaglan.conString))
            using (SqlCommand cmd = new SqlCommand("SP_GetGeneralSearchEngineDetails", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DOC_NO", string.IsNullOrEmpty(docNo) ? DBNull.Value : (object)docNo);
                cmd.Parameters.AddWithValue("@DOCUMENT_TYPE", docTypeId.HasValue ? (object)docTypeId.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@STOCK_ID", stockId.HasValue ? (object)stockId.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@ACCOUNT_ID", accountId.HasValue ? (object)accountId.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                SqlParameter returnValue = new SqlParameter("@RC", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(returnValue);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                try
                {
                    conn.Open();
                    da.Fill(dt);
                    adDgrvSearchEngineDetail.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Axtarış zamanı xəta baş verdi: " + ex.Message);
                }
            }

        }


        private void lstCustomer_Click(object sender, EventArgs e)
        {
            if (lstCustomer.SelectedItem != null)
            {
                string selectedTamadi = lstCustomer.SelectedItem.ToString();

                using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
                {
                    string query = "SELECT ID, ACC_NAME FROM ACCOUNTS WHERE ACC_NAME = @NAME";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NAME", selectedTamadi);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCustomerID.Text = reader["ID"].ToString();
                                txtCustomer.Text = reader["ACC_NAME"].ToString();
                            }
                        }
                    }
                }

                // ✨ ListBox-u təmizlə və gizlət
                lstCustomer.Items.Clear();
                lstCustomer.Visible = false;
            }
        }
        private void txtCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtCustomer.Clear();
                lstCustomer.Items.Clear();
                lstCustomer.Visible = false;
                txtCustomerID.Clear();
            }
        }


        private void lstStock_Click(object sender, EventArgs e)
        {
            if (lstStock.SelectedItem != null)
            {
                string selectedTamadi = lstStock.SelectedItem.ToString();

                using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
                {
                    string query = "SELECT ID, NAME FROM STOCK WHERE STATUS = 1 AND NAME = @NAME";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NAME", selectedTamadi);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtStockId.Text = reader["ID"].ToString();
                                txtStock.Text = reader["NAME"].ToString();
                            }
                        }
                    }
                }

                // ✨ ListBox-u təmizlə və gizlət
                lstStock.Items.Clear();
                lstStock.Visible = false;
            }

        }
        private void txtStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtStock.Clear();
                lstStock.Items.Clear();
                lstStock.Visible = false;
                txtStockId.Clear();
            }
        }


        private void lstDocType_Click(object sender, EventArgs e)
        {
            if (lstDocType.SelectedItem != null)
            {
                string selectedDocType = lstDocType.SelectedItem.ToString();

                using (SqlConnection connection = new SqlConnection(sqlbaglan.conString))
                {
                    string query = "SELECT ID, TYPE_NAME FROM DOCUMENT_TYPE WHERE STATUS = 1 AND TYPE_NAME = @NAME";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NAME", selectedDocType);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtDocTypeId.Text = reader["ID"].ToString();
                                txtDocType.Text = reader["TYPE_NAME"].ToString();
                            }
                        }
                    }
                }

                // ✨ ListBox-u təmizlə və gizlət
                lstDocType.Items.Clear();
                lstDocType.Visible = false;
            }
        }
        private void txtDocType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtDocType.Clear();
                lstDocType.Items.Clear();
                lstDocType.Visible = false;
                txtDocTypeId.Clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadSearchResults();
        }
    }
}





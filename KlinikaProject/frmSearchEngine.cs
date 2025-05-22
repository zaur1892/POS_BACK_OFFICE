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

         

            foreach (DataGridViewColumn column in adDgrvDocumentDetail.Columns)
            {
                column.ReadOnly = true;
            }
            dtpDocStartDate.Value = DateTime.Today;
            dtpDocEndDate.Value = DateTime.Today;

            DataGridViewTheme myTheme = new DataGridViewTheme();


            // Sənəd detalları üçün tətbiq et
            ThemeManager.ApplyTheme(adDgrvDocumentDetail, myTheme);

            LoadStockDetails(0);

        }



        private void createNewDoc_Click(object sender, EventArgs e)
        {
            // Open frmQeydiyyat form
            frmSale qeydiyyatForm = new frmSale();
            qeydiyyatForm.Show();
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
                //decimal discountAmount = Convert.ToDecimal(row.Cells["DISCOUNT_AMOUNT"].Value ?? 0);
                decimal totalAmountPerRow = Convert.ToDecimal(row.Cells["TOTAL_AMOUNT"].Value ?? 0);

                // Cəmləri hesablayırıq
                totalQuantity += quantity;
                //totalDiscount += discountAmount;
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





        private void LoadStockDetails(int doc_no)
        {
            DateTime startDate = dtpDocStartDate.Value.Date;
            DateTime endDate = dtpDocEndDate.Value.Date;
            using (SqlConnection connection = new SqlConnection(this.sqlbaglan.conString))
            {
                using (SqlCommand cmd = new SqlCommand("[SP_GetStockDetailByDocNo]", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", doc_no);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    adDgrvDocumentDetail.DataSource = dt;  // Detalları adDgrvDocumentDetail DataGridView-də göstəririk
                }
            }
        }
}
}
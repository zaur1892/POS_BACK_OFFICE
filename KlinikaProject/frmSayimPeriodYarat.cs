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
    public partial class frmSayimPeriodYarat : Form
    {
        public frmSayimPeriodYarat()
        {
            InitializeComponent();
        }
        private mssqlBaglanti sqlbaglan = new mssqlBaglanti();

        private void frmSayimPeriodYarat_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(this.sqlbaglan.conString);
                connection.Open();
                string query = "SELECT DATEADD(DAY,1,MAX(PERIOD_END)) FROM INVENTORY_COUNT_PERIOD WHERE CLOSED = 1 AND STATUS = 1";
                SqlCommand command = new SqlCommand(query, connection);

                object result = command.ExecuteScalar();
                dtpSayimStart.Value = result != null && result != DBNull.Value
                    ? Convert.ToDateTime(result)
                    : new DateTime(2000, 1, 1);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message);
                dtpSayimStart.Value = new DateTime(2000, 1, 1); // Hata zamanı da default tarix
            }

            dtpSayimEnd.Value = DateTime.Today;



        }

        private void btnCreateSayimStoklarla_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Açıq periodun olub-olmadığını yoxla
                using (SqlConnection connection = new SqlConnection(this.sqlbaglan.conString))
                {
                    connection.Open();

                    string checkOpenPeriodQuery = @"
SELECT COUNT(*)
FROM INVENTORY_COUNT_PERIOD
WHERE CLOSED = 0 AND STATUS = 1";

                    using (SqlCommand checkCommand = new SqlCommand(checkOpenPeriodQuery, connection))
                    {
                        int openPeriodCount = (int)checkCommand.ExecuteScalar();

                        if (openPeriodCount > 0)
                        {
                            MessageBox.Show("Hal-hazırda açıq bir sayım periodu mövcuddur. Yeni period əlavə edilə bilməz.");
                            return;
                        }
                    }
                }

                // 2. Tarixlərin üst-üstə düşüb-düşmədiyini yoxla
                using (SqlConnection connection1 = new SqlConnection(this.sqlbaglan.conString))
                {
                    connection1.Open();

                    string checkOverlapQuery = @"
SELECT COUNT(*)
FROM INVENTORY_COUNT_PERIOD
WHERE 
    (PERIOD_START <= @NewPeriodEnd AND PERIOD_END >= @NewPeriodStart)";

                    using (SqlCommand checkCommand = new SqlCommand(checkOverlapQuery, connection1))
                    {
                        checkCommand.Parameters.AddWithValue("@NewPeriodStart", dtpSayimStart.Value);
                        checkCommand.Parameters.AddWithValue("@NewPeriodEnd", dtpSayimEnd.Value);

                        int overlapCount = (int)checkCommand.ExecuteScalar();

                        if (overlapCount > 0)
                        {
                            MessageBox.Show("Bu tarixlərdə artıq bir dövr mövcuddur. Yeni dövr əlavə edilə bilməz.");
                            return;
                        }
                    }
                }

                // 3. INVENTORY_COUNT_PERIOD cədvəlinə məlumat əlavə et
                int newPeriodId;
                using (SqlConnection connection2 = new SqlConnection(this.sqlbaglan.conString))
                {
                    connection2.Open();

                    string insertPeriodQuery = @"
INSERT INTO INVENTORY_COUNT_PERIOD (PERIOD_START, PERIOD_END, CLOSED, STATUS)
OUTPUT INSERTED.ID
VALUES (@PeriodStart, @PeriodEnd, 0, 1)";

                    using (SqlCommand periodCommand = new SqlCommand(insertPeriodQuery, connection2))
                    {
                        periodCommand.Parameters.AddWithValue("@PeriodStart", dtpSayimStart.Value);
                        periodCommand.Parameters.AddWithValue("@PeriodEnd", dtpSayimEnd.Value);

                        // Yeni ID-ni əldə et
                        newPeriodId = (int)periodCommand.ExecuteScalar();
                    }
                }

                // 4. Stokları əldə etmək üçün proseduru çağır
                List<(int DepoId, int InventoryItemId, decimal Opening_Balance, decimal Giris, decimal Cixis, decimal Satis, decimal Qaliq, decimal OrtaQiymet)> stockData = new List<(int, int, decimal, decimal, decimal, decimal, decimal, decimal)>();
                using (SqlConnection connection3 = new SqlConnection(this.sqlbaglan.conString))
                {
                    connection3.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetInventoryData", connection3))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@StartDate", dtpSayimStart.Value);
                        command.Parameters.AddWithValue("@EndDate", dtpSayimEnd.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                stockData.Add((
                                    reader.GetInt32(reader.GetOrdinal("DepoId")),
                                    reader.GetInt32(reader.GetOrdinal("InventoryItem_Id")),
                                    reader.GetDecimal(reader.GetOrdinal("Opening_Balance")),
                                    reader.GetDecimal(reader.GetOrdinal("Giris")),
                                    reader.GetDecimal(reader.GetOrdinal("Cixis")),
                                    reader.GetDecimal(reader.GetOrdinal("Satis")),
                                    reader.GetDecimal(reader.GetOrdinal("Qaliq")),
                                    reader.GetDecimal(reader.GetOrdinal("OrtaQiymet")) // Add the new column
                                ));
                            }
                        }
                    }
                }

                // 5. INVENTORY_COUNT cədvəlinə məlumat əlavə et
                using (SqlConnection connection4 = new SqlConnection(this.sqlbaglan.conString))
                {
                    connection4.Open();

                    string insertCountQuery = @"
INSERT INTO INVENTORY_COUNT (PERIOD_START, PERIOD_END, INVENTORY_PERIOD_ID, STOCK_ID, DEPO_ID, Opening_Balance,GIRIS, CIXIS, SATIS, QALIQ, ORTA_QIYMET, COUNT_AMOUNT, STATUS)
VALUES (@PeriodStart, @PeriodEnd, @InventoryPeriodId, @StockId, @DepoId, @Opening_Balance,@Giris, @Cixis, @Satis, @Qaliq, @OrtaQiymet, 0, 1)";

                    using (SqlCommand countCommand = new SqlCommand(insertCountQuery, connection4))
                    {
                        foreach (var stock in stockData)
                        {
                            countCommand.Parameters.Clear();
                            countCommand.Parameters.AddWithValue("@PeriodStart", dtpSayimStart.Value);
                            countCommand.Parameters.AddWithValue("@PeriodEnd", dtpSayimEnd.Value);
                            countCommand.Parameters.AddWithValue("@InventoryPeriodId", newPeriodId);
                            countCommand.Parameters.AddWithValue("@StockId", stock.InventoryItemId);
                            countCommand.Parameters.AddWithValue("@DepoId", stock.DepoId);
                            countCommand.Parameters.AddWithValue("@Opening_Balance", stock.Opening_Balance);
                            countCommand.Parameters.AddWithValue("@Giris", stock.Giris);
                            countCommand.Parameters.AddWithValue("@Cixis", stock.Cixis);
                            countCommand.Parameters.AddWithValue("@Satis", stock.Satis);
                            countCommand.Parameters.AddWithValue("@Qaliq", stock.Qaliq);
                            countCommand.Parameters.AddWithValue("@OrtaQiymet", stock.OrtaQiymet); // Add the new column value
                            countCommand.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Sayım periodu və stoklar uğurla əlavə edildi.");
                this.Hide();
                frmStokSayim sayim = new frmStokSayim();
                sayim.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message);
            }
        }







    }
}

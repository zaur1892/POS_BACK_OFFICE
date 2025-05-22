using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using Excel = Microsoft.Office.Interop.Excel;
using System.Globalization;


namespace POS_BACK_OFFICE
{
    public partial class frmStokSayim : System.Windows.Forms.Form
    {
        private ContextMenuStrip contextMenuOdemeler;
        private ToolStripMenuItem menuItemOdemeniSil;
        private ToolStripMenuItem menuItemOdemeTipiniDeyis;

        public frmStokSayim()
        {
            InitializeComponent();
        }
        private mssqlBaglanti sqlbaglan = new mssqlBaglanti();

        private void frmStokSayim_Load(object sender, EventArgs e)
        {
            lblUserName.Text = GirishFormu.SendUsername.ToString();
            lblUserId.Text = GirishFormu.SendUserID.ToString();
            GetSayimPeriod();
            LoadStokSayimData();



        }

        public void GetSayimPeriod()
        {
            SqlConnection connection = new SqlConnection(this.sqlbaglan.conString);

            try
            {
                connection.Open();

                string query = @"
            SELECT PERIOD_START, PERIOD_END 
            FROM INVENTORY_COUNT_PERIOD 
            WHERE CLOSED = 0 AND STATUS = 1";

                string queryClosedPeriod = @"
            SELECT TOP 1 PERIOD_START, PERIOD_END 
            FROM INVENTORY_COUNT_PERIOD 
            WHERE CLOSED = 1 AND STATUS = 1 ORDER BY ID DESC";

                DateTime? periodStart = null;
                DateTime? periodEnd = null;
                bool isOpenPeriod = false;

                // Açıq periodu oxuyuruq
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        periodStart = (DateTime)reader["PERIOD_START"];
                        periodEnd = (DateTime)reader["PERIOD_END"];
                        isOpenPeriod = true;
                    }
                }

                // Əgər açıq period yoxdursa, bağlanmış periodu oxuyuruq
                if (!isOpenPeriod)
                {
                    using (SqlCommand commandClosedPeriod = new SqlCommand(queryClosedPeriod, connection))
                    using (SqlDataReader readerClosedPeriod = commandClosedPeriod.ExecuteReader())
                    {
                        if (readerClosedPeriod.Read())
                        {
                            periodStart = (DateTime)readerClosedPeriod["PERIOD_START"];
                            periodEnd = (DateTime)readerClosedPeriod["PERIOD_END"];
                        }
                    }
                }

                // Dəyərləri təyin edirik
                dtpSayimStart.Value = periodStart ?? DateTime.Now;
                dtpSayimEnd.Value = periodEnd ?? DateTime.Now;

                // DataGridView və Label vəziyyəti
                if (isOpenPeriod)
                {
                    addgrvStokSayim.ReadOnly = false;
                    addgrvStokSayim.DefaultCellStyle.BackColor = SystemColors.Window; // Normal rəng
                    lblSayimStatus.Text = "Açıq Period";
                    lblSayimStatus.ForeColor = Color.Green; // Yaşıl rəng
                }
                else
                {
                    addgrvStokSayim.ReadOnly = true;
                    addgrvStokSayim.DefaultCellStyle.BackColor = SystemColors.ControlDark; // Boz rəng
                    lblSayimStatus.Text = "Bağlı Period";
                    lblSayimStatus.ForeColor = Color.Red; // Qırmızı rəng
                    btnSayimYenile.Enabled = false;
                    btnInventoryConfirm.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadStokSayimData()
        {
            // SQL bağlantısı yaradılır
            using (SqlConnection connection = new SqlConnection(this.sqlbaglan.conString))
            {
                try
                {
                    connection.Open();

                    // FN_SAYIMLAR funksiyasını çağıran SQL sorğusu
                    string query = @"
                SELECT * 
                FROM FN_SAYIMLAR(@PERIOD_START, @PERIOD_END)
                WHERE StockName LIKE @StockName AND GroupCode LIKE @GroupCode";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametrləri əlavə edin
                        command.Parameters.Add(new SqlParameter("@PERIOD_START", SqlDbType.Date) { Value = dtpSayimStart.Value.Date });
                        command.Parameters.Add(new SqlParameter("@PERIOD_END", SqlDbType.Date) { Value = dtpSayimEnd.Value.Date });
                        command.Parameters.Add(new SqlParameter("@StockName", SqlDbType.NVarChar) { Value = txtStockName.Text + "%" });
                        command.Parameters.Add(new SqlParameter("@GroupCode", SqlDbType.NVarChar) { Value = txtStockGroup.Text + "%" });

                        // Məlumatları oxumaq üçün SqlDataAdapter istifadə edilir
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();

                            // Məlumatları doldurun
                            adapter.Fill(table);

                            // DataGridView-i məlumatlarla doldurun
                            addgrvStokSayim.AutoGenerateColumns = false; // Avtomatik sütun yaratmağı dayandırırıq
                            addgrvStokSayim.DataSource = table;

                            // Gizlədiləcək sütunlar
                            addgrvStokSayim.Columns["INVENTORY_PERIOD_ID"].Visible = false;
                            addgrvStokSayim.Columns["DEPO_ID"].Visible = false;

                            // Hər bir sətri yoxlayaraq FERQ-i hesablayın
                            foreach (DataGridViewRow row in addgrvStokSayim.Rows)
                            {
                                if (row.Cells["QALIQ"]?.Value != null && row.Cells["QALIQ"].Value != DBNull.Value &&
                                    row.Cells["Say"]?.Value != null && row.Cells["Say"].Value != DBNull.Value &&
                                    row.Cells["Semi_Product_Count"]?.Value != null && row.Cells["Semi_Product_Count"].Value != DBNull.Value)
                                {
                                    // Lazımi dəyərləri oxuyun
                                    decimal qaliq = Convert.ToDecimal(row.Cells["QALIQ"].Value);
                                    decimal sayim = Convert.ToDecimal(row.Cells["Say"].Value);
                                    decimal pfSayim = Convert.ToDecimal(row.Cells["Semi_Product_Count"].Value);

                                    // FERQ və TOTAL_PRODUCT_COUNT hesablanır
                                    decimal totalProductCount = sayim + pfSayim;
                                    decimal ferq = totalProductCount - qaliq;

                                    // FERQ və TOTAL_PRODUCT_COUNT hüceyrələrinə dəyərləri yazın
                                    row.Cells["Total_Product_Count"].Value = totalProductCount;
                                    row.Cells["FERQ"].Value = ferq;

                                    // FERQ rəngini təyin edin
                                    row.Cells["FERQ"].Style.ForeColor = ferq > 0 ? Color.Green :
                                                                        ferq < 0 ? Color.Red :
                                                                        Color.Black;
                                }
                                else
                                {
                                    // Əgər məlumatlar natamamdırsa, FERQ-i 0 edin və rəngi qara edin
                                    row.Cells["FERQ"].Value = 0;
                                    row.Cells["FERQ"].Style.ForeColor = Color.Black;
                                }
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


        private void ReleaseObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the object: " + ex.Message);
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnAddSayimPeriod_Click(object sender, EventArgs e)
        {
            frmSayimPeriodYarat fspy = new frmSayimPeriodYarat();
            fspy.ShowDialog();
        }

        private void frmStokSayim_Activated(object sender, EventArgs e)
        {
            GetSayimPeriod();
          //  LoadStokSayimData();
        }

        private void btnSayimYenile_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Açıq periodu tap
                int openPeriodId;
                DateTime periodStart, periodEnd;
                using (SqlConnection connection = new SqlConnection(this.sqlbaglan.conString))
                {
                    connection.Open();

                    string getOpenPeriodQuery = @"
SELECT ID, PERIOD_START, PERIOD_END
FROM INVENTORY_COUNT_PERIOD
WHERE CLOSED = 0 AND STATUS = 1";

                    using (SqlCommand command = new SqlCommand(getOpenPeriodQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                openPeriodId = reader.GetInt32(reader.GetOrdinal("ID"));
                                periodStart = reader.GetDateTime(reader.GetOrdinal("PERIOD_START"));
                                periodEnd = reader.GetDateTime(reader.GetOrdinal("PERIOD_END"));
                            }
                            else
                            {
                                MessageBox.Show("Hal-hazırda açıq bir sayım periodu yoxdur.");
                                return;
                            }
                        }
                    }
                }

                // 2. Proseduru çağır və yeni məlumatları əldə et
                List<(int DepoId, int InventoryItemId, decimal Giris, decimal Cixis, decimal Satis, decimal Qaliq, decimal OrtaQiymet)> stockData = new List<(int, int, decimal, decimal, decimal, decimal, decimal)>();
                using (SqlConnection connection = new SqlConnection(this.sqlbaglan.conString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetInventoryData", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@StartDate", periodStart);
                        command.Parameters.AddWithValue("@EndDate", periodEnd);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                stockData.Add((
                                    reader.GetInt32(reader.GetOrdinal("DepoId")),
                                    reader.GetInt32(reader.GetOrdinal("StockId")),
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

                // 3. Dəyərləri INVENTORY_COUNT cədvəlində yenilə
                using (SqlConnection connection = new SqlConnection(this.sqlbaglan.conString))
                {
                    connection.Open();

                    foreach (var stock in stockData)
                    {
                        // Mövcud dəyərləri yenilə və ya əlavə et
                        string updateOrInsertQuery = @"
IF EXISTS (
    SELECT 1
    FROM INVENTORY_COUNT
    WHERE INVENTORY_PERIOD_ID = @InventoryPeriodId AND STOCK_ID = @StockId AND DEPO_ID = @DepoId
)
BEGIN
    UPDATE INVENTORY_COUNT
    SET GIRIS = @Giris, CIXIS = @Cixis, SATIS = @Satis, QALIQ = @Qaliq, ORTA_QIYMET = @OrtaQiymet, STATUS = 1
    WHERE INVENTORY_PERIOD_ID = @InventoryPeriodId AND STOCK_ID = @StockId AND DEPO_ID = @DepoId
END
ELSE
BEGIN
    INSERT INTO INVENTORY_COUNT (PERIOD_START, PERIOD_END, INVENTORY_PERIOD_ID, STOCK_ID, DEPO_ID, GIRIS, CIXIS, SATIS, QALIQ, ORTA_QIYMET, COUNT_AMOUNT, STATUS)
    VALUES (@PeriodStart, @PeriodEnd, @InventoryPeriodId, @StockId, @DepoId, @Giris, @Cixis, @Satis, @Qaliq, @OrtaQiymet, 0, 1)
END";

                        using (SqlCommand command = new SqlCommand(updateOrInsertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@PeriodStart", periodStart);
                            command.Parameters.AddWithValue("@PeriodEnd", periodEnd);
                            command.Parameters.AddWithValue("@InventoryPeriodId", openPeriodId);
                            command.Parameters.AddWithValue("@StockId", stock.InventoryItemId);
                            command.Parameters.AddWithValue("@DepoId", stock.DepoId);
                            command.Parameters.AddWithValue("@Giris", stock.Giris);
                            command.Parameters.AddWithValue("@Cixis", stock.Cixis);
                            command.Parameters.AddWithValue("@Satis", stock.Satis);
                            command.Parameters.AddWithValue("@Qaliq", stock.Qaliq);
                            command.Parameters.AddWithValue("@OrtaQiymet", stock.OrtaQiymet); // Add the new column value
                            command.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Sayım yenidən hesablandı və stok məlumatları yeniləndi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message);
            }
        }

        private void btnInventoryConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Aktiv hüceyrədən INVENTORY_PERIOD_ID-ni al
                if (addgrvStokSayim.CurrentCell != null)
                {
                    int inventoryPeriodId = Convert.ToInt32(addgrvStokSayim.CurrentCell.OwningRow.Cells["INVENTORY_PERIOD_ID"].Value);

                    // Əminlik sorğusu
                    DialogResult result = MessageBox.Show(
                        "Bu sayım periodunu bağlamaq istədiyinizə əminsinizmi?",
                        "Təsdiqləmə",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        // 2. INVENTORY_COUNT_PERIOD cədvəlindəki müvafiq ID-ni tap və CLOSED sütununu 1-ə yenilə
                        using (SqlConnection connection = new SqlConnection(this.sqlbaglan.conString))
                        {
                            connection.Open();

                            string updateQuery = @"
UPDATE INVENTORY_COUNT_PERIOD
SET CLOSED = 1
WHERE ID = @InventoryPeriodId";

                            using (SqlCommand command = new SqlCommand(updateQuery, connection))
                            {
                                command.Parameters.AddWithValue("@InventoryPeriodId", inventoryPeriodId);

                                // 3. Query-i icra et
                                command.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Sayım periodu uğurla bağlandı.");
                    }
                }
                else
                {
                    MessageBox.Show("Zəhmət olmasa, bir sayım periodu seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message);
            }
        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Yalnızca rəqəm, vergül və geri silmə (backspace) düymələrinə icazə verilir
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Vergül yalnız bir dəfə daxil edilsin (kəsr hissəsi üçün)
            TextBox txtBox = sender as TextBox;
            if (e.KeyChar == ',' && txtBox != null && txtBox.Text.Contains(","))
            {
                e.Handled = true; // Əgər artıq vergül varsa, yenisini əlavə etməyə icazə verilməsin
            }
        }

        private void addgrvStokSayim_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var columns = new string[] { "ORTA_QIYMET", "COUNT_AMOUNT", "Semi_Product_Count", "Total_Product_Count" };

            foreach (var columnName in columns)
            {
                if (addgrvStokSayim.Columns.Contains(columnName))
                {
                    if (addgrvStokSayim.CurrentCell.OwningColumn.Name == columnName)
                    {
                        TextBox txtBox = e.Control as TextBox;
                        if (txtBox != null)
                        {
                            txtBox.KeyPress -= new KeyPressEventHandler(txtBox_KeyPress);
                            txtBox.KeyPress += new KeyPressEventHandler(txtBox_KeyPress);
                        }
                    }
                }
            }
        }

        private void addgrvStokSayim_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // "Sayım" və ya "Yarı Məhsul Sayı" sütunlarında dəyişiklik edildikdə işləsin
                if (e.RowIndex >= 0 &&
                    (e.ColumnIndex == addgrvStokSayim.Columns["Say"].Index ||
                     e.ColumnIndex == addgrvStokSayim.Columns["Semi_Product_Count"].Index))
                {
                    DataGridViewRow dgvRow = addgrvStokSayim.Rows[e.RowIndex];

                    // SQL Bağlantısı
                    using (SqlConnection connection = new SqlConnection(this.sqlbaglan.conString))
                    {
                        connection.Open();

                        string updateQuery = @"
UPDATE INVENTORY_COUNT
SET COUNT_AMOUNT = @CountAmount,
    SEMI_PRODUCT_COUNT = @SemiProductCount,
    FERQ = @Ferq,
    TOTAL_PRODUCT_COUNT = @TotalProductCount
WHERE STOCK_ID = @StockId AND DEPO_ID = @DepoId AND INVENTORY_PERIOD_ID = @InventoryPeriodId";

                        using (SqlCommand sqlcmd = new SqlCommand(updateQuery, connection))
                        {
                            // Lazımi dəyərləri oxu (Null yoxlanışları ilə)
                            decimal countAmount = dgvRow.Cells["Say"]?.Value == DBNull.Value || dgvRow.Cells["Say"]?.Value == null
                                ? 0
                                : Convert.ToDecimal(dgvRow.Cells["Say"].Value);

                            decimal semiProductCount = dgvRow.Cells["Semi_Product_Count"]?.Value == DBNull.Value || dgvRow.Cells["Semi_Product_Count"]?.Value == null
                                ? 0
                                : Convert.ToDecimal(dgvRow.Cells["Semi_Product_Count"].Value);

                            decimal qaliq = dgvRow.Cells["QALIQ"]?.Value == DBNull.Value || dgvRow.Cells["QALIQ"]?.Value == null
                                ? 0
                                : Convert.ToDecimal(dgvRow.Cells["QALIQ"].Value);

                            // Yekun Sayımı hesabla
                            decimal totalProductCount = countAmount + semiProductCount;

                            // Ferqi hesabla
                            decimal ferq = totalProductCount - qaliq;

                            // Yekun Sayımı DataGridView-də göstər

                            dgvRow.Cells["Total_Product_Count"].Value = totalProductCount;

                            // Ferqi DataGridView-də göstər
                            dgvRow.Cells["FERQ"].Value = ferq;

                            // Parametrləri təyin et
                            sqlcmd.Parameters.AddWithValue("@CountAmount", countAmount);
                            sqlcmd.Parameters.AddWithValue("@SemiProductCount", semiProductCount);
                            sqlcmd.Parameters.AddWithValue("@Ferq", ferq);
                            sqlcmd.Parameters.AddWithValue("@TotalProductCount", totalProductCount);
                            sqlcmd.Parameters.AddWithValue("@StockId", dgvRow.Cells["STOCK_ID"]?.Value == null
                                ? 0
                                : Convert.ToInt32(dgvRow.Cells["STOCK_ID"].Value));
                            sqlcmd.Parameters.AddWithValue("@DepoId", dgvRow.Cells["DEPO_ID"]?.Value == null
                                ? 0
                                : Convert.ToInt32(dgvRow.Cells["DEPO_ID"].Value));
                            sqlcmd.Parameters.AddWithValue("@InventoryPeriodId", dgvRow.Cells["INVENTORY_PERIOD_ID"]?.Value == null
                                ? 0
                                : Convert.ToInt32(dgvRow.Cells["INVENTORY_PERIOD_ID"].Value));

                            // Sorğunu icra et
                            sqlcmd.ExecuteNonQuery();
                        }
                    }

                    // Ferq rəngini dəyiş
                    if (dgvRow.Cells["FERQ"].Value != null)
                    {
                        decimal ferqValue = Convert.ToDecimal(dgvRow.Cells["FERQ"].Value);
                        if (ferqValue < 0)
                        {
                            dgvRow.Cells["FERQ"].Style.ForeColor = Color.Red;
                        }
                        else if (ferqValue > 0)
                        {
                            dgvRow.Cells["FERQ"].Style.ForeColor = Color.Green;
                        }
                        else
                        {
                            dgvRow.Cells["FERQ"].Style.ForeColor = Color.Black;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExceleGonder_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
        private void ExportToExcel()
        {
            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                // Create a new Excel application
                excelApp = new Excel.Application
                {
                    Visible = true
                };

                // Create a new workbook
                workbook = excelApp.Workbooks.Add();

                // Create a new worksheet
                worksheet = (Excel.Worksheet)workbook.Sheets[1];

                // Add column headers to Excel worksheet
                int excelColumnIndex = 1;
                for (int j = 0; j < addgrvStokSayim.Columns.Count; j++)
                {
                    if (addgrvStokSayim.Columns[j].Visible)
                    {
                        worksheet.Cells[1, excelColumnIndex] = addgrvStokSayim.Columns[j].HeaderText;
                        excelColumnIndex++;
                    }
                }

                // Copy dgrvKassayaOdemeler content to worksheet
                decimal totalOdenenMebleg = 0;
                for (int i = 0; i < addgrvStokSayim.Rows.Count; i++)
                {
                    excelColumnIndex = 1;
                    for (int j = 0; j < addgrvStokSayim.Columns.Count; j++)
                    {
                        if (addgrvStokSayim.Columns[j].Visible)
                        {
                            if (addgrvStokSayim.Rows[i].Cells[j].Value != null)
                            {
                                worksheet.Cells[i + 2, excelColumnIndex] = addgrvStokSayim.Rows[i].Cells[j].Value.ToString();

                                // If the column is OdenenMebleg, sum the values
                                if (addgrvStokSayim.Columns[j].HeaderText == "OdenenMebleg")
                                {
                                    if (decimal.TryParse(addgrvStokSayim.Rows[i].Cells[j].Value.ToString(), out decimal value))
                                    {
                                        totalOdenenMebleg += value;
                                    }
                                }
                            }
                            excelColumnIndex++;
                        }
                    }
                }


                // Define Excel table range
                Excel.Range range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[addgrvStokSayim.Rows.Count + 1, excelColumnIndex - 1]];

                // Add Excel table
                Excel.ListObject excelTable = worksheet.ListObjects.Add(Excel.XlListObjectSourceType.xlSrcRange, range, Type.Missing, Excel.XlYesNoGuess.xlYes, Type.Missing);
                excelTable.Name = "MyExcelTable";

                // Autofit columns
                range.Columns.AutoFit();
            }
            catch (COMException ex) when ((uint)ex.ErrorCode == 0x800AC472)
            {
                // Handle the COMException by retrying the operation
                MessageBox.Show("Excel is busy. Please try again.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                ReleaseObject(worksheet);
                if (workbook != null)
                {
                    try
                    {
                        //workbook.Close(false);
                        //ReleaseObject(workbook);
                    }
                    catch (COMException ex) when ((uint)ex.ErrorCode == 0x800AC472)
                    {
                        MessageBox.Show("Excel is busy while closing the workbook. Please close it manually.");
                    }
                }
                if (excelApp != null)
                {
                    try
                    {
                        excelApp.Quit();
                        ReleaseObject(excelApp);
                    }
                    catch (COMException ex) when ((uint)ex.ErrorCode == 0x800AC472)
                    {
                        MessageBox.Show("Excel is busy while quitting the application. Please quit it manually.");
                    }
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void btnFiltirliSayimiGetir_Click(object sender, EventArgs e)
        {
            LoadStokSayimData();
        }
    }
}

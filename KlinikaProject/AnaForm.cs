using Microsoft.Vbe.Interop;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace POS_BACK_OFFICE
{
    public partial class AnaForm : Form
    {
        private MenuStrip menuStrip;
        private ToolStripMenuItem documentsMenu;
        private ToolStripMenuItem documentListMenu;
        private ToolStripMenuItem documentTypesMenu;
        private ToolStripMenuItem warehouseMenu;
        private ToolStripMenuItem warehousesMenu;
        private ToolStripMenuItem stockCountMenu;
        private ToolStripMenuItem liveStockBalanceMenu;
        private ToolStripMenuItem transferMenu;
        private ToolStripMenuItem newTransferMenu;
        private ToolStripMenuItem stockMenu;
        private ToolStripMenuItem stockMovementsMenu;
        private ToolStripMenuItem reportsMenu;
        private ToolStripMenuItem searchEngineMenu;
        //private ToolStripMenuItem stockCountReportMenu;

        public AnaForm()
        {
            InitializeComponent();
            CreateMenuStrip();
        }

        private mssqlBaglanti sqlbaglan = new mssqlBaglanti();

        private void CreateMenuStrip()
        {
            menuStrip = new MenuStrip
            {
                Renderer = new CustomMenuRenderer(), // Custom stil
                BackColor = Color.WhiteSmoke,
                ForeColor = Color.Black,
                Padding = new Padding(300, 6, 10, 6),
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };

            Font menuFont = new Font("Segoe UI", 14, FontStyle.Bold);

            // Mədaxil menyusu
            documentsMenu = new ToolStripMenuItem("Mədaxil") { Font = menuFont, Padding = new Padding(8, 6, 8, 6) };
            documentsMenu.Visible = false;
            documentListMenu = new ToolStripMenuItem("Mədaxil Siyahısı") { Font = menuFont };
            documentTypesMenu = new ToolStripMenuItem("Sənəd Növləri") { Font = menuFont };
            documentsMenu.DropDownItems.Add(documentListMenu);
            documentsMenu.DropDownItems.Add(documentTypesMenu);

            // Depo menyusu
            warehouseMenu = new ToolStripMenuItem("Depo (Склад)") { Font = menuFont, Padding = new Padding(8, 6, 8, 6) };
            warehouseMenu.Visible = false;
            warehousesMenu = new ToolStripMenuItem("Depolar") { Font = menuFont };
            stockCountMenu = new ToolStripMenuItem("Depo Sayımları") { Font = menuFont };
            liveStockBalanceMenu = new ToolStripMenuItem("Canlı Depo Qalıqları") { Font = menuFont };

            warehouseMenu.DropDownItems.Add(warehousesMenu);
            warehouseMenu.DropDownItems.Add(stockCountMenu);
            warehouseMenu.DropDownItems.Add(liveStockBalanceMenu);

            // Satış menyusu
            transferMenu = new ToolStripMenuItem("Satış") { Font = menuFont, Padding = new Padding(8, 6, 8, 6) };
            transferMenu.Visible = false;
            newTransferMenu = new ToolStripMenuItem("Satış Sənədləri") { Font = menuFont };
            transferMenu.DropDownItems.Add(newTransferMenu);

            // Stok menyusu
            stockMenu = new ToolStripMenuItem("Stok") { Font = menuFont, Padding = new Padding(8, 6, 8, 6) };
            stockMenu.Visible = false;
            stockMovementsMenu = new ToolStripMenuItem("Stok Hərəkətləri") { Font = menuFont };
            stockMenu.DropDownItems.Add(stockMovementsMenu);

            // Hesabatlar menyusu
            reportsMenu = new ToolStripMenuItem("Hesabatlar") { Font = menuFont, Padding = new Padding(60, 6, 8, 6) };
            //stockCountReportMenu = new ToolStripMenuItem("Depo Sayım Hesabatı") { Font = menuFont };

            stockCountMenu = new ToolStripMenuItem("Depo Sayımları") { Font = menuFont };
            liveStockBalanceMenu = new ToolStripMenuItem("Canlı Depo Qalıqları") { Font = menuFont };

            stockMovementsMenu = new ToolStripMenuItem("Stok Hərəkətləri") { Font = menuFont };
            searchEngineMenu = new ToolStripMenuItem("Axtarış Sistemi") { Font = menuFont };

            reportsMenu.DropDownItems.Add(stockMovementsMenu);

            reportsMenu.DropDownItems.Add(stockCountMenu);
            reportsMenu.DropDownItems.Add(liveStockBalanceMenu);
            reportsMenu.DropDownItems.Add(searchEngineMenu);


            //reportsMenu.DropDownItems.Add(stockCountReportMenu);

            // Əlavə et menyuları
            menuStrip.Items.Add(documentsMenu);
            menuStrip.Items.Add(transferMenu);
            menuStrip.Items.Add(warehouseMenu);
            menuStrip.Items.Add(stockMenu);
            menuStrip.Items.Add(reportsMenu);

            this.Controls.Add(menuStrip);
            this.MainMenuStrip = menuStrip;


            // Event handlerlər
            documentListMenu.Click += DocumentListMenu_Click;
            documentTypesMenu.Click += DocumentTypesMenu_Click;

            stockCountMenu.Click += StockCountMenu_Click;
            liveStockBalanceMenu.Click += LiveStockBalanceMenu_Click;

            newTransferMenu.Click += NewTransferMenu_Click;

            stockMovementsMenu.Click += StockMovementsMenu_Click;

            searchEngineMenu.Click += SearchEngineMenu_Click;

            //stockCountReportMenu.Click += StockCountReportMenu_Click;
        }

        // Event handler funksiyaları
        private void DocumentListMenu_Click(object sender, EventArgs e)
        {
            frmDocumentList docListForm = new frmDocumentList();
            docListForm.Show();
        }

        private void DocumentTypesMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sənəd Növləri açıldı");
        }
        private void StockCountMenu_Click(object sender, EventArgs e)
        {
            frmStokSayim stockCountForm = new frmStokSayim();
            stockCountForm.Show();
        }

        private void LiveStockBalanceMenu_Click(object sender, EventArgs e)
        {
            frmLiveStockBalance liveStockForm = new frmLiveStockBalance();
            liveStockForm.Show();
        }

        private void NewTransferMenu_Click(object sender, EventArgs e)
        {
            frmSaleList SatisListiKimi = new frmSaleList();
            SatisListiKimi.Show();
        }

        private void StockMovementsMenu_Click(object sender, EventArgs e)
        {
            frmStockMovements stockMovementsForm = new frmStockMovements();
            stockMovementsForm.Show();
        }

        private void StockCountReportMenu_Click(object sender, EventArgs e)
        {
            frmDetalliSatisAnaliz stockReportForm = new frmDetalliSatisAnaliz();
            stockReportForm.Show();
        }

        private void SearchEngineMenu_Click(object sender, EventArgs e)
        {
            frmSearchEngine searchEngineForm = new frmSearchEngine();
            searchEngineForm.Show();
        }










        private async void AnaForm_Load(object sender, EventArgs e)
        {

            lblUserName.Text = GirishFormu.SendUsername.ToString();
            lblUserId.Text = GirishFormu.SendUserID.ToString();


            //USERID-YE UYGUN AD SOYAD GETIRIRIK!
            SqlConnection connection = new SqlConnection(this.sqlbaglan.conString);
            connection.Open();

            string cmdText = "SELECT First_Name + ' ' + Last_Name as adsoyad FROM users WHERE id = @userId";
            SqlParameter mySqlParameter = new SqlParameter("@userId", lblUserId.Text.Trim());

            using (SqlCommand selectCommand = new SqlCommand(cmdText, connection))
            {
                selectCommand.Parameters.Add(mySqlParameter);

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read())
                {
                    string adsoyad = reader["adsoyad"].ToString();
                    lblAdSoyad.Text = adsoyad;
                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
            }

            connection.Close();

            // SqlConnection connection = new SqlConnection(this.sqlbaglan.conString);

            {
                connection.Open();

                // SQL sorgusu
                string sql = "SELECT Name FROM COMPANY_INFO";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Veriyi oku
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // İlk sıradaki veriyi al ve lblCompany etiketine yaz
                        lblCompany.Text = reader["Name"].ToString();
                    }
                    else
                    {
                        // Eğer veri yoksa veya okuma hatası oluşursa bir işlem yapabilirsiniz.
                        lblCompany.Text = "Veri bulunamadı";
                    }

                    reader.Close();
                }

                connection.Close();
            }
            // Form yüklənmə anında saatı göstərmək üçün Timer əlavə edək
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 saniyədə bir yenilə
            timer.Tick += Timer_Tick;
            timer.Start();
            await LoadData();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Timer qədər təkrarlanan zaman bu funksiya işlədilir
            lblCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private async Task LoadData()
        {
            lblUserName.Text = GirishFormu.SendUsername.ToString();
            // Tarixi və saatı göstərin
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            // Həftənin nömrəsini göstərin
            lblWeek.Text = "Neçənci həftə: " + GetWeekOfYear(DateTime.Now).ToString();

            // Məzənnəni yükləyin
            var exchangeRates = await GetExchangeRates();
            lblExchangeRates.Text = exchangeRates;

            // Aforizmi yükləyin
            // var quote = await GetQuote();
            // lblQuote.Text = quote;
        }

        private int GetWeekOfYear(DateTime date)
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            var calendar = culture.Calendar;
            var weekRule = culture.DateTimeFormat.CalendarWeekRule;
            var firstDayOfWeek = culture.DateTimeFormat.FirstDayOfWeek;
            return calendar.GetWeekOfYear(date, weekRule, firstDayOfWeek);
        }


        private async Task<string> GetExchangeRates()
        {
            string apiUrl = "https://api.exchangerate-api.com/v4/latest/AZN";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string json = await client.GetStringAsync(apiUrl);
                    JObject data = JObject.Parse(json);

                    // Get exchange rates
                    decimal usdRate = (decimal)data["rates"]["USD"];
                    decimal eurRate = (decimal)data["rates"]["EUR"];
                    decimal rubRate = (decimal)data["rates"]["RUB"];

                    // Construct the exchange rates string
                    string exchangeRates = $"1 USD = {1 / usdRate:N2} AZN, 1 EUR = {1 / eurRate:N2} AZN, 1 RUB = {1 / rubRate:N2} AZN";

                    return exchangeRates;
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine("HttpRequestException: " + ex.Message);
                    return "Error retrieving exchange rates";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    return "Error retrieving exchange rates";
                }
            }
        }



        private void btnLock_Click(object sender, EventArgs e)
        {
            // Application.OpenForms koleksiyonunu listeye kopyala
            List<Form> openForms = new List<Form>(System.Windows.Forms.Application.OpenForms.Cast<Form>());

            // Mevcut form dışındaki tüm açık formları devre dışı bırak
            foreach (Form form in openForms)
            {
                if (form != this)
                {
                    form.Enabled = false;
                }
            }

            // GirishFormu'nu oluştur ve göster
            GirishFormu girishFormu = new GirishFormu();
            girishFormu.Show();

            // Bu formu da devre dışı bırak (isteğe bağlı)
            this.Hide();
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmSetting fs = new frmSetting();
            fs.Show();
        }

        private void btnWarehouseIncForm_Click(object sender, EventArgs e)
        {
            frmDocumentList docListForm = new frmDocumentList();
            docListForm.Show();
        }

        private void btnSaleForm_Click(object sender, EventArgs e)
        {
            frmSaleList fsl = new frmSaleList();
            fsl.Show();
        }
    }
}

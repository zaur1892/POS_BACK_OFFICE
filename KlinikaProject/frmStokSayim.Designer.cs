using System;
using System.Windows.Forms;

namespace POS_BACK_OFFICE
{
    partial class frmStokSayim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            dtpSayimStart = new DateTimePicker();
            btnFiltirliSayimiGetir = new Button();
            btnExceleGonder = new Button();
            txtStockGroup = new TextBox();
            lblStockGroup = new Label();
            lblStockName = new Label();
            txtStockName = new TextBox();
            lblAdSoyad = new Label();
            lblAdSoyadCaption = new Label();
            lblUserId = new Label();
            lblIstifadechi = new Label();
            lblUserName = new Label();
            dtpSayimEnd = new DateTimePicker();
            lblSayimPeriodDates = new Label();
            btnAddSayimPeriod = new Button();
            lblSayimStatus = new Label();
            btnSayimYenile = new Button();
            btnInventoryConfirm = new Button();
            addgrvStokSayim = new Zuby.ADGV.AdvancedDataGridView();
            INVENTORY_PERIOD_ID = new DataGridViewTextBoxColumn();
            DEPO_ID = new DataGridViewTextBoxColumn();
            DEPO_AD = new DataGridViewTextBoxColumn();
            GroupCode = new DataGridViewTextBoxColumn();
            STOCK_ID = new DataGridViewTextBoxColumn();
            StockName = new DataGridViewTextBoxColumn();
            BaseUnit = new DataGridViewTextBoxColumn();
            ORTA_QIYMET = new DataGridViewTextBoxColumn();
            Opening_Balance = new DataGridViewTextBoxColumn();
            GIRIS = new DataGridViewTextBoxColumn();
            CIXIS = new DataGridViewTextBoxColumn();
            SATIS = new DataGridViewTextBoxColumn();
            QALIQ = new DataGridViewTextBoxColumn();
            Say = new DataGridViewTextBoxColumn();
            Semi_Product_Count = new DataGridViewTextBoxColumn();
            Total_Product_Count = new DataGridViewTextBoxColumn();
            FERQ = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)addgrvStokSayim).BeginInit();
            SuspendLayout();
            // 
            // dtpSayimStart
            // 
            dtpSayimStart.Enabled = false;
            dtpSayimStart.Format = DateTimePickerFormat.Short;
            dtpSayimStart.Location = new Point(436, 12);
            dtpSayimStart.Margin = new Padding(4, 3, 4, 3);
            dtpSayimStart.Name = "dtpSayimStart";
            dtpSayimStart.Size = new Size(117, 23);
            dtpSayimStart.TabIndex = 2;
            // 
            // btnFiltirliSayimiGetir
            // 
            btnFiltirliSayimiGetir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnFiltirliSayimiGetir.Location = new Point(167, 47);
            btnFiltirliSayimiGetir.Margin = new Padding(4, 3, 4, 3);
            btnFiltirliSayimiGetir.Name = "btnFiltirliSayimiGetir";
            btnFiltirliSayimiGetir.Size = new Size(64, 74);
            btnFiltirliSayimiGetir.TabIndex = 5;
            btnFiltirliSayimiGetir.Text = "OK";
            btnFiltirliSayimiGetir.UseVisualStyleBackColor = true;
            btnFiltirliSayimiGetir.Click += btnFiltirliSayimiGetir_Click;
            // 
            // btnExceleGonder
            // 
            btnExceleGonder.BackColor = Color.FromArgb(128, 255, 128);
            btnExceleGonder.FlatAppearance.BorderColor = Color.Red;
            btnExceleGonder.FlatAppearance.BorderSize = 10;
            btnExceleGonder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnExceleGonder.ForeColor = Color.Black;
            btnExceleGonder.Location = new Point(917, 67);
            btnExceleGonder.Margin = new Padding(4, 3, 4, 3);
            btnExceleGonder.Name = "btnExceleGonder";
            btnExceleGonder.Size = new Size(203, 30);
            btnExceleGonder.TabIndex = 11;
            btnExceleGonder.Text = "EXCEL (Xlsx Format)";
            btnExceleGonder.UseVisualStyleBackColor = false;
            btnExceleGonder.Click += btnExceleGonder_Click;
            // 
            // txtStockGroup
            // 
            txtStockGroup.Location = new Point(13, 98);
            txtStockGroup.Margin = new Padding(4, 3, 4, 3);
            txtStockGroup.Name = "txtStockGroup";
            txtStockGroup.Size = new Size(151, 23);
            txtStockGroup.TabIndex = 12;
            // 
            // lblStockGroup
            // 
            lblStockGroup.AutoSize = true;
            lblStockGroup.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblStockGroup.Location = new Point(13, 73);
            lblStockGroup.Margin = new Padding(4, 0, 4, 0);
            lblStockGroup.Name = "lblStockGroup";
            lblStockGroup.Size = new Size(97, 17);
            lblStockGroup.TabIndex = 13;
            lblStockGroup.Text = "STOK QRUPU :";
            // 
            // lblStockName
            // 
            lblStockName.AutoSize = true;
            lblStockName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblStockName.Location = new Point(13, 26);
            lblStockName.Margin = new Padding(4, 0, 4, 0);
            lblStockName.Name = "lblStockName";
            lblStockName.Size = new Size(76, 17);
            lblStockName.TabIndex = 15;
            lblStockName.Text = "STOK ADI :";
            // 
            // txtStockName
            // 
            txtStockName.Location = new Point(13, 47);
            txtStockName.Margin = new Padding(4, 3, 4, 3);
            txtStockName.Name = "txtStockName";
            txtStockName.Size = new Size(151, 23);
            txtStockName.TabIndex = 14;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAdSoyad.ForeColor = SystemColors.ButtonHighlight;
            lblAdSoyad.Location = new Point(441, 857);
            lblAdSoyad.Margin = new Padding(4, 0, 4, 0);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(118, 25);
            lblAdSoyad.TabIndex = 20;
            lblAdSoyad.Text = "Ad Familiya:";
            // 
            // lblAdSoyadCaption
            // 
            lblAdSoyadCaption.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAdSoyadCaption.AutoSize = true;
            lblAdSoyadCaption.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAdSoyadCaption.ForeColor = SystemColors.ButtonHighlight;
            lblAdSoyadCaption.Location = new Point(318, 857);
            lblAdSoyadCaption.Margin = new Padding(4, 0, 4, 0);
            lblAdSoyadCaption.Name = "lblAdSoyadCaption";
            lblAdSoyadCaption.Size = new Size(129, 25);
            lblAdSoyadCaption.TabIndex = 19;
            lblAdSoyadCaption.Text = "| Ad Familiya:";
            // 
            // lblUserId
            // 
            lblUserId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUserId.AutoSize = true;
            lblUserId.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUserId.ForeColor = SystemColors.ButtonHighlight;
            lblUserId.Location = new Point(211, 857);
            lblUserId.Margin = new Padding(4, 0, 4, 0);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(75, 25);
            lblUserId.TabIndex = 18;
            lblUserId.Text = "UserId:";
            // 
            // lblIstifadechi
            // 
            lblIstifadechi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblIstifadechi.AutoSize = true;
            lblIstifadechi.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblIstifadechi.ForeColor = SystemColors.ButtonHighlight;
            lblIstifadechi.Location = new Point(0, 857);
            lblIstifadechi.Margin = new Padding(4, 0, 4, 0);
            lblIstifadechi.Name = "lblIstifadechi";
            lblIstifadechi.Size = new Size(69, 25);
            lblIstifadechi.TabIndex = 17;
            lblIstifadechi.Text = "| User:";
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUserName.ForeColor = SystemColors.ButtonHighlight;
            lblUserName.Location = new Point(75, 857);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(106, 25);
            lblUserName.TabIndex = 16;
            lblUserName.Text = "Username:";
            // 
            // dtpSayimEnd
            // 
            dtpSayimEnd.Enabled = false;
            dtpSayimEnd.Format = DateTimePickerFormat.Short;
            dtpSayimEnd.Location = new Point(560, 12);
            dtpSayimEnd.Margin = new Padding(4, 3, 4, 3);
            dtpSayimEnd.Name = "dtpSayimEnd";
            dtpSayimEnd.Size = new Size(117, 23);
            dtpSayimEnd.TabIndex = 22;
            // 
            // lblSayimPeriodDates
            // 
            lblSayimPeriodDates.AutoSize = true;
            lblSayimPeriodDates.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblSayimPeriodDates.Location = new Point(258, 16);
            lblSayimPeriodDates.Margin = new Padding(4, 0, 4, 0);
            lblSayimPeriodDates.Name = "lblSayimPeriodDates";
            lblSayimPeriodDates.Size = new Size(172, 17);
            lblSayimPeriodDates.TabIndex = 23;
            lblSayimPeriodDates.Text = "Sayım Period Tarix Aralığı:";
            // 
            // btnAddSayimPeriod
            // 
            btnAddSayimPeriod.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAddSayimPeriod.Location = new Point(13, 0);
            btnAddSayimPeriod.Margin = new Padding(4, 3, 4, 3);
            btnAddSayimPeriod.Name = "btnAddSayimPeriod";
            btnAddSayimPeriod.Size = new Size(153, 23);
            btnAddSayimPeriod.TabIndex = 24;
            btnAddSayimPeriod.Text = "PERIOD ELAVE ET";
            btnAddSayimPeriod.UseVisualStyleBackColor = true;
            btnAddSayimPeriod.Click += btnAddSayimPeriod_Click;
            // 
            // lblSayimStatus
            // 
            lblSayimStatus.AutoSize = true;
            lblSayimStatus.Location = new Point(682, 18);
            lblSayimStatus.Margin = new Padding(4, 0, 4, 0);
            lblSayimStatus.Name = "lblSayimStatus";
            lblSayimStatus.Size = new Size(38, 15);
            lblSayimStatus.TabIndex = 25;
            lblSayimStatus.Text = "label2";
            // 
            // btnSayimYenile
            // 
            btnSayimYenile.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSayimYenile.Location = new Point(917, 12);
            btnSayimYenile.Margin = new Padding(4, 3, 4, 3);
            btnSayimYenile.Name = "btnSayimYenile";
            btnSayimYenile.Size = new Size(203, 42);
            btnSayimYenile.TabIndex = 26;
            btnSayimYenile.Text = "SAYIM YENİLE";
            btnSayimYenile.UseVisualStyleBackColor = true;
            btnSayimYenile.Click += btnSayimYenile_Click;
            // 
            // btnInventoryConfirm
            // 
            btnInventoryConfirm.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnInventoryConfirm.Location = new Point(1135, 12);
            btnInventoryConfirm.Margin = new Padding(4, 3, 4, 3);
            btnInventoryConfirm.Name = "btnInventoryConfirm";
            btnInventoryConfirm.Size = new Size(203, 42);
            btnInventoryConfirm.TabIndex = 27;
            btnInventoryConfirm.Text = "SAYIM TƏSDİQLƏ";
            btnInventoryConfirm.UseVisualStyleBackColor = true;
            btnInventoryConfirm.Click += btnInventoryConfirm_Click;
            // 
            // addgrvStokSayim
            // 
            addgrvStokSayim.AllowUserToAddRows = false;
            addgrvStokSayim.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            addgrvStokSayim.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            addgrvStokSayim.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addgrvStokSayim.BorderStyle = BorderStyle.Fixed3D;
            addgrvStokSayim.CausesValidation = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            addgrvStokSayim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            addgrvStokSayim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            addgrvStokSayim.Columns.AddRange(new DataGridViewColumn[] { INVENTORY_PERIOD_ID, DEPO_ID, DEPO_AD, GroupCode, STOCK_ID, StockName, BaseUnit, ORTA_QIYMET, Opening_Balance, GIRIS, CIXIS, SATIS, QALIQ, Say, Semi_Product_Count, Total_Product_Count, FERQ });
            addgrvStokSayim.EnableHeadersVisualStyles = false;
            addgrvStokSayim.FilterAndSortEnabled = true;
            addgrvStokSayim.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            addgrvStokSayim.GridColor = SystemColors.InactiveBorder;
            addgrvStokSayim.Location = new Point(12, 176);
            addgrvStokSayim.MaxFilterButtonImageHeight = 23;
            addgrvStokSayim.Name = "addgrvStokSayim";
            addgrvStokSayim.ReadOnly = true;
            addgrvStokSayim.RightToLeft = RightToLeft.No;
            addgrvStokSayim.Size = new Size(1580, 693);
            addgrvStokSayim.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            addgrvStokSayim.TabIndex = 35;
            addgrvStokSayim.CellValueChanged += addgrvStokSayim_CellValueChanged;
            addgrvStokSayim.EditingControlShowing += addgrvStokSayim_EditingControlShowing;
            // 
            // INVENTORY_PERIOD_ID
            // 
            INVENTORY_PERIOD_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            INVENTORY_PERIOD_ID.DataPropertyName = "INVENTORY_PERIOD_ID";
            INVENTORY_PERIOD_ID.Frozen = true;
            INVENTORY_PERIOD_ID.HeaderText = "Dövr no";
            INVENTORY_PERIOD_ID.MinimumWidth = 24;
            INVENTORY_PERIOD_ID.Name = "INVENTORY_PERIOD_ID";
            INVENTORY_PERIOD_ID.ReadOnly = true;
            INVENTORY_PERIOD_ID.SortMode = DataGridViewColumnSortMode.Programmatic;
            INVENTORY_PERIOD_ID.Width = 83;
            // 
            // DEPO_ID
            // 
            DEPO_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DEPO_ID.DataPropertyName = "DEPO_ID";
            DEPO_ID.Frozen = true;
            DEPO_ID.HeaderText = "Depo No";
            DEPO_ID.MinimumWidth = 24;
            DEPO_ID.Name = "DEPO_ID";
            DEPO_ID.ReadOnly = true;
            DEPO_ID.SortMode = DataGridViewColumnSortMode.Programmatic;
            DEPO_ID.Width = 88;
            // 
            // DEPO_AD
            // 
            DEPO_AD.DataPropertyName = "DEPO_AD";
            DEPO_AD.HeaderText = "Depo Ad";
            DEPO_AD.MinimumWidth = 24;
            DEPO_AD.Name = "DEPO_AD";
            DEPO_AD.ReadOnly = true;
            DEPO_AD.SortMode = DataGridViewColumnSortMode.Programmatic;
            DEPO_AD.Width = 120;
            // 
            // GroupCode
            // 
            GroupCode.DataPropertyName = "GroupCode";
            GroupCode.HeaderText = "Qrup";
            GroupCode.MinimumWidth = 24;
            GroupCode.Name = "GroupCode";
            GroupCode.ReadOnly = true;
            GroupCode.SortMode = DataGridViewColumnSortMode.Programmatic;
            GroupCode.Width = 120;
            // 
            // STOCK_ID
            // 
            STOCK_ID.DataPropertyName = "STOCK_ID";
            STOCK_ID.HeaderText = "Stok No";
            STOCK_ID.MinimumWidth = 24;
            STOCK_ID.Name = "STOCK_ID";
            STOCK_ID.ReadOnly = true;
            STOCK_ID.SortMode = DataGridViewColumnSortMode.Programmatic;
            STOCK_ID.Width = 90;
            // 
            // StockName
            // 
            StockName.DataPropertyName = "StockName";
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 128);
            StockName.DefaultCellStyle = dataGridViewCellStyle3;
            StockName.HeaderText = "Stok adı";
            StockName.MinimumWidth = 24;
            StockName.Name = "StockName";
            StockName.ReadOnly = true;
            StockName.SortMode = DataGridViewColumnSortMode.Programmatic;
            StockName.Width = 250;
            // 
            // BaseUnit
            // 
            BaseUnit.DataPropertyName = "BaseUnit";
            BaseUnit.HeaderText = "Vahid";
            BaseUnit.MinimumWidth = 24;
            BaseUnit.Name = "BaseUnit";
            BaseUnit.ReadOnly = true;
            BaseUnit.SortMode = DataGridViewColumnSortMode.Programmatic;
            BaseUnit.Width = 60;
            // 
            // ORTA_QIYMET
            // 
            ORTA_QIYMET.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ORTA_QIYMET.DataPropertyName = "ORTA_QIYMET";
            ORTA_QIYMET.HeaderText = "O. Qiymət";
            ORTA_QIYMET.MinimumWidth = 24;
            ORTA_QIYMET.Name = "ORTA_QIYMET";
            ORTA_QIYMET.ReadOnly = true;
            ORTA_QIYMET.SortMode = DataGridViewColumnSortMode.Programmatic;
            ORTA_QIYMET.Width = 95;
            // 
            // Opening_Balance
            // 
            Opening_Balance.DataPropertyName = "Opening_Balance";
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 255, 192);
            Opening_Balance.DefaultCellStyle = dataGridViewCellStyle4;
            Opening_Balance.HeaderText = "K.Qalıq";
            Opening_Balance.MinimumWidth = 24;
            Opening_Balance.Name = "Opening_Balance";
            Opening_Balance.ReadOnly = true;
            Opening_Balance.SortMode = DataGridViewColumnSortMode.Programmatic;
            Opening_Balance.Width = 90;
            // 
            // GIRIS
            // 
            GIRIS.DataPropertyName = "GIRIS";
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 192);
            GIRIS.DefaultCellStyle = dataGridViewCellStyle5;
            GIRIS.HeaderText = "Giriş";
            GIRIS.MinimumWidth = 24;
            GIRIS.Name = "GIRIS";
            GIRIS.ReadOnly = true;
            GIRIS.SortMode = DataGridViewColumnSortMode.Programmatic;
            GIRIS.Width = 85;
            // 
            // CIXIS
            // 
            CIXIS.DataPropertyName = "CIXIS";
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 255, 192);
            CIXIS.DefaultCellStyle = dataGridViewCellStyle6;
            CIXIS.HeaderText = "Çıxış";
            CIXIS.MinimumWidth = 24;
            CIXIS.Name = "CIXIS";
            CIXIS.ReadOnly = true;
            CIXIS.SortMode = DataGridViewColumnSortMode.Programmatic;
            CIXIS.Width = 85;
            // 
            // SATIS
            // 
            SATIS.DataPropertyName = "SATIS";
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 255, 192);
            SATIS.DefaultCellStyle = dataGridViewCellStyle7;
            SATIS.HeaderText = "Satış";
            SATIS.MinimumWidth = 24;
            SATIS.Name = "SATIS";
            SATIS.ReadOnly = true;
            SATIS.SortMode = DataGridViewColumnSortMode.Programmatic;
            SATIS.Width = 85;
            // 
            // QALIQ
            // 
            QALIQ.DataPropertyName = "QALIQ";
            dataGridViewCellStyle8.BackColor = Color.FromArgb(255, 255, 192);
            QALIQ.DefaultCellStyle = dataGridViewCellStyle8;
            QALIQ.HeaderText = "Qalıq";
            QALIQ.MinimumWidth = 24;
            QALIQ.Name = "QALIQ";
            QALIQ.ReadOnly = true;
            QALIQ.SortMode = DataGridViewColumnSortMode.Programmatic;
            QALIQ.Width = 85;
            // 
            // Say
            // 
            Say.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Say.DataPropertyName = "Say";
            dataGridViewCellStyle9.BackColor = Color.WhiteSmoke;
            Say.DefaultCellStyle = dataGridViewCellStyle9;
            Say.HeaderText = "Sayım";
            Say.MinimumWidth = 24;
            Say.Name = "Say";
            Say.ReadOnly = true;
            Say.SortMode = DataGridViewColumnSortMode.Programmatic;
            Say.Width = 70;
            // 
            // Semi_Product_Count
            // 
            Semi_Product_Count.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Semi_Product_Count.DataPropertyName = "Semi_Product_Count";
            dataGridViewCellStyle10.BackColor = Color.WhiteSmoke;
            Semi_Product_Count.DefaultCellStyle = dataGridViewCellStyle10;
            Semi_Product_Count.HeaderText = "PF Sayım";
            Semi_Product_Count.MinimumWidth = 24;
            Semi_Product_Count.Name = "Semi_Product_Count";
            Semi_Product_Count.ReadOnly = true;
            Semi_Product_Count.SortMode = DataGridViewColumnSortMode.Programmatic;
            Semi_Product_Count.Width = 89;
            // 
            // Total_Product_Count
            // 
            Total_Product_Count.DataPropertyName = "Total_Product_Count";
            dataGridViewCellStyle11.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(0, 64, 0);
            Total_Product_Count.DefaultCellStyle = dataGridViewCellStyle11;
            Total_Product_Count.HeaderText = "Sayım Cəm";
            Total_Product_Count.MinimumWidth = 24;
            Total_Product_Count.Name = "Total_Product_Count";
            Total_Product_Count.ReadOnly = true;
            Total_Product_Count.SortMode = DataGridViewColumnSortMode.Programmatic;
            Total_Product_Count.Width = 120;
            // 
            // FERQ
            // 
            FERQ.DataPropertyName = "FERQ";
            FERQ.HeaderText = "Fərq";
            FERQ.MinimumWidth = 24;
            FERQ.Name = "FERQ";
            FERQ.ReadOnly = true;
            FERQ.SortMode = DataGridViewColumnSortMode.Programmatic;
            FERQ.Width = 85;
            // 
            // frmStokSayim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 255, 255);
            ClientSize = new Size(1604, 881);
            Controls.Add(addgrvStokSayim);
            Controls.Add(btnInventoryConfirm);
            Controls.Add(btnSayimYenile);
            Controls.Add(lblSayimStatus);
            Controls.Add(btnAddSayimPeriod);
            Controls.Add(lblSayimPeriodDates);
            Controls.Add(dtpSayimEnd);
            Controls.Add(lblAdSoyad);
            Controls.Add(lblAdSoyadCaption);
            Controls.Add(lblUserId);
            Controls.Add(lblIstifadechi);
            Controls.Add(lblUserName);
            Controls.Add(lblStockName);
            Controls.Add(txtStockName);
            Controls.Add(lblStockGroup);
            Controls.Add(txtStockGroup);
            Controls.Add(btnExceleGonder);
            Controls.Add(btnFiltirliSayimiGetir);
            Controls.Add(dtpSayimStart);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmStokSayim";
            RightToLeft = RightToLeft.No;
            WindowState = FormWindowState.Maximized;
            Activated += frmStokSayim_Activated;
            Load += frmStokSayim_Load;
            ((System.ComponentModel.ISupportInitialize)addgrvStokSayim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpSayimStart;
        private DateTimePicker dtpSayimEnd;
        private Button btnFiltirliSayimiGetir;
        private Button btnExceleGonder;
        private TextBox txtStockGroup;
        private Label lblStockGroup;
        private Label lblStockName;
        private TextBox textBox1;
        private TextBox txtStockName;
        private Label lblAdSoyad;
        private Label lblAdSoyadCaption;
        private Label lblUserId;
        private Label lblIstifadechi;
        private Label lblUserName;
        private Label lblSayimPeriodDates;
        private Button btnAddSayimPeriod;
        private Label lblSayimStatus;
        private Button btnSayimYenile;
        private Button btnInventoryConfirm;
        private Zuby.ADGV.AdvancedDataGridView addgrvStokSayim;
        private DataGridViewTextBoxColumn INVENTORY_PERIOD_ID;
        private DataGridViewTextBoxColumn DEPO_ID;
        private DataGridViewTextBoxColumn DEPO_AD;
        private DataGridViewTextBoxColumn GroupCode;
        private DataGridViewTextBoxColumn STOCK_ID;
        private DataGridViewTextBoxColumn StockName;
        private DataGridViewTextBoxColumn BaseUnit;
        private DataGridViewTextBoxColumn ORTA_QIYMET;
        private DataGridViewTextBoxColumn Opening_Balance;
        private DataGridViewTextBoxColumn GIRIS;
        private DataGridViewTextBoxColumn CIXIS;
        private DataGridViewTextBoxColumn SATIS;
        private DataGridViewTextBoxColumn QALIQ;
        private DataGridViewTextBoxColumn Say;
        private DataGridViewTextBoxColumn Semi_Product_Count;
        private DataGridViewTextBoxColumn Total_Product_Count;
        private DataGridViewTextBoxColumn FERQ;
    }
}
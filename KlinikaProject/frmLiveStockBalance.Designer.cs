namespace POS_BACK_OFFICE
{
    partial class frmLiveStockBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLiveStockBalance));
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            addgrvLiveStockBalance = new Zuby.ADGV.AdvancedDataGridView();
            DepoId = new DataGridViewTextBoxColumn();
            DepoAd = new DataGridViewTextBoxColumn();
            GroupCode = new DataGridViewTextBoxColumn();
            StockId = new DataGridViewTextBoxColumn();
            StockName = new DataGridViewTextBoxColumn();
            BaseUnit = new DataGridViewTextBoxColumn();
            OrtaQiymet = new DataGridViewTextBoxColumn();
            Last_Closed_Balance = new DataGridViewTextBoxColumn();
            Giris = new DataGridViewTextBoxColumn();
            Cixis = new DataGridViewTextBoxColumn();
            Satis = new DataGridViewTextBoxColumn();
            Canli_Qaliq = new DataGridViewTextBoxColumn();
            Canli_Qaliq_Mebleg = new DataGridViewTextBoxColumn();
            lblAdSoyad = new Label();
            lblAdSoyadCaption = new Label();
            lblUserId = new Label();
            lblIstifadechi = new Label();
            lblUserName = new Label();
            btnExceleGonder = new Button();
            dtpLiveEndDate = new DateTimePicker();
            btnUpdateLiveStockBalance = new Button();
            panel1 = new Panel();
            lblStockCount = new Label();
            lblTotalStockAmount = new Label();
            label1 = new Label();
            label2 = new Label();
            footerGrid = new DataGridView();
            chkFooterIncl = new CheckBox();
            pictureBox1 = new PictureBox();
            SaveAsPDF = new Button();
            ((System.ComponentModel.ISupportInitialize)addgrvLiveStockBalance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)footerGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // addgrvLiveStockBalance
            // 
            addgrvLiveStockBalance.AllowUserToAddRows = false;
            addgrvLiveStockBalance.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            addgrvLiveStockBalance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            addgrvLiveStockBalance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addgrvLiveStockBalance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            addgrvLiveStockBalance.BorderStyle = BorderStyle.Fixed3D;
            addgrvLiveStockBalance.CausesValidation = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            addgrvLiveStockBalance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            addgrvLiveStockBalance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            addgrvLiveStockBalance.Columns.AddRange(new DataGridViewColumn[] { DepoId, DepoAd, GroupCode, StockId, StockName, BaseUnit, OrtaQiymet, Last_Closed_Balance, Giris, Cixis, Satis, Canli_Qaliq, Canli_Qaliq_Mebleg });
            addgrvLiveStockBalance.EnableHeadersVisualStyles = false;
            addgrvLiveStockBalance.FilterAndSortEnabled = false;
            addgrvLiveStockBalance.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            addgrvLiveStockBalance.GridColor = SystemColors.InactiveBorder;
            addgrvLiveStockBalance.Location = new Point(12, 94);
            addgrvLiveStockBalance.MaxFilterButtonImageHeight = 23;
            addgrvLiveStockBalance.Name = "addgrvLiveStockBalance";
            addgrvLiveStockBalance.ReadOnly = true;
            addgrvLiveStockBalance.RightToLeft = RightToLeft.No;
            addgrvLiveStockBalance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            addgrvLiveStockBalance.Size = new Size(1581, 697);
            addgrvLiveStockBalance.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            addgrvLiveStockBalance.TabIndex = 58;
            addgrvLiveStockBalance.CellValueChanged += addgrvLiveStockBalance_CellValueChanged;
            addgrvLiveStockBalance.RowsAdded += addgrvLiveStockBalance_RowsAdded;
            addgrvLiveStockBalance.RowsRemoved += addgrvLiveStockBalance_RowsRemoved;
            // 
            // DepoId
            // 
            DepoId.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DepoId.DataPropertyName = "DepoId";
            DepoId.HeaderText = "Depo No";
            DepoId.MinimumWidth = 24;
            DepoId.Name = "DepoId";
            DepoId.ReadOnly = true;
            DepoId.SortMode = DataGridViewColumnSortMode.Programmatic;
            DepoId.Visible = false;
            // 
            // DepoAd
            // 
            DepoAd.DataPropertyName = "DepoAd";
            DepoAd.HeaderText = "Depo Ad";
            DepoAd.MinimumWidth = 24;
            DepoAd.Name = "DepoAd";
            DepoAd.ReadOnly = true;
            DepoAd.SortMode = DataGridViewColumnSortMode.Programmatic;
            DepoAd.Visible = false;
            DepoAd.Width = 87;
            // 
            // GroupCode
            // 
            GroupCode.DataPropertyName = "GroupCode";
            GroupCode.HeaderText = "Qrup";
            GroupCode.MinimumWidth = 24;
            GroupCode.Name = "GroupCode";
            GroupCode.ReadOnly = true;
            GroupCode.SortMode = DataGridViewColumnSortMode.Programmatic;
            GroupCode.Visible = false;
            GroupCode.Width = 65;
            // 
            // StockId
            // 
            StockId.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            StockId.DataPropertyName = "StockId";
            StockId.HeaderText = "Çeşid No";
            StockId.MinimumWidth = 24;
            StockId.Name = "StockId";
            StockId.ReadOnly = true;
            StockId.SortMode = DataGridViewColumnSortMode.Programmatic;
            StockId.Width = 90;
            // 
            // StockName
            // 
            StockName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StockName.DataPropertyName = "StockName";
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 128);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StockName.DefaultCellStyle = dataGridViewCellStyle3;
            StockName.FillWeight = 200F;
            StockName.HeaderText = "Çeşid adı";
            StockName.MinimumWidth = 24;
            StockName.Name = "StockName";
            StockName.ReadOnly = true;
            StockName.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // BaseUnit
            // 
            BaseUnit.DataPropertyName = "BaseUnit";
            BaseUnit.HeaderText = "Vahid";
            BaseUnit.MinimumWidth = 24;
            BaseUnit.Name = "BaseUnit";
            BaseUnit.ReadOnly = true;
            BaseUnit.SortMode = DataGridViewColumnSortMode.Programmatic;
            BaseUnit.Visible = false;
            BaseUnit.Width = 70;
            // 
            // OrtaQiymet
            // 
            OrtaQiymet.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OrtaQiymet.DataPropertyName = "OrtaQiymet";
            OrtaQiymet.HeaderText = "O. Qiymət";
            OrtaQiymet.MinimumWidth = 24;
            OrtaQiymet.Name = "OrtaQiymet";
            OrtaQiymet.ReadOnly = true;
            OrtaQiymet.SortMode = DataGridViewColumnSortMode.Programmatic;
            OrtaQiymet.Visible = false;
            // 
            // Last_Closed_Balance
            // 
            Last_Closed_Balance.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Last_Closed_Balance.DataPropertyName = "Last_Closed_Balance";
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 255, 192);
            Last_Closed_Balance.DefaultCellStyle = dataGridViewCellStyle4;
            Last_Closed_Balance.HeaderText = "Son S. Qalıq";
            Last_Closed_Balance.MinimumWidth = 24;
            Last_Closed_Balance.Name = "Last_Closed_Balance";
            Last_Closed_Balance.ReadOnly = true;
            Last_Closed_Balance.SortMode = DataGridViewColumnSortMode.Programmatic;
            Last_Closed_Balance.Width = 104;
            // 
            // Giris
            // 
            Giris.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Giris.DataPropertyName = "Giris";
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Giris.DefaultCellStyle = dataGridViewCellStyle5;
            Giris.HeaderText = "Mədaxil";
            Giris.MinimumWidth = 24;
            Giris.Name = "Giris";
            Giris.ReadOnly = true;
            Giris.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Cixis
            // 
            Cixis.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Cixis.DataPropertyName = "Cixis";
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            Cixis.DefaultCellStyle = dataGridViewCellStyle6;
            Cixis.HeaderText = "Çıxış";
            Cixis.MinimumWidth = 24;
            Cixis.Name = "Cixis";
            Cixis.ReadOnly = true;
            Cixis.SortMode = DataGridViewColumnSortMode.Programmatic;
            Cixis.Visible = false;
            // 
            // Satis
            // 
            Satis.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Satis.DataPropertyName = "Satis";
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle7.Format = "N2";
            Satis.DefaultCellStyle = dataGridViewCellStyle7;
            Satis.HeaderText = "Satış";
            Satis.MinimumWidth = 24;
            Satis.Name = "Satis";
            Satis.ReadOnly = true;
            Satis.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Canli_Qaliq
            // 
            Canli_Qaliq.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Canli_Qaliq.DataPropertyName = "Canli_Qaliq";
            dataGridViewCellStyle8.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle8.Format = "N2";
            Canli_Qaliq.DefaultCellStyle = dataGridViewCellStyle8;
            Canli_Qaliq.HeaderText = "Qalıq";
            Canli_Qaliq.MinimumWidth = 24;
            Canli_Qaliq.Name = "Canli_Qaliq";
            Canli_Qaliq.ReadOnly = true;
            Canli_Qaliq.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Canli_Qaliq_Mebleg
            // 
            Canli_Qaliq_Mebleg.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Canli_Qaliq_Mebleg.DataPropertyName = "Canli_Qaliq_Mebleg";
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            Canli_Qaliq_Mebleg.DefaultCellStyle = dataGridViewCellStyle9;
            Canli_Qaliq_Mebleg.HeaderText = "Qalıq Məbəği";
            Canli_Qaliq_Mebleg.MinimumWidth = 24;
            Canli_Qaliq_Mebleg.Name = "Canli_Qaliq_Mebleg";
            Canli_Qaliq_Mebleg.ReadOnly = true;
            Canli_Qaliq_Mebleg.SortMode = DataGridViewColumnSortMode.Programmatic;
            Canli_Qaliq_Mebleg.Visible = false;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAdSoyad.ForeColor = SystemColors.ButtonHighlight;
            lblAdSoyad.Location = new Point(441, 1002);
            lblAdSoyad.Margin = new Padding(4, 0, 4, 0);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(118, 25);
            lblAdSoyad.TabIndex = 47;
            lblAdSoyad.Text = "Ad Familiya:";
            // 
            // lblAdSoyadCaption
            // 
            lblAdSoyadCaption.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAdSoyadCaption.AutoSize = true;
            lblAdSoyadCaption.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAdSoyadCaption.ForeColor = SystemColors.ButtonHighlight;
            lblAdSoyadCaption.Location = new Point(318, 1002);
            lblAdSoyadCaption.Margin = new Padding(4, 0, 4, 0);
            lblAdSoyadCaption.Name = "lblAdSoyadCaption";
            lblAdSoyadCaption.Size = new Size(129, 25);
            lblAdSoyadCaption.TabIndex = 46;
            lblAdSoyadCaption.Text = "| Ad Familiya:";
            // 
            // lblUserId
            // 
            lblUserId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUserId.AutoSize = true;
            lblUserId.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUserId.ForeColor = SystemColors.ButtonHighlight;
            lblUserId.Location = new Point(211, 1002);
            lblUserId.Margin = new Padding(4, 0, 4, 0);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(75, 25);
            lblUserId.TabIndex = 45;
            lblUserId.Text = "UserId:";
            // 
            // lblIstifadechi
            // 
            lblIstifadechi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblIstifadechi.AutoSize = true;
            lblIstifadechi.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblIstifadechi.ForeColor = SystemColors.ButtonHighlight;
            lblIstifadechi.Location = new Point(0, 1002);
            lblIstifadechi.Margin = new Padding(4, 0, 4, 0);
            lblIstifadechi.Name = "lblIstifadechi";
            lblIstifadechi.Size = new Size(69, 25);
            lblIstifadechi.TabIndex = 44;
            lblIstifadechi.Text = "| User:";
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUserName.ForeColor = SystemColors.ButtonHighlight;
            lblUserName.Location = new Point(75, 1002);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(106, 25);
            lblUserName.TabIndex = 43;
            lblUserName.Text = "Username:";
            // 
            // btnExceleGonder
            // 
            btnExceleGonder.BackColor = Color.FromArgb(128, 255, 128);
            btnExceleGonder.BackgroundImage = (Image)resources.GetObject("btnExceleGonder.BackgroundImage");
            btnExceleGonder.BackgroundImageLayout = ImageLayout.Stretch;
            btnExceleGonder.Enabled = false;
            btnExceleGonder.FlatAppearance.BorderColor = Color.Red;
            btnExceleGonder.FlatAppearance.BorderSize = 10;
            btnExceleGonder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnExceleGonder.ForeColor = Color.Black;
            btnExceleGonder.Location = new Point(640, 33);
            btnExceleGonder.Margin = new Padding(4, 3, 4, 3);
            btnExceleGonder.Name = "btnExceleGonder";
            btnExceleGonder.Size = new Size(121, 30);
            btnExceleGonder.TabIndex = 38;
            btnExceleGonder.Text = "EXCEL (Xlsx Format)";
            btnExceleGonder.TextAlign = ContentAlignment.MiddleRight;
            btnExceleGonder.UseVisualStyleBackColor = false;
            btnExceleGonder.Visible = false;
            btnExceleGonder.Click += btnExceleGonder_Click;
            // 
            // dtpLiveEndDate
            // 
            dtpLiveEndDate.Format = DateTimePickerFormat.Short;
            dtpLiveEndDate.Location = new Point(316, 13);
            dtpLiveEndDate.Margin = new Padding(4, 3, 4, 3);
            dtpLiveEndDate.Name = "dtpLiveEndDate";
            dtpLiveEndDate.Size = new Size(117, 23);
            dtpLiveEndDate.TabIndex = 36;
            // 
            // btnUpdateLiveStockBalance
            // 
            btnUpdateLiveStockBalance.BackgroundImage = (Image)resources.GetObject("btnUpdateLiveStockBalance.BackgroundImage");
            btnUpdateLiveStockBalance.BackgroundImageLayout = ImageLayout.Zoom;
            btnUpdateLiveStockBalance.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUpdateLiveStockBalance.Location = new Point(13, 12);
            btnUpdateLiveStockBalance.Margin = new Padding(4, 3, 4, 3);
            btnUpdateLiveStockBalance.Name = "btnUpdateLiveStockBalance";
            btnUpdateLiveStockBalance.Size = new Size(201, 58);
            btnUpdateLiveStockBalance.TabIndex = 64;
            btnUpdateLiveStockBalance.Text = "Canlı Qalıqları yenilə";
            btnUpdateLiveStockBalance.TextAlign = ContentAlignment.MiddleRight;
            btnUpdateLiveStockBalance.UseVisualStyleBackColor = true;
            btnUpdateLiveStockBalance.Click += btnUpdateLiveStockBalance_Click;
            //btnUpdateLiveStockBalance.ChangeUICues += btnUpdateLiveStockBalance_ChangeUICues;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(13, 832);
            panel1.Name = "panel1";
            panel1.Size = new Size(1579, 18);
            panel1.TabIndex = 65;
            // 
            // lblStockCount
            // 
            lblStockCount.AutoSize = true;
            lblStockCount.BackColor = Color.White;
            lblStockCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblStockCount.Location = new Point(1092, 22);
            lblStockCount.Name = "lblStockCount";
            lblStockCount.Size = new Size(37, 21);
            lblStockCount.TabIndex = 66;
            lblStockCount.Text = "Say";
            // 
            // lblTotalStockAmount
            // 
            lblTotalStockAmount.AutoSize = true;
            lblTotalStockAmount.BackColor = Color.Wheat;
            lblTotalStockAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTotalStockAmount.Location = new Point(1092, 42);
            lblTotalStockAmount.Name = "lblTotalStockAmount";
            lblTotalStockAmount.Size = new Size(68, 21);
            lblTotalStockAmount.TabIndex = 67;
            lblTotalStockAmount.Text = "Məbləğ";
            lblTotalStockAmount.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(973, 42);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 69;
            label1.Text = "Stok Məbləği";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(973, 22);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 68;
            label2.Text = "Çeşid Sayı";
            // 
            // footerGrid
            // 
            dataGridViewCellStyle10.BackColor = SystemColors.ControlDark;
            footerGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.Yellow;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            footerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            footerGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            footerGrid.Location = new Point(13, 791);
            footerGrid.Name = "footerGrid";
            footerGrid.Size = new Size(1580, 14);
            footerGrid.TabIndex = 71;
            footerGrid.Visible = false;
            // 
            // chkFooterIncl
            // 
            chkFooterIncl.AutoSize = true;
            chkFooterIncl.Enabled = false;
            chkFooterIncl.Location = new Point(640, 13);
            chkFooterIncl.Name = "chkFooterIncl";
            chkFooterIncl.Size = new Size(122, 19);
            chkFooterIncl.TabIndex = 72;
            chkFooterIncl.Text = "Toplamları daxil et";
            chkFooterIncl.UseVisualStyleBackColor = true;
            chkFooterIncl.Visible = false;
            chkFooterIncl.CheckedChanged += chkFooterIncl_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(785, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 70;
            pictureBox1.TabStop = false;
            // 
            // SaveAsPDF
            // 
            SaveAsPDF.BackColor = Color.Transparent;
            SaveAsPDF.BackgroundImage = (Image)resources.GetObject("SaveAsPDF.BackgroundImage");
            SaveAsPDF.BackgroundImageLayout = ImageLayout.Stretch;
            SaveAsPDF.FlatAppearance.BorderColor = Color.Red;
            SaveAsPDF.FlatAppearance.BorderSize = 10;
            SaveAsPDF.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            SaveAsPDF.ForeColor = Color.Black;
            SaveAsPDF.Location = new Point(222, 13);
            SaveAsPDF.Margin = new Padding(4, 3, 4, 3);
            SaveAsPDF.Name = "SaveAsPDF";
            SaveAsPDF.Size = new Size(71, 58);
            SaveAsPDF.TabIndex = 73;
            SaveAsPDF.TextAlign = ContentAlignment.MiddleRight;
            SaveAsPDF.UseVisualStyleBackColor = false;
            SaveAsPDF.Click += SaveAsPDF_Click;
            // 
            // frmLiveStockBalance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1604, 853);
            Controls.Add(SaveAsPDF);
            Controls.Add(chkFooterIncl);
            Controls.Add(footerGrid);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblTotalStockAmount);
            Controls.Add(lblStockCount);
            Controls.Add(panel1);
            Controls.Add(btnUpdateLiveStockBalance);
            Controls.Add(addgrvLiveStockBalance);
            Controls.Add(lblAdSoyad);
            Controls.Add(lblAdSoyadCaption);
            Controls.Add(lblUserId);
            Controls.Add(lblIstifadechi);
            Controls.Add(lblUserName);
            Controls.Add(btnExceleGonder);
            Controls.Add(dtpLiveEndDate);
            Name = "frmLiveStockBalance";
            Text = "frmLiveStockBalance";
            WindowState = FormWindowState.Maximized;
            Load += frmLiveStockBalance_Load;
            ((System.ComponentModel.ISupportInitialize)addgrvLiveStockBalance).EndInit();
            ((System.ComponentModel.ISupportInitialize)footerGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView addgrvLiveStockBalance;
        private Label lblSayimStatus;
        private Label lblSayimPeriodDates;
        private DateTimePicker dtpSayimEnd;
        private Label lblAdSoyad;
        private Label lblAdSoyadCaption;
        private Label lblUserId;
        private Label lblIstifadechi;
        private Label lblUserName;
        private Button btnExceleGonder;
        private DateTimePicker dtpLiveEndDate;
        private Button btnUpdateLiveStockBalance;
        private Panel panel1;
        private Label lblStockCount;
        private Label lblTotalStockAmount;
        private Label label1;
        private Label label2;
        private DataGridView footerGrid;
        private CheckBox chkFooterIncl;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn InventoryItem_Id;
        private Button SaveAsPDF;
        private DataGridViewTextBoxColumn DepoId;
        private DataGridViewTextBoxColumn DepoAd;
        private DataGridViewTextBoxColumn GroupCode;
        private DataGridViewTextBoxColumn StockId;
        private DataGridViewTextBoxColumn StockName;
        private DataGridViewTextBoxColumn BaseUnit;
        private DataGridViewTextBoxColumn OrtaQiymet;
        private DataGridViewTextBoxColumn Last_Closed_Balance;
        private DataGridViewTextBoxColumn Giris;
        private DataGridViewTextBoxColumn Cixis;
        private DataGridViewTextBoxColumn Satis;
        private DataGridViewTextBoxColumn Canli_Qaliq;
        private DataGridViewTextBoxColumn Canli_Qaliq_Mebleg;
    }
}
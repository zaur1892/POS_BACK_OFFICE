namespace POS_BACK_OFFICE
{
    partial class frmSale
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSale));
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
            dgrvDocumentSumStock = new DataGridView();
            txtCompanyName = new TextBox();
            lblCompanyName = new Label();
            lblLastPurchase = new Label();
            dataGridView1 = new DataGridView();
            txtUnvan = new TextBox();
            lblUnvan = new Label();
            txtTelefon = new TextBox();
            lblTelefon = new Label();
            txtQeyd = new TextBox();
            lblQeyd = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblDocType = new Label();
            cmbDocType = new ComboBox();
            txtCompanyCode = new TextBox();
            lblKontCode = new Label();
            btnSave = new Button();
            BtnCancel = new Button();
            AccountID = new TextBox();
            dgrvDocument = new DataGridView();
            dtpLastPurchaseDate = new DateTimePicker();
            txtSifarisNomresi = new TextBox();
            label2 = new Label();
            lblUserId = new Label();
            lblUserName = new Label();
            txtDocTypeId = new TextBox();
            lblSearchStock = new Label();
            label3 = new Label();
            cmbWarehouse = new ComboBox();
            txtWarehouseId = new TextBox();
            dtpDocDate = new DateTimePicker();
            lblDiscount = new Label();
            lblTotalAmount = new Label();
            lblSubtotal = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            txtBarcode = new TextBox();
            lblBarcode = new Label();
            chkDupCustomer = new CheckBox();
            Stock_Name = new DataGridViewTextBoxColumn();
            Box_Count = new DataGridViewTextBoxColumn();
            Total_Quantity = new DataGridViewTextBoxColumn();
            onePrice = new DataGridViewTextBoxColumn();
            totalSum = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            StockId = new DataGridViewTextBoxColumn();
            Barcode = new DataGridViewTextBoxColumn();
            StockName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            TotalQuantity = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            BaseUnitId = new DataGridViewTextBoxColumn();
            DefaultUnit = new DataGridViewTextBoxColumn();
            PurchaseUnitId = new DataGridViewTextBoxColumn();
            PurchaseUnit = new DataGridViewComboBoxColumn();
            Discount = new DataGridViewTextBoxColumn();
            DiscountPerCent = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgrvDocumentSumStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgrvDocument).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgrvDocumentSumStock
            // 
            dgrvDocumentSumStock.AllowUserToAddRows = false;
            dgrvDocumentSumStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgrvDocumentSumStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrvDocumentSumStock.BackgroundColor = SystemColors.ButtonFace;
            dgrvDocumentSumStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrvDocumentSumStock.Columns.AddRange(new DataGridViewColumn[] { Stock_Name, Box_Count, Total_Quantity, onePrice, totalSum });
            dgrvDocumentSumStock.Location = new Point(752, 331);
            dgrvDocumentSumStock.Name = "dgrvDocumentSumStock";
            dgrvDocumentSumStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrvDocumentSumStock.Size = new Size(524, 284);
            dgrvDocumentSumStock.TabIndex = 108;
            dgrvDocumentSumStock.CellValueChanged += dgrvDocumentSumStock_CellValueChanged;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(120, 40);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(214, 23);
            txtCompanyName.TabIndex = 1;
            txtCompanyName.TextChanged += txtCompanyName_TextChanged;
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCompanyName.Location = new Point(21, 42);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(86, 19);
            lblCompanyName.TabIndex = 2;
            lblCompanyName.Text = "Müştəri Adı";
            // 
            // lblLastPurchase
            // 
            lblLastPurchase.AutoSize = true;
            lblLastPurchase.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLastPurchase.Location = new Point(596, 43);
            lblLastPurchase.Name = "lblLastPurchase";
            lblLastPurchase.Size = new Size(62, 19);
            lblLastPurchase.TabIndex = 10;
            lblLastPurchase.Text = "Son Alış";
            lblLastPurchase.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(719, 74);
            dataGridView1.TabIndex = 11;
            dataGridView1.Visible = false;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // txtUnvan
            // 
            txtUnvan.Location = new Point(91, 85);
            txtUnvan.Name = "txtUnvan";
            txtUnvan.Size = new Size(312, 23);
            txtUnvan.TabIndex = 12;
            txtUnvan.Visible = false;
            // 
            // lblUnvan
            // 
            lblUnvan.AutoSize = true;
            lblUnvan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUnvan.Location = new Point(38, 87);
            lblUnvan.Name = "lblUnvan";
            lblUnvan.Size = new Size(51, 19);
            lblUnvan.TabIndex = 13;
            lblUnvan.Text = "Ünvan";
            lblUnvan.Visible = false;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(470, 84);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(106, 23);
            txtTelefon.TabIndex = 14;
            txtTelefon.Visible = false;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTelefon.Location = new Point(410, 86);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(58, 19);
            lblTelefon.TabIndex = 15;
            lblTelefon.Text = "Telefon";
            lblTelefon.Visible = false;
            // 
            // txtQeyd
            // 
            txtQeyd.Location = new Point(120, 112);
            txtQeyd.Name = "txtQeyd";
            txtQeyd.Size = new Size(214, 23);
            txtQeyd.TabIndex = 18;
            // 
            // lblQeyd
            // 
            lblQeyd.AutoSize = true;
            lblQeyd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblQeyd.Location = new Point(62, 114);
            lblQeyd.Name = "lblQeyd";
            lblQeyd.Size = new Size(45, 19);
            lblQeyd.TabIndex = 19;
            lblQeyd.Text = "Qeyd";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(470, 113);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(106, 23);
            txtEmail.TabIndex = 20;
            txtEmail.Visible = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.Location = new Point(417, 115);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 19);
            lblEmail.TabIndex = 21;
            lblEmail.Text = "E-mail";
            lblEmail.Visible = false;
            // 
            // lblDocType
            // 
            lblDocType.AutoSize = true;
            lblDocType.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDocType.Location = new Point(143, 16);
            lblDocType.Name = "lblDocType";
            lblDocType.Size = new Size(90, 19);
            lblDocType.TabIndex = 23;
            lblDocType.Text = "Sənəd Növü";
            lblDocType.Visible = false;
            // 
            // cmbDocType
            // 
            cmbDocType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cmbDocType.FormattingEnabled = true;
            cmbDocType.Location = new Point(239, 12);
            cmbDocType.Name = "cmbDocType";
            cmbDocType.Size = new Size(139, 23);
            cmbDocType.TabIndex = 24;
            cmbDocType.Visible = false;
            cmbDocType.SelectedIndexChanged += cmbDocType_SelectedIndexChanged;
            // 
            // txtCompanyCode
            // 
            txtCompanyCode.Location = new Point(414, 38);
            txtCompanyCode.Name = "txtCompanyCode";
            txtCompanyCode.Size = new Size(159, 23);
            txtCompanyCode.TabIndex = 25;
            txtCompanyCode.TextChanged += txtFinKod_TextChanged;
            // 
            // lblKontCode
            // 
            lblKontCode.AutoSize = true;
            lblKontCode.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblKontCode.Location = new Point(349, 42);
            lblKontCode.Name = "lblKontCode";
            lblKontCode.Size = new Size(44, 19);
            lblKontCode.TabIndex = 26;
            lblKontCode.Text = "Kodu";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.Location = new Point(1147, 43);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 42);
            btnSave.TabIndex = 30;
            btnSave.Text = "Yadda Saxla";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnCancel.ForeColor = Color.Red;
            BtnCancel.Location = new Point(1148, 96);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(128, 42);
            BtnCancel.TabIndex = 31;
            BtnCancel.Text = "Ləğv Et";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // AccountID
            // 
            AccountID.Enabled = false;
            AccountID.Location = new Point(21, 12);
            AccountID.Name = "AccountID";
            AccountID.Size = new Size(112, 23);
            AccountID.TabIndex = 40;
            // 
            // dgrvDocument
            // 
            dgrvDocument.AllowUserToAddRows = false;
            dgrvDocument.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgrvDocument.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrvDocument.BackgroundColor = SystemColors.ButtonFace;
            dgrvDocument.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrvDocument.Columns.AddRange(new DataGridViewColumn[] { Date, StockId, Barcode, StockName, Quantity, Price, TotalQuantity, TotalAmount, BaseUnitId, DefaultUnit, PurchaseUnitId, PurchaseUnit, Discount, DiscountPerCent });
            dgrvDocument.Location = new Point(21, 331);
            dgrvDocument.Name = "dgrvDocument";
            dgrvDocument.ReadOnly = true;
            dgrvDocument.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrvDocument.Size = new Size(719, 284);
            dgrvDocument.TabIndex = 55;
            dgrvDocument.CellValueChanged += dgrvDocument_CellValueChanged;
            // 
            // dtpLastPurchaseDate
            // 
            dtpLastPurchaseDate.Format = DateTimePickerFormat.Short;
            dtpLastPurchaseDate.Location = new Point(665, 42);
            dtpLastPurchaseDate.Name = "dtpLastPurchaseDate";
            dtpLastPurchaseDate.Size = new Size(75, 23);
            dtpLastPurchaseDate.TabIndex = 66;
            dtpLastPurchaseDate.Value = new DateTime(2025, 3, 27, 0, 0, 0, 0);
            dtpLastPurchaseDate.Visible = false;
            // 
            // txtSifarisNomresi
            // 
            txtSifarisNomresi.Location = new Point(20, 301);
            txtSifarisNomresi.Name = "txtSifarisNomresi";
            txtSifarisNomresi.ReadOnly = true;
            txtSifarisNomresi.Size = new Size(108, 23);
            txtSifarisNomresi.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(134, 305);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 68;
            label2.Text = "SİFARİŞ  №";
            // 
            // lblUserId
            // 
            lblUserId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUserId.AutoSize = true;
            lblUserId.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUserId.ForeColor = SystemColors.ActiveCaptionText;
            lblUserId.Location = new Point(12, 699);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(63, 21);
            lblUserId.TabIndex = 72;
            lblUserId.Text = "UserId:";
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUserName.ForeColor = SystemColors.ActiveCaptionText;
            lblUserName.Location = new Point(120, 699);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(91, 21);
            lblUserName.TabIndex = 73;
            lblUserName.Text = "Username:";
            // 
            // txtDocTypeId
            // 
            txtDocTypeId.Enabled = false;
            txtDocTypeId.Location = new Point(384, 13);
            txtDocTypeId.Name = "txtDocTypeId";
            txtDocTypeId.Size = new Size(23, 23);
            txtDocTypeId.TabIndex = 74;
            txtDocTypeId.Visible = false;
            // 
            // lblSearchStock
            // 
            lblSearchStock.AutoSize = true;
            lblSearchStock.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSearchStock.Location = new Point(20, 232);
            lblSearchStock.Name = "lblSearchStock";
            lblSearchStock.Size = new Size(94, 17);
            lblSearchStock.TabIndex = 82;
            lblSearchStock.Text = "ÇEŞİD AXTAR:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(591, 90);
            label3.Name = "label3";
            label3.Size = new Size(50, 19);
            label3.TabIndex = 86;
            label3.Text = "Anbar";
            label3.Visible = false;
            // 
            // cmbWarehouse
            // 
            cmbWarehouse.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cmbWarehouse.FormattingEnabled = true;
            cmbWarehouse.Location = new Point(651, 83);
            cmbWarehouse.Name = "cmbWarehouse";
            cmbWarehouse.Size = new Size(75, 23);
            cmbWarehouse.TabIndex = 87;
            cmbWarehouse.Visible = false;
            cmbWarehouse.SelectedIndexChanged += cmbWarehouse_SelectedIndexChanged;
            // 
            // txtWarehouseId
            // 
            txtWarehouseId.Enabled = false;
            txtWarehouseId.Location = new Point(703, 112);
            txtWarehouseId.Name = "txtWarehouseId";
            txtWarehouseId.Size = new Size(23, 23);
            txtWarehouseId.TabIndex = 88;
            txtWarehouseId.Visible = false;
            // 
            // dtpDocDate
            // 
            dtpDocDate.Enabled = false;
            dtpDocDate.Format = DateTimePickerFormat.Short;
            dtpDocDate.Location = new Point(21, 170);
            dtpDocDate.Name = "dtpDocDate";
            dtpDocDate.Size = new Size(108, 23);
            dtpDocDate.TabIndex = 89;
            dtpDocDate.Value = new DateTime(2025, 3, 27, 0, 0, 0, 0);
            // 
            // lblDiscount
            // 
            lblDiscount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(157, 40);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(54, 15);
            lblDiscount.TabIndex = 100;
            lblDiscount.Text = "Discount";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(157, 57);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(80, 15);
            lblTotalAmount.TabIndex = 101;
            lblTotalAmount.Text = "Total Amount";
            // 
            // lblSubtotal
            // 
            lblSubtotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(157, 23);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(51, 15);
            lblSubtotal.TabIndex = 99;
            lblSubtotal.Text = "Subtotal";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(54, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 106;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblSubtotal);
            panel1.Controls.Add(lblTotalAmount);
            panel1.Controls.Add(lblDiscount);
            panel1.Location = new Point(930, 621);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 78);
            panel1.TabIndex = 105;
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(98, 262);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(294, 23);
            txtBarcode.TabIndex = 106;
            txtBarcode.KeyDown += txtBarcode_KeyDown;
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBarcode.Location = new Point(20, 264);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(65, 17);
            lblBarcode.TabIndex = 107;
            lblBarcode.Text = "BARKOD:";
            // 
            // chkDupCustomer
            // 
            chkDupCustomer.AutoSize = true;
            chkDupCustomer.BackColor = Color.LimeGreen;
            chkDupCustomer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            chkDupCustomer.ForeColor = Color.Transparent;
            chkDupCustomer.Location = new Point(1103, 13);
            chkDupCustomer.Name = "chkDupCustomer";
            chkDupCustomer.Size = new Size(173, 21);
            chkDupCustomer.TabIndex = 69;
            chkDupCustomer.Text = "MÜŞTƏRİ BAZASINDAN";
            chkDupCustomer.UseVisualStyleBackColor = false;
            chkDupCustomer.CheckedChanged += chkDupCustomer_CheckedChanged;
            // 
            // Stock_Name
            // 
            Stock_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Stock_Name.DefaultCellStyle = dataGridViewCellStyle1;
            Stock_Name.FillWeight = 150F;
            Stock_Name.Frozen = true;
            Stock_Name.HeaderText = "Çeşid Adı";
            Stock_Name.Name = "Stock_Name";
            Stock_Name.ReadOnly = true;
            Stock_Name.Width = 150;
            // 
            // Box_Count
            // 
            Box_Count.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Box_Count.FillWeight = 60F;
            Box_Count.HeaderText = "Qutu Sayı";
            Box_Count.Name = "Box_Count";
            Box_Count.Width = 85;
            // 
            // Total_Quantity
            // 
            Total_Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Total_Quantity.DefaultCellStyle = dataGridViewCellStyle2;
            Total_Quantity.FillWeight = 60F;
            Total_Quantity.HeaderText = "Çəki KG";
            Total_Quantity.Name = "Total_Quantity";
            Total_Quantity.Width = 80;
            // 
            // onePrice
            // 
            onePrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            onePrice.FillWeight = 60F;
            onePrice.HeaderText = "Qiymət";
            onePrice.Name = "onePrice";
            onePrice.Width = 80;
            // 
            // totalSum
            // 
            totalSum.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            totalSum.FillWeight = 60F;
            totalSum.HeaderText = "Cəm AZN";
            totalSum.Name = "totalSum";
            totalSum.Width = 85;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Date.FillWeight = 80F;
            Date.HeaderText = "Tarix";
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 80;
            // 
            // StockId
            // 
            StockId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            StockId.FillWeight = 60F;
            StockId.HeaderText = "Çeşid ID";
            StockId.Name = "StockId";
            StockId.ReadOnly = true;
            StockId.Visible = false;
            StockId.Width = 60;
            // 
            // Barcode
            // 
            Barcode.HeaderText = "Barkod";
            Barcode.Name = "Barcode";
            Barcode.ReadOnly = true;
            // 
            // StockName
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            StockName.DefaultCellStyle = dataGridViewCellStyle3;
            StockName.FillWeight = 120F;
            StockName.HeaderText = "Çeşid Adı";
            StockName.Name = "StockName";
            StockName.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Quantity.DefaultCellStyle = dataGridViewCellStyle4;
            Quantity.FillWeight = 80F;
            Quantity.HeaderText = "Çəki KG";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 80;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Price.DefaultCellStyle = dataGridViewCellStyle5;
            Price.FillWeight = 80F;
            Price.HeaderText = "Qiymət";
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Resizable = DataGridViewTriState.False;
            Price.Width = 71;
            // 
            // TotalQuantity
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 255, 192);
            TotalQuantity.DefaultCellStyle = dataGridViewCellStyle6;
            TotalQuantity.FillWeight = 80F;
            TotalQuantity.HeaderText = "Cəm Ədəd";
            TotalQuantity.Name = "TotalQuantity";
            TotalQuantity.ReadOnly = true;
            TotalQuantity.Visible = false;
            // 
            // TotalAmount
            // 
            TotalAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 255, 128);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TotalAmount.DefaultCellStyle = dataGridViewCellStyle7;
            TotalAmount.HeaderText = "Toplam";
            TotalAmount.Name = "TotalAmount";
            TotalAmount.ReadOnly = true;
            TotalAmount.Width = 72;
            // 
            // BaseUnitId
            // 
            BaseUnitId.HeaderText = "BaseUnitId";
            BaseUnitId.Name = "BaseUnitId";
            BaseUnitId.ReadOnly = true;
            BaseUnitId.Visible = false;
            // 
            // DefaultUnit
            // 
            DefaultUnit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DefaultUnit.HeaderText = "Std Vahid";
            DefaultUnit.Name = "DefaultUnit";
            DefaultUnit.ReadOnly = true;
            DefaultUnit.Visible = false;
            DefaultUnit.Width = 98;
            // 
            // PurchaseUnitId
            // 
            dataGridViewCellStyle8.NullValue = "0";
            PurchaseUnitId.DefaultCellStyle = dataGridViewCellStyle8;
            PurchaseUnitId.HeaderText = "PurchaseUnitId";
            PurchaseUnitId.Name = "PurchaseUnitId";
            PurchaseUnitId.ReadOnly = true;
            PurchaseUnitId.Visible = false;
            // 
            // PurchaseUnit
            // 
            PurchaseUnit.FillWeight = 80F;
            PurchaseUnit.HeaderText = "Alış Vahidi";
            PurchaseUnit.Name = "PurchaseUnit";
            PurchaseUnit.ReadOnly = true;
            PurchaseUnit.Resizable = DataGridViewTriState.True;
            PurchaseUnit.SortMode = DataGridViewColumnSortMode.Automatic;
            PurchaseUnit.Visible = false;
            // 
            // Discount
            // 
            Discount.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle9.NullValue = "0";
            Discount.DefaultCellStyle = dataGridViewCellStyle9;
            Discount.FillWeight = 80F;
            Discount.HeaderText = "Endirim";
            Discount.Name = "Discount";
            Discount.ReadOnly = true;
            Discount.Visible = false;
            Discount.Width = 73;
            // 
            // DiscountPerCent
            // 
            dataGridViewCellStyle10.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle10.NullValue = "0";
            DiscountPerCent.DefaultCellStyle = dataGridViewCellStyle10;
            DiscountPerCent.FillWeight = 80F;
            DiscountPerCent.HeaderText = "Endir. Faiz %";
            DiscountPerCent.Name = "DiscountPerCent";
            DiscountPerCent.ReadOnly = true;
            DiscountPerCent.Visible = false;
            // 
            // frmSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 729);
            Controls.Add(dgrvDocumentSumStock);
            Controls.Add(lblBarcode);
            Controls.Add(txtBarcode);
            Controls.Add(panel1);
            Controls.Add(dtpDocDate);
            Controls.Add(txtWarehouseId);
            Controls.Add(cmbWarehouse);
            Controls.Add(label3);
            Controls.Add(lblSearchStock);
            Controls.Add(txtDocTypeId);
            Controls.Add(lblUserName);
            Controls.Add(lblUserId);
            Controls.Add(chkDupCustomer);
            Controls.Add(label2);
            Controls.Add(txtSifarisNomresi);
            Controls.Add(dtpLastPurchaseDate);
            Controls.Add(dgrvDocument);
            Controls.Add(AccountID);
            Controls.Add(BtnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblKontCode);
            Controls.Add(txtCompanyCode);
            Controls.Add(cmbDocType);
            Controls.Add(lblDocType);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblQeyd);
            Controls.Add(txtQeyd);
            Controls.Add(lblTelefon);
            Controls.Add(txtTelefon);
            Controls.Add(lblUnvan);
            Controls.Add(txtUnvan);
            Controls.Add(dataGridView1);
            Controls.Add(lblLastPurchase);
            Controls.Add(lblCompanyName);
            Controls.Add(txtCompanyName);
            Name = "frmSale";
            Text = "Form1";
            WindowState = FormWindowState.Minimized;
            Load += frmQeydiyyat_Load;
            ((System.ComponentModel.ISupportInitialize)dgrvDocumentSumStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgrvDocument).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSoyad;
        private Label lblAtaAd;
        private Label lblShirket;

        private DataGridView dgrvXidmetler;
        private DataGridView dgrvDocumentSumStock;
        private TextBox txtCompanyName;
        private Label lblCompanyName;
        private Label lblLastPurchase;
        private DataGridView dataGridView1;
        private TextBox txtUnvan;
        private Label lblUnvan;
        private TextBox txtTelefon;
        private Label lblTelefon;
        private TextBox txtQeyd;
        private Label lblQeyd;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblDocType;
        private ComboBox cmbDocType;
        private TextBox txtCompanyCode;
        private Label lblKontCode;
        private Button btnSave;
        private Button BtnCancel;
        private TextBox AccountID;
        private DataGridView dgrvDocument;
        private DateTimePicker dtpLastPurchaseDate;
        private TextBox txtSifarisNomresi;
        private Label label2;
        private Label lblUserId;
        private Label lblUserName;
        private TextBox txtDocTypeId;
        private Label lblSearchStock;
        private Label label3;
        private ComboBox cmbWarehouse;
        private TextBox txtWarehouseId;
        private DateTimePicker dtpDocDate;
        private Label lblDiscount;
        private Label lblTotalAmount;
        private Label lblSubtotal;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox txtBarcode;
        private Label lblBarcode;
        private CheckBox chkDupCustomer;
        private DataGridViewTextBoxColumn Stock_Name;
        private DataGridViewTextBoxColumn Box_Count;
        private DataGridViewTextBoxColumn Total_Quantity;
        private DataGridViewTextBoxColumn onePrice;
        private DataGridViewTextBoxColumn totalSum;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn StockId;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn StockName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn TotalQuantity;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewTextBoxColumn BaseUnitId;
        private DataGridViewTextBoxColumn DefaultUnit;
        private DataGridViewTextBoxColumn PurchaseUnitId;
        private DataGridViewComboBoxColumn PurchaseUnit;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewTextBoxColumn DiscountPerCent;
    }
}

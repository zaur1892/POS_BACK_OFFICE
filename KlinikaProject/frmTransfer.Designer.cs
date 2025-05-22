namespace POS_BACK_OFFICE
{
    partial class frmTransfer
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnSave = new Button();
            BtnCancel = new Button();
            dgrvDocument = new DataGridView();
            txtSifarisNomresi = new TextBox();
            label2 = new Label();
            lblUserId = new Label();
            lblUserName = new Label();
            lblStock = new Label();
            txtStockGroupId = new TextBox();
            lstStockGroup = new ListBox();
            txtStockGroup = new TextBox();
            txtStockId = new TextBox();
            lstStock = new ListBox();
            txtStock = new TextBox();
            lblSearchStock = new Label();
            lblSourceWarehouse = new Label();
            dtpDocDate = new DateTimePicker();
            txtTargetWarehouseId = new TextBox();
            cmbTargetWarehouse = new ComboBox();
            lblTargetWarehouse = new Label();
            txtSourceWarehouseId = new TextBox();
            cmbSourceWarehouse = new ComboBox();
            Date = new DataGridViewTextBoxColumn();
            StockId = new DataGridViewTextBoxColumn();
            StockName = new DataGridViewTextBoxColumn();
            BaseUnitId = new DataGridViewTextBoxColumn();
            DefaultUnit = new DataGridViewTextBoxColumn();
            PurchaseUnitId = new DataGridViewTextBoxColumn();
            PurchaseUnit = new DataGridViewComboBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            TotalQuantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgrvDocument).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.Location = new Point(1209, 45);
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
            BtnCancel.Location = new Point(1209, 93);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(128, 42);
            BtnCancel.TabIndex = 31;
            BtnCancel.Text = "Ləğv Et";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // dgrvDocument
            // 
            dgrvDocument.AllowUserToAddRows = false;
            dgrvDocument.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgrvDocument.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrvDocument.BackgroundColor = SystemColors.ButtonFace;
            dgrvDocument.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrvDocument.Columns.AddRange(new DataGridViewColumn[] { Date, StockId, StockName, BaseUnitId, DefaultUnit, PurchaseUnitId, PurchaseUnit, Quantity, TotalQuantity, Price, TotalAmount });
            dgrvDocument.Location = new Point(497, 349);
            dgrvDocument.Name = "dgrvDocument";
            dgrvDocument.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrvDocument.Size = new Size(841, 316);
            dgrvDocument.TabIndex = 55;
            // 
            // txtSifarisNomresi
            // 
            txtSifarisNomresi.Location = new Point(497, 320);
            txtSifarisNomresi.Name = "txtSifarisNomresi";
            txtSifarisNomresi.ReadOnly = true;
            txtSifarisNomresi.Size = new Size(108, 23);
            txtSifarisNomresi.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(611, 324);
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
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblStock.Location = new Point(29, 272);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(130, 17);
            lblStock.TabIndex = 78;
            lblStock.Text = "STOK QRUP AXTAR:";
            // 
            // txtStockGroupId
            // 
            txtStockGroupId.Enabled = false;
            txtStockGroupId.Font = new Font("Segoe UI", 8.25F);
            txtStockGroupId.Location = new Point(340, 292);
            txtStockGroupId.Name = "txtStockGroupId";
            txtStockGroupId.Size = new Size(17, 22);
            txtStockGroupId.TabIndex = 77;
            // 
            // lstStockGroup
            // 
            lstStockGroup.FormattingEnabled = true;
            lstStockGroup.ItemHeight = 15;
            lstStockGroup.Location = new Point(29, 318);
            lstStockGroup.Name = "lstStockGroup";
            lstStockGroup.Size = new Size(305, 64);
            lstStockGroup.TabIndex = 76;
            lstStockGroup.Visible = false;
            lstStockGroup.Click += lstStockGroup_Click;
            // 
            // txtStockGroup
            // 
            txtStockGroup.Location = new Point(29, 292);
            txtStockGroup.Name = "txtStockGroup";
            txtStockGroup.Size = new Size(305, 23);
            txtStockGroup.TabIndex = 75;
            txtStockGroup.TextChanged += txtStockGroup_TextChanged;
            // 
            // txtStockId
            // 
            txtStockId.Enabled = false;
            txtStockId.Font = new Font("Segoe UI", 8.25F);
            txtStockId.Location = new Point(474, 409);
            txtStockId.Name = "txtStockId";
            txtStockId.Size = new Size(17, 22);
            txtStockId.TabIndex = 81;
            // 
            // lstStock
            // 
            lstStock.FormattingEnabled = true;
            lstStock.ItemHeight = 15;
            lstStock.Location = new Point(29, 434);
            lstStock.Name = "lstStock";
            lstStock.Size = new Size(439, 229);
            lstStock.TabIndex = 80;
            lstStock.Visible = false;
            lstStock.Click += lstStock_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(29, 408);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(439, 23);
            txtStock.TabIndex = 79;
            txtStock.TextChanged += txtStock_TextChanged;
            // 
            // lblSearchStock
            // 
            lblSearchStock.AutoSize = true;
            lblSearchStock.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSearchStock.Location = new Point(29, 388);
            lblSearchStock.Name = "lblSearchStock";
            lblSearchStock.Size = new Size(130, 17);
            lblSearchStock.TabIndex = 82;
            lblSearchStock.Text = "STOK QRUP AXTAR:";
            // 
            // lblSourceWarehouse
            // 
            lblSourceWarehouse.AutoSize = true;
            lblSourceWarehouse.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSourceWarehouse.Location = new Point(29, 24);
            lblSourceWarehouse.Name = "lblSourceWarehouse";
            lblSourceWarehouse.Size = new Size(100, 19);
            lblSourceWarehouse.TabIndex = 86;
            lblSourceWarehouse.Text = "Mənbə Anbar";
            // 
            // dtpDocDate
            // 
            dtpDocDate.Format = DateTimePickerFormat.Short;
            dtpDocDate.Location = new Point(497, 291);
            dtpDocDate.Name = "dtpDocDate";
            dtpDocDate.Size = new Size(108, 23);
            dtpDocDate.TabIndex = 89;
            dtpDocDate.Value = new DateTime(2025, 3, 27, 0, 0, 0, 0);
            // 
            // txtTargetWarehouseId
            // 
            txtTargetWarehouseId.Enabled = false;
            txtTargetWarehouseId.Location = new Point(280, 60);
            txtTargetWarehouseId.Name = "txtTargetWarehouseId";
            txtTargetWarehouseId.Size = new Size(23, 23);
            txtTargetWarehouseId.TabIndex = 92;
            // 
            // cmbTargetWarehouse
            // 
            cmbTargetWarehouse.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cmbTargetWarehouse.FormattingEnabled = true;
            cmbTargetWarehouse.Location = new Point(135, 59);
            cmbTargetWarehouse.Name = "cmbTargetWarehouse";
            cmbTargetWarehouse.Size = new Size(139, 23);
            cmbTargetWarehouse.TabIndex = 91;
            cmbTargetWarehouse.SelectedIndexChanged += cmbTargetWarehouse_SelectedIndexChanged;
            // 
            // lblTargetWarehouse
            // 
            lblTargetWarehouse.AutoSize = true;
            lblTargetWarehouse.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTargetWarehouse.Location = new Point(29, 60);
            lblTargetWarehouse.Name = "lblTargetWarehouse";
            lblTargetWarehouse.Size = new Size(95, 19);
            lblTargetWarehouse.TabIndex = 90;
            lblTargetWarehouse.Text = "Hədəf Anbar";
            // 
            // txtSourceWarehouseId
            // 
            txtSourceWarehouseId.Enabled = false;
            txtSourceWarehouseId.Location = new Point(280, 31);
            txtSourceWarehouseId.Name = "txtSourceWarehouseId";
            txtSourceWarehouseId.Size = new Size(23, 23);
            txtSourceWarehouseId.TabIndex = 94;
            // 
            // cmbSourceWarehouse
            // 
            cmbSourceWarehouse.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cmbSourceWarehouse.FormattingEnabled = true;
            cmbSourceWarehouse.Location = new Point(135, 30);
            cmbSourceWarehouse.Name = "cmbSourceWarehouse";
            cmbSourceWarehouse.Size = new Size(139, 23);
            cmbSourceWarehouse.TabIndex = 93;
            cmbSourceWarehouse.SelectedIndexChanged += cmbSourceWarehouse_SelectedIndexChanged;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Date.FillWeight = 50F;
            Date.Frozen = true;
            Date.HeaderText = "Tarix";
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 50;
            // 
            // StockId
            // 
            StockId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StockId.HeaderText = "Xidmetid";
            StockId.Name = "StockId";
            StockId.ReadOnly = true;
            StockId.Visible = false;
            StockId.Width = 80;
            // 
            // StockName
            // 
            StockName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            StockName.DefaultCellStyle = dataGridViewCellStyle1;
            StockName.FillWeight = 120F;
            StockName.Frozen = true;
            StockName.HeaderText = "Stok Adı";
            StockName.Name = "StockName";
            StockName.ReadOnly = true;
            StockName.Width = 119;
            // 
            // BaseUnitId
            // 
            BaseUnitId.HeaderText = "BaseUnitId";
            BaseUnitId.Name = "BaseUnitId";
            BaseUnitId.Visible = false;
            // 
            // DefaultUnit
            // 
            DefaultUnit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DefaultUnit.Frozen = true;
            DefaultUnit.HeaderText = "Std Vahid";
            DefaultUnit.Name = "DefaultUnit";
            DefaultUnit.Width = 98;
            // 
            // PurchaseUnitId
            // 
            dataGridViewCellStyle2.NullValue = "0";
            PurchaseUnitId.DefaultCellStyle = dataGridViewCellStyle2;
            PurchaseUnitId.Frozen = true;
            PurchaseUnitId.HeaderText = "PurchaseUnitId";
            PurchaseUnitId.Name = "PurchaseUnitId";
            PurchaseUnitId.ReadOnly = true;
            PurchaseUnitId.Visible = false;
            // 
            // PurchaseUnit
            // 
            PurchaseUnit.FillWeight = 80F;
            PurchaseUnit.HeaderText = "Fərqli Vahidlə";
            PurchaseUnit.Name = "PurchaseUnit";
            PurchaseUnit.Resizable = DataGridViewTriState.True;
            PurchaseUnit.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Quantity
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Quantity.DefaultCellStyle = dataGridViewCellStyle3;
            Quantity.FillWeight = 80F;
            Quantity.HeaderText = "Ədəd";
            Quantity.Name = "Quantity";
            // 
            // TotalQuantity
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 255, 192);
            TotalQuantity.DefaultCellStyle = dataGridViewCellStyle4;
            TotalQuantity.FillWeight = 80F;
            TotalQuantity.HeaderText = "Cəm Ədəd";
            TotalQuantity.Name = "TotalQuantity";
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
            Price.Width = 71;
            // 
            // TotalAmount
            // 
            TotalAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 255, 128);
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TotalAmount.DefaultCellStyle = dataGridViewCellStyle6;
            TotalAmount.HeaderText = "Toplam";
            TotalAmount.Name = "TotalAmount";
            TotalAmount.ReadOnly = true;
            TotalAmount.Width = 71;
            // 
            // frmTransfer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(txtSourceWarehouseId);
            Controls.Add(cmbSourceWarehouse);
            Controls.Add(txtTargetWarehouseId);
            Controls.Add(cmbTargetWarehouse);
            Controls.Add(lblTargetWarehouse);
            Controls.Add(dtpDocDate);
            Controls.Add(lblSourceWarehouse);
            Controls.Add(lblSearchStock);
            Controls.Add(txtStockId);
            Controls.Add(lstStock);
            Controls.Add(txtStock);
            Controls.Add(lblStock);
            Controls.Add(txtStockGroupId);
            Controls.Add(lstStockGroup);
            Controls.Add(txtStockGroup);
            Controls.Add(lblUserName);
            Controls.Add(lblUserId);
            Controls.Add(label2);
            Controls.Add(txtSifarisNomresi);
            Controls.Add(dgrvDocument);
            Controls.Add(BtnCancel);
            Controls.Add(btnSave);
            Name = "frmTransfer";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += frmTransfer_Load;
            ((System.ComponentModel.ISupportInitialize)dgrvDocument).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSoyad;
        private Label lblTaxNumber;
        private TextBox txtTaxNumber;
        private Label lblAtaAd;
        private Label lblLastPurchase;
        private DataGridView dataGridView1;
        private Label lblUnvan;
        private TextBox txtUnvan;
        private Label lblTelefon;
        private TextBox txtTelefon;
        private Label lblShirket;
        private Label lblQeyd;
        private TextBox txtQeyd;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblDocType;
        private ComboBox cmbDocType;
        private Label lblKontCode;
        private TextBox txtCompanyCode;
        private Button btnSave;
        private Button BtnCancel;
        private TextBox AccountID;

        private DataGridView dgrvXidmetler;
        private DataGridView dgrvDocument;
        private DateTimePicker dtpLastPurchaseDate;
        private TextBox txtSifarisNomresi;
        private Label label2;
        private CheckBox chkDupCustomer;
        private Label lblUserId;
        private Label lblUserName;
        private TextBox txtDocTypeId;
        private TextBox txtCompanyName;
        private Label lblCompanyName;
        private Label lblStock;
        private TextBox txtStockGroupId;
        private ListBox lstStockGroup;
        private TextBox txtStockGroup;
        private TextBox txtStockId;
        private ListBox lstStock;
        private TextBox txtStock;
        private Label lblSearchStock;
        private TextBox txtWarehouseId;
        private ComboBox cmbWarehouse;
        private Label lblSourceWarehouse;
        private DateTimePicker dtpDocDate;
        private TextBox txtTargetWarehouseId;
        private ComboBox cmbTargetWarehouse;
        private Label lblTargetWarehouse;
        private TextBox txtSourceWarehouseId;
        private ComboBox cmbSourceWarehouse;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn StockId;
        private DataGridViewTextBoxColumn StockName;
        private DataGridViewTextBoxColumn BaseUnitId;
        private DataGridViewTextBoxColumn DefaultUnit;
        private DataGridViewTextBoxColumn PurchaseUnitId;
        private DataGridViewComboBoxColumn PurchaseUnit;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn TotalQuantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn TotalAmount;
    }
}

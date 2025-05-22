namespace POS_BACK_OFFICE
{
    partial class frmSaleList
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaleList));
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            createNewSaleDoc = new Button();
            dtpDocStartDate = new DateTimePicker();
            dtpDocEndDate = new DateTimePicker();
            adDgrvDocumentDetail = new Zuby.ADGV.AdvancedDataGridView();
            DOC_NO = new DataGridViewTextBoxColumn();
            BARCODE = new DataGridViewTextBoxColumn();
            STOCK_NAME = new DataGridViewTextBoxColumn();
            BASE_UNIT_NAME = new DataGridViewTextBoxColumn();
            PURCHASE_UNIT_NAME = new DataGridViewTextBoxColumn();
            cmbPurchaseUnitName = new DataGridViewComboBoxColumn();
            QUANTITY = new DataGridViewTextBoxColumn();
            TOTAL_QUANTITY = new DataGridViewTextBoxColumn();
            DEFAULT_PRICE = new DataGridViewTextBoxColumn();
            TOTAL_AMOUNT = new DataGridViewTextBoxColumn();
            INSERT_DATE_TIME = new DataGridViewTextBoxColumn();
            DELETED = new DataGridViewCheckBoxColumn();
            STOCK_ID = new DataGridViewTextBoxColumn();
            PURCHASE_UNIT = new DataGridViewTextBoxColumn();
            BASE_UNIT = new DataGridViewTextBoxColumn();
            DETAIL_ID = new DataGridViewTextBoxColumn();
            DISCOUNT_PER_CENT = new DataGridViewTextBoxColumn();
            DISCOUNT_AMOUNT = new DataGridViewTextBoxColumn();
            btnDocEdit = new Button();
            btnDocDelete = new Button();
            btnSave = new Button();
            lblUserName = new Label();
            lblUserId = new Label();
            lblTotalAmount = new Label();
            panel1 = new Panel();
            btnSaveAsPDF = new Button();
            pictureBox1 = new PictureBox();
            txtDocTypeId = new TextBox();
            panel3 = new Panel();
            lblModulName = new Label();
            adDgrvDocumentDetailStockSum = new Zuby.ADGV.AdvancedDataGridView();
            STOCKNAME = new DataGridViewTextBoxColumn();
            BOX_COUNT = new DataGridViewTextBoxColumn();
            TOTAL = new DataGridViewTextBoxColumn();
            adDgrvDocumentList = new Zuby.ADGV.AdvancedDataGridView();
            DOCNO = new DataGridViewTextBoxColumn();
            INSERT_DATETIME = new DataGridViewTextBoxColumn();
            ACC_NAME = new DataGridViewTextBoxColumn();
            ITEM_COUNT = new DataGridViewTextBoxColumn();
            HEADER_TOTAL_AMOUNT = new DataGridViewTextBoxColumn();
            CREATED_BY = new DataGridViewTextBoxColumn();
            DOC_DATE = new DataGridViewTextBoxColumn();
            EDITED_BY = new DataGridViewTextBoxColumn();
            DOCUMENT_TYPE_NAME = new DataGridViewTextBoxColumn();
            WAREHOUSE_NAME = new DataGridViewTextBoxColumn();
            SOURCE_WAREHOUSE_NAME = new DataGridViewTextBoxColumn();
            TARGET_WAREHOUSE_NAME = new DataGridViewTextBoxColumn();
            DOCUMENT_TYPE = new DataGridViewTextBoxColumn();
            HEADER_ID = new DataGridViewTextBoxColumn();
            CUSTOMER_ID = new DataGridViewTextBoxColumn();
            OFFLINE_DOC_NO = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)adDgrvDocumentDetail).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adDgrvDocumentDetailStockSum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)adDgrvDocumentList).BeginInit();
            SuspendLayout();
            // 
            // createNewSaleDoc
            // 
            createNewSaleDoc.BackColor = Color.LimeGreen;
            createNewSaleDoc.ForeColor = Color.White;
            createNewSaleDoc.Location = new Point(27, 10);
            createNewSaleDoc.Name = "createNewSaleDoc";
            createNewSaleDoc.Size = new Size(122, 32);
            createNewSaleDoc.TabIndex = 0;
            createNewSaleDoc.Text = "YENİ SATIŞ ➕";
            createNewSaleDoc.UseVisualStyleBackColor = false;
            createNewSaleDoc.Click += createNewDoc_Click;
            // 
            // dtpDocStartDate
            // 
            dtpDocStartDate.Format = DateTimePickerFormat.Short;
            dtpDocStartDate.Location = new Point(900, 23);
            dtpDocStartDate.Name = "dtpDocStartDate";
            dtpDocStartDate.Size = new Size(108, 23);
            dtpDocStartDate.TabIndex = 93;
            dtpDocStartDate.Value = new DateTime(2025, 3, 27, 0, 0, 0, 0);
            dtpDocStartDate.ValueChanged += dtpDocStartDate_ValueChanged;
            // 
            // dtpDocEndDate
            // 
            dtpDocEndDate.Format = DateTimePickerFormat.Short;
            dtpDocEndDate.Location = new Point(1014, 23);
            dtpDocEndDate.Name = "dtpDocEndDate";
            dtpDocEndDate.Size = new Size(108, 23);
            dtpDocEndDate.TabIndex = 94;
            dtpDocEndDate.Value = new DateTime(2025, 3, 27, 0, 0, 0, 0);
            dtpDocEndDate.ValueChanged += dtpDocEndDate_ValueChanged;
            // 
            // adDgrvDocumentDetail
            // 
            adDgrvDocumentDetail.AllowUserToAddRows = false;
            adDgrvDocumentDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            adDgrvDocumentDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            adDgrvDocumentDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adDgrvDocumentDetail.Columns.AddRange(new DataGridViewColumn[] { DOC_NO, BARCODE, STOCK_NAME, BASE_UNIT_NAME, PURCHASE_UNIT_NAME, cmbPurchaseUnitName, QUANTITY, TOTAL_QUANTITY, DEFAULT_PRICE, TOTAL_AMOUNT, INSERT_DATE_TIME, DELETED, STOCK_ID, PURCHASE_UNIT, BASE_UNIT, DETAIL_ID, DISCOUNT_PER_CENT, DISCOUNT_AMOUNT });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            adDgrvDocumentDetail.DefaultCellStyle = dataGridViewCellStyle5;
            adDgrvDocumentDetail.FilterAndSortEnabled = false;
            adDgrvDocumentDetail.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            adDgrvDocumentDetail.Location = new Point(31, 411);
            adDgrvDocumentDetail.MaxFilterButtonImageHeight = 23;
            adDgrvDocumentDetail.Name = "adDgrvDocumentDetail";
            adDgrvDocumentDetail.ReadOnly = true;
            adDgrvDocumentDetail.RightToLeft = RightToLeft.No;
            adDgrvDocumentDetail.Size = new Size(1068, 364);
            adDgrvDocumentDetail.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            adDgrvDocumentDetail.TabIndex = 95;
            // 
            // DOC_NO
            // 
            DOC_NO.DataPropertyName = "DOC_NO";
            DOC_NO.FillWeight = 75F;
            DOC_NO.HeaderText = "Satış No";
            DOC_NO.MinimumWidth = 24;
            DOC_NO.Name = "DOC_NO";
            DOC_NO.ReadOnly = true;
            DOC_NO.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // BARCODE
            // 
            BARCODE.DataPropertyName = "BARCODE";
            BARCODE.HeaderText = "Barkod";
            BARCODE.MinimumWidth = 24;
            BARCODE.Name = "BARCODE";
            BARCODE.ReadOnly = true;
            BARCODE.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // STOCK_NAME
            // 
            STOCK_NAME.DataPropertyName = "STOCK_NAME";
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            STOCK_NAME.DefaultCellStyle = dataGridViewCellStyle1;
            STOCK_NAME.FillWeight = 150F;
            STOCK_NAME.HeaderText = "Çeşid";
            STOCK_NAME.MinimumWidth = 24;
            STOCK_NAME.Name = "STOCK_NAME";
            STOCK_NAME.ReadOnly = true;
            STOCK_NAME.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // BASE_UNIT_NAME
            // 
            BASE_UNIT_NAME.DataPropertyName = "BASE_UNIT_NAME";
            BASE_UNIT_NAME.FillWeight = 80F;
            BASE_UNIT_NAME.HeaderText = "Əsas Vahid";
            BASE_UNIT_NAME.MinimumWidth = 24;
            BASE_UNIT_NAME.Name = "BASE_UNIT_NAME";
            BASE_UNIT_NAME.ReadOnly = true;
            BASE_UNIT_NAME.SortMode = DataGridViewColumnSortMode.Programmatic;
            BASE_UNIT_NAME.Visible = false;
            // 
            // PURCHASE_UNIT_NAME
            // 
            PURCHASE_UNIT_NAME.DataPropertyName = "PURCHASE_UNIT_NAME";
            PURCHASE_UNIT_NAME.FillWeight = 80F;
            PURCHASE_UNIT_NAME.HeaderText = "Alış Vahidi";
            PURCHASE_UNIT_NAME.MinimumWidth = 24;
            PURCHASE_UNIT_NAME.Name = "PURCHASE_UNIT_NAME";
            PURCHASE_UNIT_NAME.ReadOnly = true;
            PURCHASE_UNIT_NAME.SortMode = DataGridViewColumnSortMode.Programmatic;
            PURCHASE_UNIT_NAME.Visible = false;
            // 
            // cmbPurchaseUnitName
            // 
            cmbPurchaseUnitName.HeaderText = "Alış Vahidi Seç";
            cmbPurchaseUnitName.MinimumWidth = 24;
            cmbPurchaseUnitName.Name = "cmbPurchaseUnitName";
            cmbPurchaseUnitName.ReadOnly = true;
            cmbPurchaseUnitName.SortMode = DataGridViewColumnSortMode.Programmatic;
            cmbPurchaseUnitName.Visible = false;
            // 
            // QUANTITY
            // 
            QUANTITY.DataPropertyName = "QUANTITY";
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            QUANTITY.DefaultCellStyle = dataGridViewCellStyle2;
            QUANTITY.FillWeight = 60F;
            QUANTITY.HeaderText = "Miqdar";
            QUANTITY.MinimumWidth = 24;
            QUANTITY.Name = "QUANTITY";
            QUANTITY.ReadOnly = true;
            QUANTITY.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // TOTAL_QUANTITY
            // 
            TOTAL_QUANTITY.DataPropertyName = "TOTAL_QUANTITY";
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            TOTAL_QUANTITY.DefaultCellStyle = dataGridViewCellStyle3;
            TOTAL_QUANTITY.FillWeight = 80F;
            TOTAL_QUANTITY.HeaderText = "CəmMiqdar";
            TOTAL_QUANTITY.MinimumWidth = 24;
            TOTAL_QUANTITY.Name = "TOTAL_QUANTITY";
            TOTAL_QUANTITY.ReadOnly = true;
            TOTAL_QUANTITY.SortMode = DataGridViewColumnSortMode.Programmatic;
            TOTAL_QUANTITY.Visible = false;
            // 
            // DEFAULT_PRICE
            // 
            DEFAULT_PRICE.DataPropertyName = "DEFAULT_PRICE";
            DEFAULT_PRICE.FillWeight = 60F;
            DEFAULT_PRICE.HeaderText = "Qiymət";
            DEFAULT_PRICE.MinimumWidth = 24;
            DEFAULT_PRICE.Name = "DEFAULT_PRICE";
            DEFAULT_PRICE.ReadOnly = true;
            DEFAULT_PRICE.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // TOTAL_AMOUNT
            // 
            TOTAL_AMOUNT.DataPropertyName = "TOTAL_AMOUNT";
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TOTAL_AMOUNT.DefaultCellStyle = dataGridViewCellStyle4;
            TOTAL_AMOUNT.HeaderText = "Ümumi Cəm";
            TOTAL_AMOUNT.MinimumWidth = 24;
            TOTAL_AMOUNT.Name = "TOTAL_AMOUNT";
            TOTAL_AMOUNT.ReadOnly = true;
            TOTAL_AMOUNT.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // INSERT_DATE_TIME
            // 
            INSERT_DATE_TIME.DataPropertyName = "INSERT_DATE_TIME";
            INSERT_DATE_TIME.HeaderText = "Qeyd Tarixi";
            INSERT_DATE_TIME.MinimumWidth = 24;
            INSERT_DATE_TIME.Name = "INSERT_DATE_TIME";
            INSERT_DATE_TIME.ReadOnly = true;
            INSERT_DATE_TIME.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // DELETED
            // 
            DELETED.DataPropertyName = "STATUS_FOR_GRID";
            DELETED.FalseValue = "false";
            DELETED.HeaderText = "SIL";
            DELETED.MinimumWidth = 24;
            DELETED.Name = "DELETED";
            DELETED.ReadOnly = true;
            DELETED.Resizable = DataGridViewTriState.True;
            DELETED.SortMode = DataGridViewColumnSortMode.Programmatic;
            DELETED.TrueValue = "true";
            // 
            // STOCK_ID
            // 
            STOCK_ID.DataPropertyName = "STOCK_ID";
            STOCK_ID.HeaderText = "STOCK_ID";
            STOCK_ID.MinimumWidth = 24;
            STOCK_ID.Name = "STOCK_ID";
            STOCK_ID.ReadOnly = true;
            STOCK_ID.SortMode = DataGridViewColumnSortMode.Programmatic;
            STOCK_ID.Visible = false;
            // 
            // PURCHASE_UNIT
            // 
            PURCHASE_UNIT.DataPropertyName = "PURCHASE_UNIT";
            PURCHASE_UNIT.HeaderText = "PURCHASE_UNIT";
            PURCHASE_UNIT.MinimumWidth = 24;
            PURCHASE_UNIT.Name = "PURCHASE_UNIT";
            PURCHASE_UNIT.ReadOnly = true;
            PURCHASE_UNIT.SortMode = DataGridViewColumnSortMode.Programmatic;
            PURCHASE_UNIT.Visible = false;
            // 
            // BASE_UNIT
            // 
            BASE_UNIT.DataPropertyName = "BASE_UNIT";
            BASE_UNIT.HeaderText = "BASE_UNIT";
            BASE_UNIT.MinimumWidth = 24;
            BASE_UNIT.Name = "BASE_UNIT";
            BASE_UNIT.ReadOnly = true;
            BASE_UNIT.SortMode = DataGridViewColumnSortMode.Programmatic;
            BASE_UNIT.Visible = false;
            // 
            // DETAIL_ID
            // 
            DETAIL_ID.DataPropertyName = "DETAIL_ID";
            DETAIL_ID.HeaderText = "DETAIL_ID";
            DETAIL_ID.MinimumWidth = 24;
            DETAIL_ID.Name = "DETAIL_ID";
            DETAIL_ID.ReadOnly = true;
            DETAIL_ID.SortMode = DataGridViewColumnSortMode.Programmatic;
            DETAIL_ID.Visible = false;
            // 
            // DISCOUNT_PER_CENT
            // 
            DISCOUNT_PER_CENT.DataPropertyName = "DISCOUNT_PER_CENT";
            DISCOUNT_PER_CENT.HeaderText = "DISCOUNT_PER_CENT";
            DISCOUNT_PER_CENT.MinimumWidth = 24;
            DISCOUNT_PER_CENT.Name = "DISCOUNT_PER_CENT";
            DISCOUNT_PER_CENT.ReadOnly = true;
            DISCOUNT_PER_CENT.SortMode = DataGridViewColumnSortMode.Programmatic;
            DISCOUNT_PER_CENT.Visible = false;
            // 
            // DISCOUNT_AMOUNT
            // 
            DISCOUNT_AMOUNT.DataPropertyName = "DISCOUNT_AMOUNT";
            DISCOUNT_AMOUNT.HeaderText = "DISCOUNT_PER_CENT";
            DISCOUNT_AMOUNT.MinimumWidth = 24;
            DISCOUNT_AMOUNT.Name = "DISCOUNT_AMOUNT";
            DISCOUNT_AMOUNT.ReadOnly = true;
            DISCOUNT_AMOUNT.SortMode = DataGridViewColumnSortMode.Programmatic;
            DISCOUNT_AMOUNT.Visible = false;
            // 
            // btnDocEdit
            // 
            btnDocEdit.BackColor = SystemColors.ActiveCaption;
            btnDocEdit.Location = new Point(155, 10);
            btnDocEdit.Name = "btnDocEdit";
            btnDocEdit.Size = new Size(122, 32);
            btnDocEdit.TabIndex = 96;
            btnDocEdit.Text = "REDAKTƏ ✏️";
            btnDocEdit.UseVisualStyleBackColor = false;
            btnDocEdit.Click += btnDocEdit_Click;
            // 
            // btnDocDelete
            // 
            btnDocDelete.BackColor = Color.Red;
            btnDocDelete.ForeColor = Color.White;
            btnDocDelete.Location = new Point(283, 11);
            btnDocDelete.Name = "btnDocDelete";
            btnDocDelete.Size = new Size(114, 32);
            btnDocDelete.TabIndex = 97;
            btnDocDelete.Text = "SİLMƏK ➖ ✖";
            btnDocDelete.UseVisualStyleBackColor = false;
            btnDocDelete.Visible = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.ForestGreen;
            btnSave.Enabled = false;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(1341, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(182, 45);
            btnSave.TabIndex = 98;
            btnSave.Text = "YADDA SAXLA ✅ 💾";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUserName.ForeColor = SystemColors.ActiveCaptionText;
            lblUserName.Location = new Point(139, 846);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(91, 21);
            lblUserName.TabIndex = 103;
            lblUserName.Text = "Username:";
            // 
            // lblUserId
            // 
            lblUserId.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUserId.AutoSize = true;
            lblUserId.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUserId.ForeColor = SystemColors.ActiveCaptionText;
            lblUserId.Location = new Point(31, 846);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(63, 21);
            lblUserId.TabIndex = 102;
            lblUserId.Text = "UserId:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(263, 38);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(80, 15);
            lblTotalAmount.TabIndex = 101;
            lblTotalAmount.Text = "Total Amount";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnSaveAsPDF);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTotalAmount);
            panel1.Location = new Point(1130, 789);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 63);
            panel1.TabIndex = 104;
            // 
            // btnSaveAsPDF
            // 
            btnSaveAsPDF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveAsPDF.Location = new Point(3, 8);
            btnSaveAsPDF.Name = "btnSaveAsPDF";
            btnSaveAsPDF.Size = new Size(103, 48);
            btnSaveAsPDF.TabIndex = 112;
            btnSaveAsPDF.Text = "PDF Export";
            btnSaveAsPDF.UseVisualStyleBackColor = true;
            btnSaveAsPDF.Click += btnSaveAsPDF_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(123, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 108;
            pictureBox1.TabStop = false;
            // 
            // txtDocTypeId
            // 
            txtDocTypeId.Location = new Point(412, 20);
            txtDocTypeId.Name = "txtDocTypeId";
            txtDocTypeId.Size = new Size(100, 23);
            txtDocTypeId.TabIndex = 105;
            txtDocTypeId.Visible = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.Controls.Add(lblModulName);
            panel3.Location = new Point(31, 799);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 45);
            panel3.TabIndex = 110;
            // 
            // lblModulName
            // 
            lblModulName.AutoSize = true;
            lblModulName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModulName.Location = new Point(10, 11);
            lblModulName.Name = "lblModulName";
            lblModulName.Size = new Size(152, 25);
            lblModulName.TabIndex = 0;
            lblModulName.Text = "SATIŞ MODULU";
            // 
            // adDgrvDocumentDetailStockSum
            // 
            adDgrvDocumentDetailStockSum.AllowUserToAddRows = false;
            adDgrvDocumentDetailStockSum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            adDgrvDocumentDetailStockSum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            adDgrvDocumentDetailStockSum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adDgrvDocumentDetailStockSum.Columns.AddRange(new DataGridViewColumn[] { STOCKNAME, BOX_COUNT, TOTAL });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            adDgrvDocumentDetailStockSum.DefaultCellStyle = dataGridViewCellStyle6;
            adDgrvDocumentDetailStockSum.FilterAndSortEnabled = false;
            adDgrvDocumentDetailStockSum.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            adDgrvDocumentDetailStockSum.Location = new Point(1130, 411);
            adDgrvDocumentDetailStockSum.MaxFilterButtonImageHeight = 23;
            adDgrvDocumentDetailStockSum.Name = "adDgrvDocumentDetailStockSum";
            adDgrvDocumentDetailStockSum.ReadOnly = true;
            adDgrvDocumentDetailStockSum.RightToLeft = RightToLeft.No;
            adDgrvDocumentDetailStockSum.Size = new Size(393, 364);
            adDgrvDocumentDetailStockSum.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            adDgrvDocumentDetailStockSum.TabIndex = 111;
            // 
            // STOCKNAME
            // 
            STOCKNAME.DataPropertyName = "STOCK_NAME";
            STOCKNAME.HeaderText = "Çeşid";
            STOCKNAME.MinimumWidth = 24;
            STOCKNAME.Name = "STOCKNAME";
            STOCKNAME.ReadOnly = true;
            STOCKNAME.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // BOX_COUNT
            // 
            BOX_COUNT.DataPropertyName = "BOX_COUNT";
            BOX_COUNT.HeaderText = "Qutu Say";
            BOX_COUNT.MinimumWidth = 24;
            BOX_COUNT.Name = "BOX_COUNT";
            BOX_COUNT.ReadOnly = true;
            BOX_COUNT.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // TOTAL
            // 
            TOTAL.DataPropertyName = "TOTAL";
            TOTAL.HeaderText = "Çəki Cəm";
            TOTAL.MinimumWidth = 24;
            TOTAL.Name = "TOTAL";
            TOTAL.ReadOnly = true;
            TOTAL.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // adDgrvDocumentList
            // 
            adDgrvDocumentList.AllowUserToAddRows = false;
            adDgrvDocumentList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            adDgrvDocumentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            adDgrvDocumentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            adDgrvDocumentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adDgrvDocumentList.Columns.AddRange(new DataGridViewColumn[] { DOCNO, INSERT_DATETIME, ACC_NAME, ITEM_COUNT, HEADER_TOTAL_AMOUNT, CREATED_BY, DOC_DATE, EDITED_BY, DOCUMENT_TYPE_NAME, WAREHOUSE_NAME, SOURCE_WAREHOUSE_NAME, TARGET_WAREHOUSE_NAME, DOCUMENT_TYPE, HEADER_ID, CUSTOMER_ID, OFFLINE_DOC_NO });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 14.25F);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            adDgrvDocumentList.DefaultCellStyle = dataGridViewCellStyle12;
            adDgrvDocumentList.FilterAndSortEnabled = false;
            adDgrvDocumentList.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            adDgrvDocumentList.Location = new Point(31, 63);
            adDgrvDocumentList.MaxFilterButtonImageHeight = 23;
            adDgrvDocumentList.Name = "adDgrvDocumentList";
            adDgrvDocumentList.RightToLeft = RightToLeft.No;
            adDgrvDocumentList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            adDgrvDocumentList.Size = new Size(1492, 303);
            adDgrvDocumentList.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            adDgrvDocumentList.TabIndex = 1;
            adDgrvDocumentList.CellClick += adDgrvDocumentList_CellClick;
            // 
            // DOCNO
            // 
            DOCNO.DataPropertyName = "DOC_NO";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DOCNO.DefaultCellStyle = dataGridViewCellStyle8;
            DOCNO.HeaderText = "Satış No";
            DOCNO.MinimumWidth = 24;
            DOCNO.Name = "DOCNO";
            DOCNO.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // INSERT_DATETIME
            // 
            INSERT_DATETIME.DataPropertyName = "INSERT_DATE_TIME";
            INSERT_DATETIME.HeaderText = "Qeyd Tarixi";
            INSERT_DATETIME.MinimumWidth = 24;
            INSERT_DATETIME.Name = "INSERT_DATETIME";
            INSERT_DATETIME.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // ACC_NAME
            // 
            ACC_NAME.DataPropertyName = "ACC_NAME";
            ACC_NAME.HeaderText = "Müştəri Adı";
            ACC_NAME.MinimumWidth = 24;
            ACC_NAME.Name = "ACC_NAME";
            ACC_NAME.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // ITEM_COUNT
            // 
            ITEM_COUNT.DataPropertyName = "ITEM_COUNT";
            ITEM_COUNT.HeaderText = "Qutu Sayı";
            ITEM_COUNT.MinimumWidth = 24;
            ITEM_COUNT.Name = "ITEM_COUNT";
            ITEM_COUNT.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // HEADER_TOTAL_AMOUNT
            // 
            HEADER_TOTAL_AMOUNT.DataPropertyName = "HEADER_TOTAL_AMOUNT";
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            HEADER_TOTAL_AMOUNT.DefaultCellStyle = dataGridViewCellStyle9;
            HEADER_TOTAL_AMOUNT.HeaderText = "Toplam Məbləğ";
            HEADER_TOTAL_AMOUNT.MinimumWidth = 24;
            HEADER_TOTAL_AMOUNT.Name = "HEADER_TOTAL_AMOUNT";
            HEADER_TOTAL_AMOUNT.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // CREATED_BY
            // 
            CREATED_BY.DataPropertyName = "CREATED_BY";
            CREATED_BY.FillWeight = 150F;
            CREATED_BY.HeaderText = "Qeyd Edən";
            CREATED_BY.MinimumWidth = 24;
            CREATED_BY.Name = "CREATED_BY";
            CREATED_BY.SortMode = DataGridViewColumnSortMode.Programmatic;
            CREATED_BY.Visible = false;
            // 
            // DOC_DATE
            // 
            DOC_DATE.DataPropertyName = "DOC_DATE";
            DOC_DATE.HeaderText = "Sənəd Tarixi";
            DOC_DATE.MinimumWidth = 24;
            DOC_DATE.Name = "DOC_DATE";
            DOC_DATE.SortMode = DataGridViewColumnSortMode.Programmatic;
            DOC_DATE.Visible = false;
            // 
            // EDITED_BY
            // 
            EDITED_BY.DataPropertyName = "EDITED_BY";
            EDITED_BY.HeaderText = "Dəyişdirən";
            EDITED_BY.MinimumWidth = 24;
            EDITED_BY.Name = "EDITED_BY";
            EDITED_BY.SortMode = DataGridViewColumnSortMode.Programmatic;
            EDITED_BY.Visible = false;
            // 
            // DOCUMENT_TYPE_NAME
            // 
            DOCUMENT_TYPE_NAME.DataPropertyName = "DOCUMENT_TYPE_NAME";
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            DOCUMENT_TYPE_NAME.DefaultCellStyle = dataGridViewCellStyle10;
            DOCUMENT_TYPE_NAME.FillWeight = 150F;
            DOCUMENT_TYPE_NAME.HeaderText = "Sənəd Növü";
            DOCUMENT_TYPE_NAME.MinimumWidth = 24;
            DOCUMENT_TYPE_NAME.Name = "DOCUMENT_TYPE_NAME";
            DOCUMENT_TYPE_NAME.SortMode = DataGridViewColumnSortMode.Programmatic;
            DOCUMENT_TYPE_NAME.Visible = false;
            // 
            // WAREHOUSE_NAME
            // 
            WAREHOUSE_NAME.DataPropertyName = "WAREHOUSE_NAME";
            WAREHOUSE_NAME.HeaderText = "Anbar Adı";
            WAREHOUSE_NAME.MinimumWidth = 24;
            WAREHOUSE_NAME.Name = "WAREHOUSE_NAME";
            WAREHOUSE_NAME.SortMode = DataGridViewColumnSortMode.Programmatic;
            WAREHOUSE_NAME.Visible = false;
            // 
            // SOURCE_WAREHOUSE_NAME
            // 
            SOURCE_WAREHOUSE_NAME.DataPropertyName = "SOURCE_WAREHOUSE_NAME";
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            SOURCE_WAREHOUSE_NAME.DefaultCellStyle = dataGridViewCellStyle11;
            SOURCE_WAREHOUSE_NAME.HeaderText = "MƏNBƏ ANBAR";
            SOURCE_WAREHOUSE_NAME.MinimumWidth = 24;
            SOURCE_WAREHOUSE_NAME.Name = "SOURCE_WAREHOUSE_NAME";
            SOURCE_WAREHOUSE_NAME.SortMode = DataGridViewColumnSortMode.Programmatic;
            SOURCE_WAREHOUSE_NAME.Visible = false;
            // 
            // TARGET_WAREHOUSE_NAME
            // 
            TARGET_WAREHOUSE_NAME.DataPropertyName = "TARGET_WAREHOUSE_NAME";
            TARGET_WAREHOUSE_NAME.HeaderText = "HƏDƏF ANBAR";
            TARGET_WAREHOUSE_NAME.MinimumWidth = 24;
            TARGET_WAREHOUSE_NAME.Name = "TARGET_WAREHOUSE_NAME";
            TARGET_WAREHOUSE_NAME.SortMode = DataGridViewColumnSortMode.Programmatic;
            TARGET_WAREHOUSE_NAME.Visible = false;
            // 
            // DOCUMENT_TYPE
            // 
            DOCUMENT_TYPE.DataPropertyName = "DOCUMENT_TYPE";
            DOCUMENT_TYPE.HeaderText = "DOCUMENT_TYPE";
            DOCUMENT_TYPE.MinimumWidth = 24;
            DOCUMENT_TYPE.Name = "DOCUMENT_TYPE";
            DOCUMENT_TYPE.SortMode = DataGridViewColumnSortMode.Programmatic;
            DOCUMENT_TYPE.Visible = false;
            // 
            // HEADER_ID
            // 
            HEADER_ID.DataPropertyName = "HEADER_ID";
            HEADER_ID.HeaderText = "HEADER_ID";
            HEADER_ID.MinimumWidth = 24;
            HEADER_ID.Name = "HEADER_ID";
            HEADER_ID.SortMode = DataGridViewColumnSortMode.Programmatic;
            HEADER_ID.Visible = false;
            // 
            // CUSTOMER_ID
            // 
            CUSTOMER_ID.DataPropertyName = "CUSTOMER_ID";
            CUSTOMER_ID.HeaderText = "CUSTOMER_ID";
            CUSTOMER_ID.MinimumWidth = 24;
            CUSTOMER_ID.Name = "CUSTOMER_ID";
            CUSTOMER_ID.SortMode = DataGridViewColumnSortMode.Programmatic;
            CUSTOMER_ID.Visible = false;
            // 
            // OFFLINE_DOC_NO
            // 
            OFFLINE_DOC_NO.DataPropertyName = "OFFLINE_DOC_NO";
            OFFLINE_DOC_NO.HeaderText = "OFFLINE_DOC_NO";
            OFFLINE_DOC_NO.MinimumWidth = 24;
            OFFLINE_DOC_NO.Name = "OFFLINE_DOC_NO";
            OFFLINE_DOC_NO.SortMode = DataGridViewColumnSortMode.Programmatic;
            OFFLINE_DOC_NO.Visible = false;
            // 
            // frmSaleList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1535, 881);
            Controls.Add(adDgrvDocumentDetailStockSum);
            Controls.Add(panel3);
            Controls.Add(txtDocTypeId);
            Controls.Add(panel1);
            Controls.Add(lblUserName);
            Controls.Add(lblUserId);
            Controls.Add(btnSave);
            Controls.Add(btnDocDelete);
            Controls.Add(btnDocEdit);
            Controls.Add(adDgrvDocumentDetail);
            Controls.Add(dtpDocEndDate);
            Controls.Add(dtpDocStartDate);
            Controls.Add(adDgrvDocumentList);
            Controls.Add(createNewSaleDoc);
            Name = "frmSaleList";
            Text = "frmSaleList";
            WindowState = FormWindowState.Maximized;
            Activated += frmSaleList_Activated;
            Load += frmSaleList_Load;
            ((System.ComponentModel.ISupportInitialize)adDgrvDocumentDetail).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)adDgrvDocumentDetailStockSum).EndInit();
            ((System.ComponentModel.ISupportInitialize)adDgrvDocumentList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createNewSaleDoc;
        private DateTimePicker dtpDocStartDate;
        private DateTimePicker dtpDocEndDate;
        private Zuby.ADGV.AdvancedDataGridView adDgrvDocumentDetail;
        private Button btnDocEdit;
        private Button btnDocDelete;
        private Button btnSave;
        private Label lblUserName;
        private Label lblUserId;
        private Label lblTotalAmount;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtDocTypeId;
        private Panel panel3;
        private Label lblModulName;
        private Zuby.ADGV.AdvancedDataGridView adDgrvDocumentDetailStockSum;
        private Button btnSaveAsPDF;
        private DataGridViewTextBoxColumn STOCKNAME;
        private DataGridViewTextBoxColumn BOX_COUNT;
        private DataGridViewTextBoxColumn TOTAL;
        private Zuby.ADGV.AdvancedDataGridView adDgrvDocumentList;
        private DataGridViewTextBoxColumn DOC_NO;
        private DataGridViewTextBoxColumn BARCODE;
        private DataGridViewTextBoxColumn STOCK_NAME;
        private DataGridViewTextBoxColumn BASE_UNIT_NAME;
        private DataGridViewTextBoxColumn PURCHASE_UNIT_NAME;
        private DataGridViewComboBoxColumn cmbPurchaseUnitName;
        private DataGridViewTextBoxColumn QUANTITY;
        private DataGridViewTextBoxColumn TOTAL_QUANTITY;
        private DataGridViewTextBoxColumn DEFAULT_PRICE;
        private DataGridViewTextBoxColumn TOTAL_AMOUNT;
        private DataGridViewTextBoxColumn INSERT_DATE_TIME;
        private DataGridViewCheckBoxColumn DELETED;
        private DataGridViewTextBoxColumn STOCK_ID;
        private DataGridViewTextBoxColumn PURCHASE_UNIT;
        private DataGridViewTextBoxColumn BASE_UNIT;
        private DataGridViewTextBoxColumn DETAIL_ID;
        private DataGridViewTextBoxColumn DISCOUNT_PER_CENT;
        private DataGridViewTextBoxColumn DISCOUNT_AMOUNT;
        private DataGridViewTextBoxColumn DOCNO;
        private DataGridViewTextBoxColumn INSERT_DATETIME;
        private DataGridViewTextBoxColumn ACC_NAME;
        private DataGridViewTextBoxColumn ITEM_COUNT;
        private DataGridViewTextBoxColumn HEADER_TOTAL_AMOUNT;
        private DataGridViewTextBoxColumn CREATED_BY;
        private DataGridViewTextBoxColumn DOC_DATE;
        private DataGridViewTextBoxColumn EDITED_BY;
        private DataGridViewTextBoxColumn DOCUMENT_TYPE_NAME;
        private DataGridViewTextBoxColumn WAREHOUSE_NAME;
        private DataGridViewTextBoxColumn SOURCE_WAREHOUSE_NAME;
        private DataGridViewTextBoxColumn TARGET_WAREHOUSE_NAME;
        private DataGridViewTextBoxColumn DOCUMENT_TYPE;
        private DataGridViewTextBoxColumn HEADER_ID;
        private DataGridViewTextBoxColumn CUSTOMER_ID;
        private DataGridViewTextBoxColumn OFFLINE_DOC_NO;
    }
}
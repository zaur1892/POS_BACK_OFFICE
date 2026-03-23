namespace POS_BACK_OFFICE
{
    partial class frmDocumentList
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocumentList));
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            createNewDoc = new Button();
            adDgrvDocumentList = new Zuby.ADGV.AdvancedDataGridView();
            DOCNO = new DataGridViewTextBoxColumn();
            INSERT_DATETIME = new DataGridViewTextBoxColumn();
            DOC_DATE = new DataGridViewTextBoxColumn();
            OFFLINE_DOC_NO = new DataGridViewTextBoxColumn();
            DOCUMENT_TYPE_NAME = new DataGridViewTextBoxColumn();
            ACC_NAME = new DataGridViewTextBoxColumn();
            ITEM_COUNT = new DataGridViewTextBoxColumn();
            HEADER_TOTAL_AMOUNT = new DataGridViewTextBoxColumn();
            CREATED_BY = new DataGridViewTextBoxColumn();
            EDITED_BY = new DataGridViewTextBoxColumn();
            WAREHOUSE_NAME = new DataGridViewTextBoxColumn();
            DOCUMENT_TYPE = new DataGridViewTextBoxColumn();
            HEADER_ID = new DataGridViewTextBoxColumn();
            CUSTOMER_ID = new DataGridViewTextBoxColumn();
            dtpDocStartDate = new DateTimePicker();
            txtDocTypeId = new TextBox();
            cmbDocType = new ComboBox();
            lblDocType = new Label();
            dtpDocEndDate = new DateTimePicker();
            adDgrvDocumentDetail = new Zuby.ADGV.AdvancedDataGridView();
            btnDocEdit = new Button();
            btnDocDelete = new Button();
            btnSave = new Button();
            lblUserName = new Label();
            lblUserId = new Label();
            lblTotalAmount = new Label();
            lblDiscount = new Label();
            lblSubtotal = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            lblModulName = new Label();
            adDgrvDocumentDetailStockSum = new Zuby.ADGV.AdvancedDataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            BOX_COUNT = new DataGridViewTextBoxColumn();
            TOTAL = new DataGridViewTextBoxColumn();
            STOCKID = new DataGridViewTextBoxColumn();
            DOC_NO = new DataGridViewTextBoxColumn();
            Barode = new DataGridViewTextBoxColumn();
            STOCK_NAME = new DataGridViewTextBoxColumn();
            BASE_UNIT_NAME = new DataGridViewTextBoxColumn();
            PURCHASE_UNIT_NAME = new DataGridViewTextBoxColumn();
            cmbPurchaseUnitName = new DataGridViewComboBoxColumn();
            QUANTITY = new DataGridViewTextBoxColumn();
            TOTAL_QUANTITY = new DataGridViewTextBoxColumn();
            DEFAULT_PRICE = new DataGridViewTextBoxColumn();
            DISCOUNT_PER_CENT = new DataGridViewTextBoxColumn();
            DISCOUNT_AMOUNT = new DataGridViewTextBoxColumn();
            TOTAL_AMOUNT = new DataGridViewTextBoxColumn();
            INSERT_DATE_TIME = new DataGridViewTextBoxColumn();
            DELETED = new DataGridViewCheckBoxColumn();
            STOCK_ID = new DataGridViewTextBoxColumn();
            PURCHASE_UNIT = new DataGridViewTextBoxColumn();
            BASE_UNIT = new DataGridViewTextBoxColumn();
            DETAIL_ID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)adDgrvDocumentList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)adDgrvDocumentDetail).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adDgrvDocumentDetailStockSum).BeginInit();
            SuspendLayout();
            // 
            // createNewDoc
            // 
            createNewDoc.BackColor = Color.Green;
            createNewDoc.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createNewDoc.ForeColor = Color.White;
            createNewDoc.Location = new Point(11, 5);
            createNewDoc.Name = "createNewDoc";
            createNewDoc.Size = new Size(123, 32);
            createNewDoc.TabIndex = 0;
            createNewDoc.Text = "YENİ SƏNƏD ➕";
            createNewDoc.UseVisualStyleBackColor = false;
            createNewDoc.Click += createNewDoc_Click;
            // 
            // adDgrvDocumentList
            // 
            adDgrvDocumentList.AllowUserToAddRows = false;
            adDgrvDocumentList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            adDgrvDocumentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            adDgrvDocumentList.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            adDgrvDocumentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            adDgrvDocumentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adDgrvDocumentList.Columns.AddRange(new DataGridViewColumn[] { DOCNO, INSERT_DATETIME, DOC_DATE, OFFLINE_DOC_NO, DOCUMENT_TYPE_NAME, ACC_NAME, ITEM_COUNT, HEADER_TOTAL_AMOUNT, CREATED_BY, EDITED_BY, WAREHOUSE_NAME, DOCUMENT_TYPE, HEADER_ID, CUSTOMER_ID });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            adDgrvDocumentList.DefaultCellStyle = dataGridViewCellStyle10;
            adDgrvDocumentList.FilterAndSortEnabled = false;
            adDgrvDocumentList.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            adDgrvDocumentList.Location = new Point(31, 63);
            adDgrvDocumentList.MaxFilterButtonImageHeight = 23;
            adDgrvDocumentList.Name = "adDgrvDocumentList";
            adDgrvDocumentList.RightToLeft = RightToLeft.No;
            adDgrvDocumentList.Size = new Size(1492, 303);
            adDgrvDocumentList.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            adDgrvDocumentList.TabIndex = 1;
            adDgrvDocumentList.VirtualMode = true;
            adDgrvDocumentList.CellClick += adDgrvDocumentList_CellClick;
            // 
            // DOCNO
            // 
            DOCNO.DataPropertyName = "DOC_NO";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            DOCNO.DefaultCellStyle = dataGridViewCellStyle2;
            DOCNO.HeaderText = "Sənəd No";
            DOCNO.MinimumWidth = 24;
            DOCNO.Name = "DOCNO";
            DOCNO.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // INSERT_DATETIME
            // 
            INSERT_DATETIME.DataPropertyName = "INSERT_DATE_TIME";
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            INSERT_DATETIME.DefaultCellStyle = dataGridViewCellStyle3;
            INSERT_DATETIME.HeaderText = "Qeyd Tarixi";
            INSERT_DATETIME.MinimumWidth = 24;
            INSERT_DATETIME.Name = "INSERT_DATETIME";
            INSERT_DATETIME.SortMode = DataGridViewColumnSortMode.Programmatic;
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
            // OFFLINE_DOC_NO
            // 
            OFFLINE_DOC_NO.DataPropertyName = "OFFLINE_DOC_NO";
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            OFFLINE_DOC_NO.DefaultCellStyle = dataGridViewCellStyle4;
            OFFLINE_DOC_NO.HeaderText = "Offline Sənəd No";
            OFFLINE_DOC_NO.MinimumWidth = 24;
            OFFLINE_DOC_NO.Name = "OFFLINE_DOC_NO";
            OFFLINE_DOC_NO.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // DOCUMENT_TYPE_NAME
            // 
            DOCUMENT_TYPE_NAME.DataPropertyName = "DOCUMENT_TYPE_NAME";
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            DOCUMENT_TYPE_NAME.DefaultCellStyle = dataGridViewCellStyle5;
            DOCUMENT_TYPE_NAME.FillWeight = 150F;
            DOCUMENT_TYPE_NAME.HeaderText = "Sənəd Növü";
            DOCUMENT_TYPE_NAME.MinimumWidth = 24;
            DOCUMENT_TYPE_NAME.Name = "DOCUMENT_TYPE_NAME";
            DOCUMENT_TYPE_NAME.SortMode = DataGridViewColumnSortMode.Programmatic;
            DOCUMENT_TYPE_NAME.Visible = false;
            // 
            // ACC_NAME
            // 
            ACC_NAME.DataPropertyName = "ACC_NAME";
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ACC_NAME.DefaultCellStyle = dataGridViewCellStyle6;
            ACC_NAME.FillWeight = 150F;
            ACC_NAME.HeaderText = "Müştəri Adı";
            ACC_NAME.MinimumWidth = 24;
            ACC_NAME.Name = "ACC_NAME";
            ACC_NAME.SortMode = DataGridViewColumnSortMode.Programmatic;
            ACC_NAME.Visible = false;
            // 
            // ITEM_COUNT
            // 
            ITEM_COUNT.DataPropertyName = "ITEM_COUNT";
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ITEM_COUNT.DefaultCellStyle = dataGridViewCellStyle7;
            ITEM_COUNT.HeaderText = "Qutu Sayı";
            ITEM_COUNT.MinimumWidth = 24;
            ITEM_COUNT.Name = "ITEM_COUNT";
            ITEM_COUNT.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // HEADER_TOTAL_AMOUNT
            // 
            HEADER_TOTAL_AMOUNT.DataPropertyName = "HEADER_TOTAL_AMOUNT";
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            HEADER_TOTAL_AMOUNT.DefaultCellStyle = dataGridViewCellStyle8;
            HEADER_TOTAL_AMOUNT.HeaderText = "Ümumi Cəm";
            HEADER_TOTAL_AMOUNT.MinimumWidth = 24;
            HEADER_TOTAL_AMOUNT.Name = "HEADER_TOTAL_AMOUNT";
            HEADER_TOTAL_AMOUNT.SortMode = DataGridViewColumnSortMode.Programmatic;
            HEADER_TOTAL_AMOUNT.Visible = false;
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
            // EDITED_BY
            // 
            EDITED_BY.DataPropertyName = "EDITED_BY";
            EDITED_BY.HeaderText = "Dəyişdirən";
            EDITED_BY.MinimumWidth = 24;
            EDITED_BY.Name = "EDITED_BY";
            EDITED_BY.SortMode = DataGridViewColumnSortMode.Programmatic;
            EDITED_BY.Visible = false;
            // 
            // WAREHOUSE_NAME
            // 
            WAREHOUSE_NAME.DataPropertyName = "WAREHOUSE_NAME";
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            WAREHOUSE_NAME.DefaultCellStyle = dataGridViewCellStyle9;
            WAREHOUSE_NAME.HeaderText = "ANBAR";
            WAREHOUSE_NAME.MinimumWidth = 24;
            WAREHOUSE_NAME.Name = "WAREHOUSE_NAME";
            WAREHOUSE_NAME.SortMode = DataGridViewColumnSortMode.Programmatic;
            WAREHOUSE_NAME.Visible = false;
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
            // txtDocTypeId
            // 
            txtDocTypeId.Enabled = false;
            txtDocTypeId.Location = new Point(795, 20);
            txtDocTypeId.Name = "txtDocTypeId";
            txtDocTypeId.Size = new Size(23, 23);
            txtDocTypeId.TabIndex = 92;
            txtDocTypeId.Visible = false;
            txtDocTypeId.TextChanged += txtDocTypeId_TextChanged;
            // 
            // cmbDocType
            // 
            cmbDocType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cmbDocType.FormattingEnabled = true;
            cmbDocType.Location = new Point(650, 19);
            cmbDocType.Name = "cmbDocType";
            cmbDocType.Size = new Size(139, 23);
            cmbDocType.TabIndex = 91;
            cmbDocType.Visible = false;
            cmbDocType.SelectedIndexChanged += cmbDocType_SelectedIndexChanged;
            // 
            // lblDocType
            // 
            lblDocType.AutoSize = true;
            lblDocType.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDocType.Location = new Point(554, 23);
            lblDocType.Name = "lblDocType";
            lblDocType.Size = new Size(90, 19);
            lblDocType.TabIndex = 90;
            lblDocType.Text = "Sənəd Növü";
            lblDocType.Visible = false;
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
            adDgrvDocumentDetail.BackgroundColor = SystemColors.ButtonFace;
            adDgrvDocumentDetail.BorderStyle = BorderStyle.Fixed3D;
            adDgrvDocumentDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adDgrvDocumentDetail.Columns.AddRange(new DataGridViewColumn[] { DOC_NO, Barode, STOCK_NAME, BASE_UNIT_NAME, PURCHASE_UNIT_NAME, cmbPurchaseUnitName, QUANTITY, TOTAL_QUANTITY, DEFAULT_PRICE, DISCOUNT_PER_CENT, DISCOUNT_AMOUNT, TOTAL_AMOUNT, INSERT_DATE_TIME, DELETED, STOCK_ID, PURCHASE_UNIT, BASE_UNIT, DETAIL_ID });
            adDgrvDocumentDetail.FilterAndSortEnabled = false;
            adDgrvDocumentDetail.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            adDgrvDocumentDetail.Location = new Point(31, 411);
            adDgrvDocumentDetail.MaxFilterButtonImageHeight = 23;
            adDgrvDocumentDetail.Name = "adDgrvDocumentDetail";
            adDgrvDocumentDetail.ReadOnly = true;
            adDgrvDocumentDetail.RightToLeft = RightToLeft.No;
            adDgrvDocumentDetail.Size = new Size(947, 364);
            adDgrvDocumentDetail.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            adDgrvDocumentDetail.TabIndex = 95;
            // 
            // btnDocEdit
            // 
            btnDocEdit.BackColor = Color.WhiteSmoke;
            btnDocEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDocEdit.Location = new Point(140, 5);
            btnDocEdit.Name = "btnDocEdit";
            btnDocEdit.Size = new Size(108, 32);
            btnDocEdit.TabIndex = 96;
            btnDocEdit.Text = "REDAKTƏ ✏️";
            btnDocEdit.UseVisualStyleBackColor = false;
            btnDocEdit.Click += btnDocEdit_Click;
            // 
            // btnDocDelete
            // 
            btnDocDelete.BackColor = Color.Red;
            btnDocDelete.ForeColor = Color.White;
            btnDocDelete.Location = new Point(254, 6);
            btnDocDelete.Name = "btnDocDelete";
            btnDocDelete.Size = new Size(108, 33);
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
            lblTotalAmount.Location = new Point(309, 41);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(80, 15);
            lblTotalAmount.TabIndex = 101;
            lblTotalAmount.Text = "Total Amount";
            // 
            // lblDiscount
            // 
            lblDiscount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(309, 24);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(54, 15);
            lblDiscount.TabIndex = 100;
            lblDiscount.Text = "Discount";
            // 
            // lblSubtotal
            // 
            lblSubtotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(309, 7);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(51, 15);
            lblSubtotal.TabIndex = 99;
            lblSubtotal.Text = "Subtotal";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lblSubtotal);
            panel1.Controls.Add(lblTotalAmount);
            panel1.Controls.Add(lblDiscount);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(998, 781);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 71);
            panel1.TabIndex = 104;
            panel1.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 107;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDocEdit);
            panel2.Controls.Add(createNewDoc);
            panel2.Controls.Add(btnDocDelete);
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(31, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(385, 45);
            panel2.TabIndex = 108;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.Controls.Add(lblModulName);
            panel3.Location = new Point(31, 790);
            panel3.Name = "panel3";
            panel3.Size = new Size(278, 53);
            panel3.TabIndex = 109;
            // 
            // lblModulName
            // 
            lblModulName.AutoSize = true;
            lblModulName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModulName.Location = new Point(11, 9);
            lblModulName.Name = "lblModulName";
            lblModulName.Size = new Size(220, 25);
            lblModulName.TabIndex = 0;
            lblModulName.Text = "ANBAR GİRİŞ MODULU";
            // 
            // adDgrvDocumentDetailStockSum
            // 
            adDgrvDocumentDetailStockSum.AllowUserToAddRows = false;
            adDgrvDocumentDetailStockSum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            adDgrvDocumentDetailStockSum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            adDgrvDocumentDetailStockSum.BackgroundColor = SystemColors.ButtonFace;
            adDgrvDocumentDetailStockSum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adDgrvDocumentDetailStockSum.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, BOX_COUNT, TOTAL, STOCKID });
            adDgrvDocumentDetailStockSum.FilterAndSortEnabled = false;
            adDgrvDocumentDetailStockSum.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            adDgrvDocumentDetailStockSum.Location = new Point(998, 411);
            adDgrvDocumentDetailStockSum.MaxFilterButtonImageHeight = 23;
            adDgrvDocumentDetailStockSum.Name = "adDgrvDocumentDetailStockSum";
            adDgrvDocumentDetailStockSum.ReadOnly = true;
            adDgrvDocumentDetailStockSum.RightToLeft = RightToLeft.No;
            adDgrvDocumentDetailStockSum.Size = new Size(525, 364);
            adDgrvDocumentDetailStockSum.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            adDgrvDocumentDetailStockSum.TabIndex = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "STOCK_NAME";
            dataGridViewCellStyle17.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle17.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewTextBoxColumn3.FillWeight = 150F;
            dataGridViewTextBoxColumn3.HeaderText = "Çeşid";
            dataGridViewTextBoxColumn3.MinimumWidth = 24;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.SortMode = DataGridViewColumnSortMode.Programmatic;
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
            dataGridViewCellStyle18.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle18.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TOTAL.DefaultCellStyle = dataGridViewCellStyle18;
            TOTAL.FillWeight = 89F;
            TOTAL.HeaderText = "Toplam Çəki";
            TOTAL.MinimumWidth = 24;
            TOTAL.Name = "TOTAL";
            TOTAL.ReadOnly = true;
            TOTAL.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // STOCKID
            // 
            STOCKID.DataPropertyName = "STOCK_ID";
            STOCKID.HeaderText = "STOCK_ID";
            STOCKID.MinimumWidth = 24;
            STOCKID.Name = "STOCKID";
            STOCKID.ReadOnly = true;
            STOCKID.SortMode = DataGridViewColumnSortMode.Programmatic;
            STOCKID.Visible = false;
            // 
            // DOC_NO
            // 
            DOC_NO.DataPropertyName = "DOC_NO";
            DOC_NO.FillWeight = 75F;
            DOC_NO.HeaderText = "Sənəd No";
            DOC_NO.MinimumWidth = 24;
            DOC_NO.Name = "DOC_NO";
            DOC_NO.ReadOnly = true;
            DOC_NO.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Barode
            // 
            Barode.DataPropertyName = "BARCODE";
            Barode.HeaderText = "Barkod";
            Barode.MinimumWidth = 24;
            Barode.Name = "Barode";
            Barode.ReadOnly = true;
            Barode.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // STOCK_NAME
            // 
            STOCK_NAME.DataPropertyName = "STOCK_NAME";
            dataGridViewCellStyle11.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            STOCK_NAME.DefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle12.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            QUANTITY.DefaultCellStyle = dataGridViewCellStyle12;
            QUANTITY.FillWeight = 60F;
            QUANTITY.HeaderText = "Çəki";
            QUANTITY.MinimumWidth = 24;
            QUANTITY.Name = "QUANTITY";
            QUANTITY.ReadOnly = true;
            QUANTITY.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // TOTAL_QUANTITY
            // 
            TOTAL_QUANTITY.DataPropertyName = "TOTAL_QUANTITY";
            dataGridViewCellStyle13.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            TOTAL_QUANTITY.DefaultCellStyle = dataGridViewCellStyle13;
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
            DEFAULT_PRICE.Visible = false;
            // 
            // DISCOUNT_PER_CENT
            // 
            DISCOUNT_PER_CENT.DataPropertyName = "DISCOUNT_PER_CENT";
            dataGridViewCellStyle14.BackColor = Color.FromArgb(192, 255, 192);
            DISCOUNT_PER_CENT.DefaultCellStyle = dataGridViewCellStyle14;
            DISCOUNT_PER_CENT.HeaderText = "End. Faiz (%)";
            DISCOUNT_PER_CENT.MinimumWidth = 24;
            DISCOUNT_PER_CENT.Name = "DISCOUNT_PER_CENT";
            DISCOUNT_PER_CENT.ReadOnly = true;
            DISCOUNT_PER_CENT.SortMode = DataGridViewColumnSortMode.Programmatic;
            DISCOUNT_PER_CENT.Visible = false;
            // 
            // DISCOUNT_AMOUNT
            // 
            DISCOUNT_AMOUNT.DataPropertyName = "DISCOUNT_AMOUNT";
            dataGridViewCellStyle15.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            DISCOUNT_AMOUNT.DefaultCellStyle = dataGridViewCellStyle15;
            DISCOUNT_AMOUNT.HeaderText = "End. Məbləğ";
            DISCOUNT_AMOUNT.MinimumWidth = 24;
            DISCOUNT_AMOUNT.Name = "DISCOUNT_AMOUNT";
            DISCOUNT_AMOUNT.ReadOnly = true;
            DISCOUNT_AMOUNT.SortMode = DataGridViewColumnSortMode.Programmatic;
            DISCOUNT_AMOUNT.Visible = false;
            // 
            // TOTAL_AMOUNT
            // 
            TOTAL_AMOUNT.DataPropertyName = "TOTAL_AMOUNT";
            dataGridViewCellStyle16.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TOTAL_AMOUNT.DefaultCellStyle = dataGridViewCellStyle16;
            TOTAL_AMOUNT.HeaderText = "Ümumi Cəm";
            TOTAL_AMOUNT.MinimumWidth = 24;
            TOTAL_AMOUNT.Name = "TOTAL_AMOUNT";
            TOTAL_AMOUNT.ReadOnly = true;
            TOTAL_AMOUNT.SortMode = DataGridViewColumnSortMode.Programmatic;
            TOTAL_AMOUNT.Visible = false;
            // 
            // INSERT_DATE_TIME
            // 
            INSERT_DATE_TIME.DataPropertyName = "INSERT_DATE_TIME";
            INSERT_DATE_TIME.HeaderText = "Qeyd Tarixi";
            INSERT_DATE_TIME.MinimumWidth = 24;
            INSERT_DATE_TIME.Name = "INSERT_DATE_TIME";
            INSERT_DATE_TIME.ReadOnly = true;
            INSERT_DATE_TIME.SortMode = DataGridViewColumnSortMode.Programmatic;
            INSERT_DATE_TIME.Visible = false;
            // 
            // DELETED
            // 
            DELETED.FalseValue = "1";
            DELETED.FillWeight = 30F;
            DELETED.HeaderText = "SIL";
            DELETED.MinimumWidth = 24;
            DELETED.Name = "DELETED";
            DELETED.ReadOnly = true;
            DELETED.Resizable = DataGridViewTriState.True;
            DELETED.SortMode = DataGridViewColumnSortMode.Programmatic;
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
            // frmDocumentList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1535, 881);
            Controls.Add(adDgrvDocumentDetailStockSum);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblUserName);
            Controls.Add(lblUserId);
            Controls.Add(btnSave);
            Controls.Add(adDgrvDocumentDetail);
            Controls.Add(dtpDocEndDate);
            Controls.Add(dtpDocStartDate);
            Controls.Add(txtDocTypeId);
            Controls.Add(cmbDocType);
            Controls.Add(lblDocType);
            Controls.Add(adDgrvDocumentList);
            Name = "frmDocumentList";
            Text = "frmDocumentList";
            WindowState = FormWindowState.Maximized;
            Activated += frmDocumentList_Activated;
            Load += frmDocumentList_Load;
            ((System.ComponentModel.ISupportInitialize)adDgrvDocumentList).EndInit();
            ((System.ComponentModel.ISupportInitialize)adDgrvDocumentDetail).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)adDgrvDocumentDetailStockSum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createNewDoc;
        private Zuby.ADGV.AdvancedDataGridView adDgrvDocumentList;
        private DateTimePicker dtpDocStartDate;
        private TextBox txtDocTypeId;
        private ComboBox cmbDocType;
        private Label lblDocType;
        private DateTimePicker dtpDocEndDate;
        private Zuby.ADGV.AdvancedDataGridView adDgrvDocumentDetail;
        private Button btnDocEdit;
        private Button btnDocDelete;
        private Button btnSave;
        private Label lblUserName;
        private Label lblUserId;
        private Label lblTotalAmount;
        private Label lblDiscount;
        private Label lblSubtotal;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Label lblModulName;
        private Zuby.ADGV.AdvancedDataGridView adDgrvDocumentDetailStockSum;
        private DataGridViewTextBoxColumn DOCNO;
        private DataGridViewTextBoxColumn INSERT_DATETIME;
        private DataGridViewTextBoxColumn DOC_DATE;
        private DataGridViewTextBoxColumn OFFLINE_DOC_NO;
        private DataGridViewTextBoxColumn DOCUMENT_TYPE_NAME;
        private DataGridViewTextBoxColumn ACC_NAME;
        private DataGridViewTextBoxColumn ITEM_COUNT;
        private DataGridViewTextBoxColumn HEADER_TOTAL_AMOUNT;
        private DataGridViewTextBoxColumn CREATED_BY;
        private DataGridViewTextBoxColumn EDITED_BY;
        private DataGridViewTextBoxColumn WAREHOUSE_NAME;
        private DataGridViewTextBoxColumn DOCUMENT_TYPE;
        private DataGridViewTextBoxColumn HEADER_ID;
        private DataGridViewTextBoxColumn CUSTOMER_ID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn BOX_COUNT;
        private DataGridViewTextBoxColumn TOTAL;
        private DataGridViewTextBoxColumn STOCKID;
        private DataGridViewTextBoxColumn DOC_NO;
        private DataGridViewTextBoxColumn Barode;
        private DataGridViewTextBoxColumn STOCK_NAME;
        private DataGridViewTextBoxColumn BASE_UNIT_NAME;
        private DataGridViewTextBoxColumn PURCHASE_UNIT_NAME;
        private DataGridViewComboBoxColumn cmbPurchaseUnitName;
        private DataGridViewTextBoxColumn QUANTITY;
        private DataGridViewTextBoxColumn TOTAL_QUANTITY;
        private DataGridViewTextBoxColumn DEFAULT_PRICE;
        private DataGridViewTextBoxColumn DISCOUNT_PER_CENT;
        private DataGridViewTextBoxColumn DISCOUNT_AMOUNT;
        private DataGridViewTextBoxColumn TOTAL_AMOUNT;
        private DataGridViewTextBoxColumn INSERT_DATE_TIME;
        private DataGridViewCheckBoxColumn DELETED;
        private DataGridViewTextBoxColumn STOCK_ID;
        private DataGridViewTextBoxColumn PURCHASE_UNIT;
        private DataGridViewTextBoxColumn BASE_UNIT;
        private DataGridViewTextBoxColumn DETAIL_ID;
    }
}
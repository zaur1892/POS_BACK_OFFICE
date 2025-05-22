namespace POS_BACK_OFFICE
{
    partial class frmTransferList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransferList));
            createNewDoc = new Button();
            adDgrvDocumentList = new Zuby.ADGV.AdvancedDataGridView();
            DOCNO = new DataGridViewTextBoxColumn();
            DOC_DATE = new DataGridViewTextBoxColumn();
            DOCUMENT_TYPE_NAME = new DataGridViewTextBoxColumn();
            ITEM_COUNT = new DataGridViewTextBoxColumn();
            HEADER_TOTAL_AMOUNT = new DataGridViewTextBoxColumn();
            INSERT_DATETIME = new DataGridViewTextBoxColumn();
            CREATED_BY = new DataGridViewTextBoxColumn();
            EDITED_BY = new DataGridViewTextBoxColumn();
            SOURCE_WAREHOUSE_NAME = new DataGridViewTextBoxColumn();
            TARGET_WAREHOUSE_NAME = new DataGridViewTextBoxColumn();
            DOCUMENT_TYPE = new DataGridViewTextBoxColumn();
            HEADER_ID = new DataGridViewTextBoxColumn();
            CUSTOMER_ID = new DataGridViewTextBoxColumn();
            dtpDocStartDate = new DateTimePicker();
            txtSourceWarehouseId = new TextBox();
            cmbSourceWarehouse = new ComboBox();
            lblSourceWarehouse = new Label();
            dtpDocEndDate = new DateTimePicker();
            adDgrvDocumentDetail = new Zuby.ADGV.AdvancedDataGridView();
            DOC_NO = new DataGridViewTextBoxColumn();
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
            btnDocEdit = new Button();
            btnDocDelete = new Button();
            btnSave = new Button();
            lblUserName = new Label();
            lblUserId = new Label();
            lblTotalAmount = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtTargetWarehouseId = new TextBox();
            cmbTargetWarehouse = new ComboBox();
            lblTargetWarehouse = new Label();
            ((System.ComponentModel.ISupportInitialize)adDgrvDocumentList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)adDgrvDocumentDetail).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // createNewDoc
            // 
            createNewDoc.BackColor = Color.LimeGreen;
            createNewDoc.ForeColor = Color.White;
            createNewDoc.Location = new Point(27, 10);
            createNewDoc.Name = "createNewDoc";
            createNewDoc.Size = new Size(122, 32);
            createNewDoc.TabIndex = 0;
            createNewDoc.Text = "YENİ TRANSFER ➕";
            createNewDoc.UseVisualStyleBackColor = false;
            createNewDoc.Click += createNewDoc_Click;
            // 
            // adDgrvDocumentList
            // 
            adDgrvDocumentList.AllowUserToAddRows = false;
            adDgrvDocumentList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            adDgrvDocumentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            adDgrvDocumentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adDgrvDocumentList.Columns.AddRange(new DataGridViewColumn[] { DOCNO, DOC_DATE, DOCUMENT_TYPE_NAME, ITEM_COUNT, HEADER_TOTAL_AMOUNT, INSERT_DATETIME, CREATED_BY, EDITED_BY, SOURCE_WAREHOUSE_NAME, TARGET_WAREHOUSE_NAME, DOCUMENT_TYPE, HEADER_ID, CUSTOMER_ID });
            adDgrvDocumentList.FilterAndSortEnabled = true;
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
            DOCNO.HeaderText = "Transfer No";
            DOCNO.MinimumWidth = 24;
            DOCNO.Name = "DOCNO";
            DOCNO.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // DOC_DATE
            // 
            DOC_DATE.DataPropertyName = "DOC_DATE";
            DOC_DATE.HeaderText = "Sənəd Tarixi";
            DOC_DATE.MinimumWidth = 24;
            DOC_DATE.Name = "DOC_DATE";
            DOC_DATE.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // DOCUMENT_TYPE_NAME
            // 
            DOCUMENT_TYPE_NAME.DataPropertyName = "DOCUMENT_TYPE_NAME";
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            DOCUMENT_TYPE_NAME.DefaultCellStyle = dataGridViewCellStyle1;
            DOCUMENT_TYPE_NAME.FillWeight = 150F;
            DOCUMENT_TYPE_NAME.HeaderText = "Sənəd Növü";
            DOCUMENT_TYPE_NAME.MinimumWidth = 24;
            DOCUMENT_TYPE_NAME.Name = "DOCUMENT_TYPE_NAME";
            DOCUMENT_TYPE_NAME.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // ITEM_COUNT
            // 
            ITEM_COUNT.DataPropertyName = "ITEM_COUNT";
            ITEM_COUNT.HeaderText = "Mal Sayı";
            ITEM_COUNT.MinimumWidth = 24;
            ITEM_COUNT.Name = "ITEM_COUNT";
            ITEM_COUNT.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // HEADER_TOTAL_AMOUNT
            // 
            HEADER_TOTAL_AMOUNT.DataPropertyName = "HEADER_TOTAL_AMOUNT";
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            HEADER_TOTAL_AMOUNT.DefaultCellStyle = dataGridViewCellStyle2;
            HEADER_TOTAL_AMOUNT.HeaderText = "Ümumi Cəm";
            HEADER_TOTAL_AMOUNT.MinimumWidth = 24;
            HEADER_TOTAL_AMOUNT.Name = "HEADER_TOTAL_AMOUNT";
            HEADER_TOTAL_AMOUNT.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // INSERT_DATETIME
            // 
            INSERT_DATETIME.DataPropertyName = "INSERT_DATE_TIME";
            INSERT_DATETIME.HeaderText = "Qeyd Tarixi";
            INSERT_DATETIME.MinimumWidth = 24;
            INSERT_DATETIME.Name = "INSERT_DATETIME";
            INSERT_DATETIME.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // CREATED_BY
            // 
            CREATED_BY.DataPropertyName = "CREATED_BY";
            CREATED_BY.FillWeight = 150F;
            CREATED_BY.HeaderText = "Qeyd Edən";
            CREATED_BY.MinimumWidth = 24;
            CREATED_BY.Name = "CREATED_BY";
            CREATED_BY.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // EDITED_BY
            // 
            EDITED_BY.DataPropertyName = "EDITED_BY";
            EDITED_BY.HeaderText = "Dəyişdirən";
            EDITED_BY.MinimumWidth = 24;
            EDITED_BY.Name = "EDITED_BY";
            EDITED_BY.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // SOURCE_WAREHOUSE_NAME
            // 
            SOURCE_WAREHOUSE_NAME.DataPropertyName = "SOURCE_WAREHOUSE_NAME";
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            SOURCE_WAREHOUSE_NAME.DefaultCellStyle = dataGridViewCellStyle3;
            SOURCE_WAREHOUSE_NAME.HeaderText = "MƏNBƏ ANBAR";
            SOURCE_WAREHOUSE_NAME.MinimumWidth = 24;
            SOURCE_WAREHOUSE_NAME.Name = "SOURCE_WAREHOUSE_NAME";
            SOURCE_WAREHOUSE_NAME.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // TARGET_WAREHOUSE_NAME
            // 
            TARGET_WAREHOUSE_NAME.DataPropertyName = "TARGET_WAREHOUSE_NAME";
            TARGET_WAREHOUSE_NAME.HeaderText = "HƏDƏF ANBAR";
            TARGET_WAREHOUSE_NAME.MinimumWidth = 24;
            TARGET_WAREHOUSE_NAME.Name = "TARGET_WAREHOUSE_NAME";
            TARGET_WAREHOUSE_NAME.SortMode = DataGridViewColumnSortMode.Programmatic;
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
            // txtSourceWarehouseId
            // 
            txtSourceWarehouseId.Enabled = false;
            txtSourceWarehouseId.Location = new Point(800, 8);
            txtSourceWarehouseId.Name = "txtSourceWarehouseId";
            txtSourceWarehouseId.Size = new Size(23, 23);
            txtSourceWarehouseId.TabIndex = 92;
            txtSourceWarehouseId.TextChanged += txtDocTypeId_TextChanged;
            // 
            // cmbSourceWarehouse
            // 
            cmbSourceWarehouse.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cmbSourceWarehouse.FormattingEnabled = true;
            cmbSourceWarehouse.Location = new Point(655, 7);
            cmbSourceWarehouse.Name = "cmbSourceWarehouse";
            cmbSourceWarehouse.Size = new Size(139, 23);
            cmbSourceWarehouse.TabIndex = 91;
            // 
            // lblSourceWarehouse
            // 
            lblSourceWarehouse.AutoSize = true;
            lblSourceWarehouse.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSourceWarehouse.Location = new Point(559, 9);
            lblSourceWarehouse.Name = "lblSourceWarehouse";
            lblSourceWarehouse.Size = new Size(95, 19);
            lblSourceWarehouse.TabIndex = 90;
            lblSourceWarehouse.Text = "Mənbə Depo";
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
            adDgrvDocumentDetail.Columns.AddRange(new DataGridViewColumn[] { DOC_NO, STOCK_NAME, BASE_UNIT_NAME, PURCHASE_UNIT_NAME, cmbPurchaseUnitName, QUANTITY, TOTAL_QUANTITY, DEFAULT_PRICE, TOTAL_AMOUNT, INSERT_DATE_TIME, DELETED, STOCK_ID, PURCHASE_UNIT, BASE_UNIT, DETAIL_ID });
            adDgrvDocumentDetail.FilterAndSortEnabled = true;
            adDgrvDocumentDetail.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            adDgrvDocumentDetail.Location = new Point(31, 411);
            adDgrvDocumentDetail.MaxFilterButtonImageHeight = 23;
            adDgrvDocumentDetail.Name = "adDgrvDocumentDetail";
            adDgrvDocumentDetail.RightToLeft = RightToLeft.No;
            adDgrvDocumentDetail.Size = new Size(1492, 364);
            adDgrvDocumentDetail.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            adDgrvDocumentDetail.TabIndex = 95;
            // 
            // DOC_NO
            // 
            DOC_NO.DataPropertyName = "DOC_NO";
            DOC_NO.FillWeight = 75F;
            DOC_NO.HeaderText = "Transfer No";
            DOC_NO.MinimumWidth = 24;
            DOC_NO.Name = "DOC_NO";
            DOC_NO.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // STOCK_NAME
            // 
            STOCK_NAME.DataPropertyName = "STOCK_NAME";
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            STOCK_NAME.DefaultCellStyle = dataGridViewCellStyle4;
            STOCK_NAME.FillWeight = 150F;
            STOCK_NAME.HeaderText = "Stok Adı";
            STOCK_NAME.MinimumWidth = 24;
            STOCK_NAME.Name = "STOCK_NAME";
            STOCK_NAME.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // BASE_UNIT_NAME
            // 
            BASE_UNIT_NAME.DataPropertyName = "BASE_UNIT_NAME";
            BASE_UNIT_NAME.FillWeight = 80F;
            BASE_UNIT_NAME.HeaderText = "Əsas Vahid";
            BASE_UNIT_NAME.MinimumWidth = 24;
            BASE_UNIT_NAME.Name = "BASE_UNIT_NAME";
            BASE_UNIT_NAME.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // PURCHASE_UNIT_NAME
            // 
            PURCHASE_UNIT_NAME.DataPropertyName = "PURCHASE_UNIT_NAME";
            PURCHASE_UNIT_NAME.FillWeight = 80F;
            PURCHASE_UNIT_NAME.HeaderText = "Alış Vahidi";
            PURCHASE_UNIT_NAME.MinimumWidth = 24;
            PURCHASE_UNIT_NAME.Name = "PURCHASE_UNIT_NAME";
            PURCHASE_UNIT_NAME.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // cmbPurchaseUnitName
            // 
            cmbPurchaseUnitName.HeaderText = "Alış Vahidi Seç";
            cmbPurchaseUnitName.MinimumWidth = 24;
            cmbPurchaseUnitName.Name = "cmbPurchaseUnitName";
            cmbPurchaseUnitName.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // QUANTITY
            // 
            QUANTITY.DataPropertyName = "QUANTITY";
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            QUANTITY.DefaultCellStyle = dataGridViewCellStyle5;
            QUANTITY.FillWeight = 60F;
            QUANTITY.HeaderText = "Miqdar";
            QUANTITY.MinimumWidth = 24;
            QUANTITY.Name = "QUANTITY";
            QUANTITY.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // TOTAL_QUANTITY
            // 
            TOTAL_QUANTITY.DataPropertyName = "TOTAL_QUANTITY";
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            TOTAL_QUANTITY.DefaultCellStyle = dataGridViewCellStyle6;
            TOTAL_QUANTITY.FillWeight = 80F;
            TOTAL_QUANTITY.HeaderText = "CəmMiqdar";
            TOTAL_QUANTITY.MinimumWidth = 24;
            TOTAL_QUANTITY.Name = "TOTAL_QUANTITY";
            TOTAL_QUANTITY.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // DEFAULT_PRICE
            // 
            DEFAULT_PRICE.DataPropertyName = "DEFAULT_PRICE";
            DEFAULT_PRICE.FillWeight = 60F;
            DEFAULT_PRICE.HeaderText = "Qiymət";
            DEFAULT_PRICE.MinimumWidth = 24;
            DEFAULT_PRICE.Name = "DEFAULT_PRICE";
            DEFAULT_PRICE.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // TOTAL_AMOUNT
            // 
            TOTAL_AMOUNT.DataPropertyName = "TOTAL_AMOUNT";
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TOTAL_AMOUNT.DefaultCellStyle = dataGridViewCellStyle7;
            TOTAL_AMOUNT.HeaderText = "Ümumi Cəm";
            TOTAL_AMOUNT.MinimumWidth = 24;
            TOTAL_AMOUNT.Name = "TOTAL_AMOUNT";
            TOTAL_AMOUNT.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // INSERT_DATE_TIME
            // 
            INSERT_DATE_TIME.DataPropertyName = "INSERT_DATE_TIME";
            INSERT_DATE_TIME.HeaderText = "Qeyd Tarixi";
            INSERT_DATE_TIME.MinimumWidth = 24;
            INSERT_DATE_TIME.Name = "INSERT_DATE_TIME";
            INSERT_DATE_TIME.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // DELETED
            // 
            DELETED.HeaderText = "SIL";
            DELETED.MinimumWidth = 24;
            DELETED.Name = "DELETED";
            DELETED.Resizable = DataGridViewTriState.True;
            DELETED.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // STOCK_ID
            // 
            STOCK_ID.DataPropertyName = "STOCK_ID";
            STOCK_ID.HeaderText = "STOCK_ID";
            STOCK_ID.MinimumWidth = 24;
            STOCK_ID.Name = "STOCK_ID";
            STOCK_ID.SortMode = DataGridViewColumnSortMode.Programmatic;
            STOCK_ID.Visible = false;
            // 
            // PURCHASE_UNIT
            // 
            PURCHASE_UNIT.DataPropertyName = "PURCHASE_UNIT";
            PURCHASE_UNIT.HeaderText = "PURCHASE_UNIT";
            PURCHASE_UNIT.MinimumWidth = 24;
            PURCHASE_UNIT.Name = "PURCHASE_UNIT";
            PURCHASE_UNIT.SortMode = DataGridViewColumnSortMode.Programmatic;
            PURCHASE_UNIT.Visible = false;
            // 
            // BASE_UNIT
            // 
            BASE_UNIT.DataPropertyName = "BASE_UNIT";
            BASE_UNIT.HeaderText = "BASE_UNIT";
            BASE_UNIT.MinimumWidth = 24;
            BASE_UNIT.Name = "BASE_UNIT";
            BASE_UNIT.SortMode = DataGridViewColumnSortMode.Programmatic;
            BASE_UNIT.Visible = false;
            // 
            // DETAIL_ID
            // 
            DETAIL_ID.DataPropertyName = "DETAIL_ID";
            DETAIL_ID.HeaderText = "DETAIL_ID";
            DETAIL_ID.MinimumWidth = 24;
            DETAIL_ID.Name = "DETAIL_ID";
            DETAIL_ID.SortMode = DataGridViewColumnSortMode.Programmatic;
            DETAIL_ID.Visible = false;
            // 
            // btnDocEdit
            // 
            btnDocEdit.BackColor = SystemColors.ActiveCaption;
            btnDocEdit.Location = new Point(155, 10);
            btnDocEdit.Name = "btnDocEdit";
            btnDocEdit.Size = new Size(122, 32);
            btnDocEdit.TabIndex = 96;
            btnDocEdit.Text = "DÜZƏLİŞ ✏️";
            btnDocEdit.UseVisualStyleBackColor = false;
            btnDocEdit.Click += btnDocEdit_Click;
            // 
            // btnDocDelete
            // 
            btnDocDelete.BackColor = Color.Red;
            btnDocDelete.ForeColor = Color.White;
            btnDocDelete.Location = new Point(283, 10);
            btnDocDelete.Name = "btnDocDelete";
            btnDocDelete.Size = new Size(114, 32);
            btnDocDelete.TabIndex = 97;
            btnDocDelete.Text = "SİLMƏK ➖ ✖";
            btnDocDelete.UseVisualStyleBackColor = false;
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
            lblTotalAmount.Location = new Point(80, 33);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(80, 15);
            lblTotalAmount.TabIndex = 101;
            lblTotalAmount.Text = "Total Amount";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTotalAmount);
            panel1.Location = new Point(1227, 789);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 63);
            panel1.TabIndex = 104;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 108;
            pictureBox1.TabStop = false;
            // 
            // txtTargetWarehouseId
            // 
            txtTargetWarehouseId.Enabled = false;
            txtTargetWarehouseId.Location = new Point(800, 32);
            txtTargetWarehouseId.Name = "txtTargetWarehouseId";
            txtTargetWarehouseId.Size = new Size(23, 23);
            txtTargetWarehouseId.TabIndex = 107;
            // 
            // cmbTargetWarehouse
            // 
            cmbTargetWarehouse.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cmbTargetWarehouse.FormattingEnabled = true;
            cmbTargetWarehouse.Location = new Point(655, 31);
            cmbTargetWarehouse.Name = "cmbTargetWarehouse";
            cmbTargetWarehouse.Size = new Size(139, 23);
            cmbTargetWarehouse.TabIndex = 106;
            // 
            // lblTargetWarehouse
            // 
            lblTargetWarehouse.AutoSize = true;
            lblTargetWarehouse.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTargetWarehouse.Location = new Point(559, 33);
            lblTargetWarehouse.Name = "lblTargetWarehouse";
            lblTargetWarehouse.Size = new Size(90, 19);
            lblTargetWarehouse.TabIndex = 105;
            lblTargetWarehouse.Text = "Hədəf Depo";
            // 
            // frmTransferList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1535, 881);
            Controls.Add(txtTargetWarehouseId);
            Controls.Add(cmbTargetWarehouse);
            Controls.Add(lblTargetWarehouse);
            Controls.Add(panel1);
            Controls.Add(lblUserName);
            Controls.Add(lblUserId);
            Controls.Add(btnSave);
            Controls.Add(btnDocDelete);
            Controls.Add(btnDocEdit);
            Controls.Add(adDgrvDocumentDetail);
            Controls.Add(dtpDocEndDate);
            Controls.Add(dtpDocStartDate);
            Controls.Add(txtSourceWarehouseId);
            Controls.Add(cmbSourceWarehouse);
            Controls.Add(lblSourceWarehouse);
            Controls.Add(adDgrvDocumentList);
            Controls.Add(createNewDoc);
            Name = "frmTransferList";
            Text = "frmTransferList";
            WindowState = FormWindowState.Maximized;
            Load += frmTransferList_Load;
            ((System.ComponentModel.ISupportInitialize)adDgrvDocumentList).EndInit();
            ((System.ComponentModel.ISupportInitialize)adDgrvDocumentDetail).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createNewDoc;
        private Zuby.ADGV.AdvancedDataGridView adDgrvDocumentList;
        private DateTimePicker dtpDocStartDate;
        private TextBox txtSourceWarehouseId;
        private ComboBox cmbSourceWarehouse;
        private Label lblSourceWarehouse;
        private DateTimePicker dtpDocEndDate;
        private Zuby.ADGV.AdvancedDataGridView adDgrvDocumentDetail;
        private Button btnDocEdit;
        private Button btnDocDelete;
        private Button btnSave;
        private Label lblUserName;
        private Label lblUserId;
        private Label lblTotalAmount;
        private Panel panel1;
        private TextBox txtTargetWarehouseId;
        private ComboBox cmbTargetWarehouse;
        private Label lblTargetWarehouse;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn DOC_NO;
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
        private DataGridViewTextBoxColumn DOCNO;
        private DataGridViewTextBoxColumn DOC_DATE;
        private DataGridViewTextBoxColumn DOCUMENT_TYPE_NAME;
        private DataGridViewTextBoxColumn ITEM_COUNT;
        private DataGridViewTextBoxColumn HEADER_TOTAL_AMOUNT;
        private DataGridViewTextBoxColumn INSERT_DATETIME;
        private DataGridViewTextBoxColumn CREATED_BY;
        private DataGridViewTextBoxColumn EDITED_BY;
        private DataGridViewTextBoxColumn SOURCE_WAREHOUSE_NAME;
        private DataGridViewTextBoxColumn TARGET_WAREHOUSE_NAME;
        private DataGridViewTextBoxColumn DOCUMENT_TYPE;
        private DataGridViewTextBoxColumn HEADER_ID;
        private DataGridViewTextBoxColumn CUSTOMER_ID;
    }
}
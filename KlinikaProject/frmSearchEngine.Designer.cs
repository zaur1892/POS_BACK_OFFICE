namespace POS_BACK_OFFICE
{
    partial class frmSearchEngine
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
            dtpDocStartDate = new DateTimePicker();
            dtpDocEndDate = new DateTimePicker();
            adDgrvSearchEngineDetail = new Zuby.ADGV.AdvancedDataGridView();
            DOC_DATE = new DataGridViewTextBoxColumn();
            DOC_NO = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            TYPE_NAME = new DataGridViewTextBoxColumn();
            STOCK_NAME = new DataGridViewTextBoxColumn();
            QUANTITY = new DataGridViewTextBoxColumn();
            TOTAL_AMOUNT = new DataGridViewTextBoxColumn();
            DEFAULT_PRICE = new DataGridViewTextBoxColumn();
            TOTAL_QUANTITY = new DataGridViewTextBoxColumn();
            BASE_UNIT_NAME = new DataGridViewTextBoxColumn();
            DISCOUNT_PER_CENT = new DataGridViewTextBoxColumn();
            DISCOUNT_AMOUNT = new DataGridViewTextBoxColumn();
            INSERT_DATE_TIME = new DataGridViewTextBoxColumn();
            PURCHASE_UNIT_NAME = new DataGridViewTextBoxColumn();
            STOCK_ID = new DataGridViewTextBoxColumn();
            PURCHASE_UNIT = new DataGridViewTextBoxColumn();
            BASE_UNIT = new DataGridViewTextBoxColumn();
            DETAIL_ID = new DataGridViewTextBoxColumn();
            ACCOUNT_ID = new DataGridViewTextBoxColumn();
            DOCUMENT_TYPE = new DataGridViewTextBoxColumn();
            lblUserName = new Label();
            lblUserId = new Label();
            lblDocType = new Label();
            txtDocNo = new TextBox();
            label2 = new Label();
            txtStockId = new TextBox();
            lstStock = new ListBox();
            txtStock = new TextBox();
            label1 = new Label();
            txtCustomerID = new TextBox();
            lstCustomer = new ListBox();
            txtCustomer = new TextBox();
            lbDocNo = new Label();
            txtDocTypeId = new TextBox();
            lstDocType = new ListBox();
            txtDocType = new TextBox();
            label3 = new Label();
            btnUpdate = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)adDgrvSearchEngineDetail).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dtpDocStartDate
            // 
            dtpDocStartDate.CalendarFont = new Font("Segoe UI", 12F);
            dtpDocStartDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDocStartDate.Format = DateTimePickerFormat.Short;
            dtpDocStartDate.Location = new Point(161, 17);
            dtpDocStartDate.Name = "dtpDocStartDate";
            dtpDocStartDate.Size = new Size(108, 29);
            dtpDocStartDate.TabIndex = 93;
            dtpDocStartDate.Value = new DateTime(2025, 3, 27, 0, 0, 0, 0);
            dtpDocStartDate.ValueChanged += dtpDocStartDate_ValueChanged;
            // 
            // dtpDocEndDate
            // 
            dtpDocEndDate.CalendarFont = new Font("Segoe UI", 12F);
            dtpDocEndDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDocEndDate.Format = DateTimePickerFormat.Short;
            dtpDocEndDate.Location = new Point(275, 17);
            dtpDocEndDate.Name = "dtpDocEndDate";
            dtpDocEndDate.Size = new Size(106, 29);
            dtpDocEndDate.TabIndex = 94;
            dtpDocEndDate.Value = new DateTime(2025, 3, 27, 0, 0, 0, 0);
            dtpDocEndDate.ValueChanged += dtpDocEndDate_ValueChanged;
            // 
            // adDgrvSearchEngineDetail
            // 
            adDgrvSearchEngineDetail.AllowUserToAddRows = false;
            adDgrvSearchEngineDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            adDgrvSearchEngineDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            adDgrvSearchEngineDetail.BackgroundColor = SystemColors.ButtonFace;
            adDgrvSearchEngineDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adDgrvSearchEngineDetail.Columns.AddRange(new DataGridViewColumn[] { DOC_DATE, DOC_NO, Customer, TYPE_NAME, STOCK_NAME, QUANTITY, TOTAL_AMOUNT, DEFAULT_PRICE, TOTAL_QUANTITY, BASE_UNIT_NAME, DISCOUNT_PER_CENT, DISCOUNT_AMOUNT, INSERT_DATE_TIME, PURCHASE_UNIT_NAME, STOCK_ID, PURCHASE_UNIT, BASE_UNIT, DETAIL_ID, ACCOUNT_ID, DOCUMENT_TYPE });
            adDgrvSearchEngineDetail.FilterAndSortEnabled = true;
            adDgrvSearchEngineDetail.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            adDgrvSearchEngineDetail.Location = new Point(30, 136);
            adDgrvSearchEngineDetail.MaxFilterButtonImageHeight = 23;
            adDgrvSearchEngineDetail.Name = "adDgrvSearchEngineDetail";
            adDgrvSearchEngineDetail.RightToLeft = RightToLeft.No;
            adDgrvSearchEngineDetail.Size = new Size(1782, 670);
            adDgrvSearchEngineDetail.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            adDgrvSearchEngineDetail.TabIndex = 95;
            // 
            // DOC_DATE
            // 
            DOC_DATE.DataPropertyName = "DOC_DATE";
            DOC_DATE.HeaderText = "Sənəd Tarixi";
            DOC_DATE.MinimumWidth = 24;
            DOC_DATE.Name = "DOC_DATE";
            DOC_DATE.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // DOC_NO
            // 
            DOC_NO.DataPropertyName = "DOC_NO";
            DOC_NO.FillWeight = 75F;
            DOC_NO.HeaderText = "Sənəd No";
            DOC_NO.MinimumWidth = 24;
            DOC_NO.Name = "DOC_NO";
            DOC_NO.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Customer
            // 
            Customer.DataPropertyName = "ACC_NAME";
            Customer.HeaderText = "Müştəri";
            Customer.MinimumWidth = 24;
            Customer.Name = "Customer";
            Customer.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // TYPE_NAME
            // 
            TYPE_NAME.DataPropertyName = "TYPE_NAME";
            TYPE_NAME.HeaderText = "Sənəd Növü";
            TYPE_NAME.MinimumWidth = 24;
            TYPE_NAME.Name = "TYPE_NAME";
            TYPE_NAME.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // STOCK_NAME
            // 
            STOCK_NAME.DataPropertyName = "STOCK_NAME";
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            STOCK_NAME.DefaultCellStyle = dataGridViewCellStyle1;
            STOCK_NAME.FillWeight = 150F;
            STOCK_NAME.HeaderText = "Stok Adı";
            STOCK_NAME.MinimumWidth = 24;
            STOCK_NAME.Name = "STOCK_NAME";
            STOCK_NAME.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // QUANTITY
            // 
            QUANTITY.DataPropertyName = "QUANTITY";
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            QUANTITY.DefaultCellStyle = dataGridViewCellStyle2;
            QUANTITY.FillWeight = 60F;
            QUANTITY.HeaderText = "Çəki";
            QUANTITY.MinimumWidth = 24;
            QUANTITY.Name = "QUANTITY";
            QUANTITY.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // TOTAL_AMOUNT
            // 
            TOTAL_AMOUNT.DataPropertyName = "TOTAL_AMOUNT";
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TOTAL_AMOUNT.DefaultCellStyle = dataGridViewCellStyle3;
            TOTAL_AMOUNT.HeaderText = "Toplam AZN";
            TOTAL_AMOUNT.MinimumWidth = 24;
            TOTAL_AMOUNT.Name = "TOTAL_AMOUNT";
            TOTAL_AMOUNT.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // DEFAULT_PRICE
            // 
            DEFAULT_PRICE.DataPropertyName = "DEFAULT_PRICE";
            DEFAULT_PRICE.FillWeight = 60F;
            DEFAULT_PRICE.HeaderText = "Qiymət";
            DEFAULT_PRICE.MinimumWidth = 24;
            DEFAULT_PRICE.Name = "DEFAULT_PRICE";
            DEFAULT_PRICE.SortMode = DataGridViewColumnSortMode.Programmatic;
            DEFAULT_PRICE.Visible = false;
            // 
            // TOTAL_QUANTITY
            // 
            TOTAL_QUANTITY.DataPropertyName = "TOTAL_QUANTITY";
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            TOTAL_QUANTITY.DefaultCellStyle = dataGridViewCellStyle4;
            TOTAL_QUANTITY.FillWeight = 80F;
            TOTAL_QUANTITY.HeaderText = "Cəm Miqdar";
            TOTAL_QUANTITY.MinimumWidth = 24;
            TOTAL_QUANTITY.Name = "TOTAL_QUANTITY";
            TOTAL_QUANTITY.SortMode = DataGridViewColumnSortMode.Programmatic;
            TOTAL_QUANTITY.Visible = false;
            // 
            // BASE_UNIT_NAME
            // 
            BASE_UNIT_NAME.DataPropertyName = "BASE_UNIT_NAME";
            BASE_UNIT_NAME.FillWeight = 80F;
            BASE_UNIT_NAME.HeaderText = "Əsas Vahid";
            BASE_UNIT_NAME.MinimumWidth = 24;
            BASE_UNIT_NAME.Name = "BASE_UNIT_NAME";
            BASE_UNIT_NAME.SortMode = DataGridViewColumnSortMode.Programmatic;
            BASE_UNIT_NAME.Visible = false;
            // 
            // DISCOUNT_PER_CENT
            // 
            DISCOUNT_PER_CENT.DataPropertyName = "DISCOUNT_PER_CENT";
            dataGridViewCellStyle5.BackColor = Color.FromArgb(192, 255, 192);
            DISCOUNT_PER_CENT.DefaultCellStyle = dataGridViewCellStyle5;
            DISCOUNT_PER_CENT.HeaderText = "End. Faiz (%)";
            DISCOUNT_PER_CENT.MinimumWidth = 24;
            DISCOUNT_PER_CENT.Name = "DISCOUNT_PER_CENT";
            DISCOUNT_PER_CENT.SortMode = DataGridViewColumnSortMode.Programmatic;
            DISCOUNT_PER_CENT.Visible = false;
            // 
            // DISCOUNT_AMOUNT
            // 
            DISCOUNT_AMOUNT.DataPropertyName = "DISCOUNT_AMOUNT";
            dataGridViewCellStyle6.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            DISCOUNT_AMOUNT.DefaultCellStyle = dataGridViewCellStyle6;
            DISCOUNT_AMOUNT.HeaderText = "End. Məbləğ";
            DISCOUNT_AMOUNT.MinimumWidth = 24;
            DISCOUNT_AMOUNT.Name = "DISCOUNT_AMOUNT";
            DISCOUNT_AMOUNT.SortMode = DataGridViewColumnSortMode.Programmatic;
            DISCOUNT_AMOUNT.Visible = false;
            // 
            // INSERT_DATE_TIME
            // 
            INSERT_DATE_TIME.DataPropertyName = "INSERT_DATE_TIME";
            INSERT_DATE_TIME.HeaderText = "Qeyd Tarixi";
            INSERT_DATE_TIME.MinimumWidth = 24;
            INSERT_DATE_TIME.Name = "INSERT_DATE_TIME";
            INSERT_DATE_TIME.SortMode = DataGridViewColumnSortMode.Programmatic;
            INSERT_DATE_TIME.Visible = false;
            // 
            // PURCHASE_UNIT_NAME
            // 
            PURCHASE_UNIT_NAME.DataPropertyName = "PURCHASE_UNIT_NAME";
            PURCHASE_UNIT_NAME.FillWeight = 80F;
            PURCHASE_UNIT_NAME.HeaderText = "Alış Vahidi";
            PURCHASE_UNIT_NAME.MinimumWidth = 24;
            PURCHASE_UNIT_NAME.Name = "PURCHASE_UNIT_NAME";
            PURCHASE_UNIT_NAME.SortMode = DataGridViewColumnSortMode.Programmatic;
            PURCHASE_UNIT_NAME.Visible = false;
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
            // ACCOUNT_ID
            // 
            ACCOUNT_ID.DataPropertyName = "ACCOUNT_ID";
            ACCOUNT_ID.HeaderText = "ACCOUNT_ID";
            ACCOUNT_ID.MinimumWidth = 24;
            ACCOUNT_ID.Name = "ACCOUNT_ID";
            ACCOUNT_ID.SortMode = DataGridViewColumnSortMode.Programmatic;
            ACCOUNT_ID.Visible = false;
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
            // lblDocType
            // 
            lblDocType.AutoSize = true;
            lblDocType.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDocType.Location = new Point(589, 10);
            lblDocType.Name = "lblDocType";
            lblDocType.Size = new Size(94, 19);
            lblDocType.TabIndex = 108;
            lblDocType.Text = "Sənəd Növü:";
            // 
            // txtDocNo
            // 
            txtDocNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDocNo.Location = new Point(508, 20);
            txtDocNo.Name = "txtDocNo";
            txtDocNo.Size = new Size(76, 29);
            txtDocNo.TabIndex = 111;
            txtDocNo.TextChanged += txtDocNo_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(294, 10);
            label2.Name = "label2";
            label2.Size = new Size(91, 17);
            label2.TabIndex = 116;
            label2.Text = "STOK AXTAR:";
            // 
            // txtStockId
            // 
            txtStockId.Enabled = false;
            txtStockId.Font = new Font("Segoe UI", 8.25F);
            txtStockId.Location = new Point(529, 31);
            txtStockId.Name = "txtStockId";
            txtStockId.Size = new Size(17, 22);
            txtStockId.TabIndex = 115;
            // 
            // lstStock
            // 
            lstStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstStock.FormattingEnabled = true;
            lstStock.ItemHeight = 21;
            lstStock.Location = new Point(294, 62);
            lstStock.Name = "lstStock";
            lstStock.Size = new Size(229, 46);
            lstStock.TabIndex = 114;
            lstStock.Visible = false;
            lstStock.Click += lstStock_Click;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStock.Location = new Point(294, 30);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(229, 29);
            txtStock.TabIndex = 113;
            txtStock.TextChanged += txtStock_TextChanged;
            txtStock.KeyDown += txtStock_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(18, 10);
            label1.Name = "label1";
            label1.Size = new Size(70, 17);
            label1.TabIndex = 120;
            label1.Text = "MÜŞTƏRİ:";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Enabled = false;
            txtCustomerID.Font = new Font("Segoe UI", 8.25F);
            txtCustomerID.Location = new Point(253, 31);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(17, 22);
            txtCustomerID.TabIndex = 119;
            // 
            // lstCustomer
            // 
            lstCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstCustomer.FormattingEnabled = true;
            lstCustomer.ItemHeight = 21;
            lstCustomer.Location = new Point(18, 59);
            lstCustomer.Name = "lstCustomer";
            lstCustomer.Size = new Size(229, 46);
            lstCustomer.TabIndex = 118;
            lstCustomer.Visible = false;
            lstCustomer.Click += lstCustomer_Click;
            // 
            // txtCustomer
            // 
            txtCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomer.Location = new Point(18, 30);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(229, 29);
            txtCustomer.TabIndex = 117;
            txtCustomer.TextChanged += txtCustomer_TextChanged;
            txtCustomer.KeyDown += txtCustomer_KeyDown;
            // 
            // lbDocNo
            // 
            lbDocNo.AutoSize = true;
            lbDocNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbDocNo.Location = new Point(418, 25);
            lbDocNo.Name = "lbDocNo";
            lbDocNo.Size = new Size(84, 21);
            lbDocNo.TabIndex = 121;
            lbDocNo.Text = "Sənəd №:";
            // 
            // txtDocTypeId
            // 
            txtDocTypeId.Enabled = false;
            txtDocTypeId.Font = new Font("Segoe UI", 8.25F);
            txtDocTypeId.Location = new Point(824, 28);
            txtDocTypeId.Name = "txtDocTypeId";
            txtDocTypeId.Size = new Size(17, 22);
            txtDocTypeId.TabIndex = 124;
            // 
            // lstDocType
            // 
            lstDocType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstDocType.FormattingEnabled = true;
            lstDocType.ItemHeight = 21;
            lstDocType.Location = new Point(589, 59);
            lstDocType.Name = "lstDocType";
            lstDocType.Size = new Size(229, 46);
            lstDocType.TabIndex = 123;
            lstDocType.Visible = false;
            lstDocType.Click += lstDocType_Click;
            // 
            // txtDocType
            // 
            txtDocType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDocType.Location = new Point(589, 30);
            txtDocType.Name = "txtDocType";
            txtDocType.Size = new Size(229, 29);
            txtDocType.TabIndex = 122;
            txtDocType.TextChanged += txtDocType_TextChanged;
            txtDocType.KeyDown += txtDocType_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(15, 20);
            label3.Name = "label3";
            label3.Size = new Size(123, 21);
            label3.TabIndex = 125;
            label3.Text = "TARİX ARALIĞI:";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 255, 192);
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ControlText;
            btnUpdate.Location = new Point(968, 31);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 33);
            btnUpdate.TabIndex = 126;
            btnUpdate.Text = "Yenilə";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dtpDocStartDate);
            panel1.Controls.Add(dtpDocEndDate);
            panel1.Controls.Add(txtDocNo);
            panel1.Controls.Add(lbDocNo);
            panel1.Location = new Point(31, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(663, 119);
            panel1.TabIndex = 127;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblDocType);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(txtStock);
            panel2.Controls.Add(txtDocTypeId);
            panel2.Controls.Add(lstStock);
            panel2.Controls.Add(lstDocType);
            panel2.Controls.Add(txtStockId);
            panel2.Controls.Add(txtDocType);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtCustomer);
            panel2.Controls.Add(txtCustomerID);
            panel2.Controls.Add(lstCustomer);
            panel2.Location = new Point(711, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(1101, 119);
            panel2.TabIndex = 128;
            // 
            // frmSearchEngine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1825, 881);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblUserName);
            Controls.Add(lblUserId);
            Controls.Add(adDgrvSearchEngineDetail);
            Name = "frmSearchEngine";
            Text = "frmSearchEngine";
            WindowState = FormWindowState.Maximized;
            Load += frmSearchEngine_Load;
            ((System.ComponentModel.ISupportInitialize)adDgrvSearchEngineDetail).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpDocStartDate;
        private DateTimePicker dtpDocEndDate;
        private Zuby.ADGV.AdvancedDataGridView adDgrvSearchEngineDetail;
        private Label lblUserName;
        private Label lblUserId;
        private Label lblDocType;
        private TextBox txtDocNo;
        private Label label2;
        private TextBox txtStockId;
        private ListBox lstStock;
        private TextBox txtStock;
        private Label label1;
        private TextBox txtCustomerID;
        private ListBox lstCustomer;
        private TextBox txtCustomer;
        private Label lbDocNo;
        private TextBox txtDocTypeId;
        private ListBox lstDocType;
        private TextBox txtDocType;
        private Label label3;
        private Button btnUpdate;
        private Panel panel1;
        private Panel panel2;
        private DataGridViewTextBoxColumn DOC_DATE;
        private DataGridViewTextBoxColumn DOC_NO;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn TYPE_NAME;
        private DataGridViewTextBoxColumn STOCK_NAME;
        private DataGridViewTextBoxColumn QUANTITY;
        private DataGridViewTextBoxColumn TOTAL_AMOUNT;
        private DataGridViewTextBoxColumn DEFAULT_PRICE;
        private DataGridViewTextBoxColumn TOTAL_QUANTITY;
        private DataGridViewTextBoxColumn BASE_UNIT_NAME;
        private DataGridViewTextBoxColumn DISCOUNT_PER_CENT;
        private DataGridViewTextBoxColumn DISCOUNT_AMOUNT;
        private DataGridViewTextBoxColumn INSERT_DATE_TIME;
        private DataGridViewTextBoxColumn PURCHASE_UNIT_NAME;
        private DataGridViewTextBoxColumn STOCK_ID;
        private DataGridViewTextBoxColumn PURCHASE_UNIT;
        private DataGridViewTextBoxColumn BASE_UNIT;
        private DataGridViewTextBoxColumn DETAIL_ID;
        private DataGridViewTextBoxColumn ACCOUNT_ID;
        private DataGridViewTextBoxColumn DOCUMENT_TYPE;
    }
}
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            createNewDoc = new Button();
            dtpDocStartDate = new DateTimePicker();
            dtpDocEndDate = new DateTimePicker();
            adDgrvDocumentDetail = new Zuby.ADGV.AdvancedDataGridView();
            DOC_NO = new DataGridViewTextBoxColumn();
            DOC_DATE = new DataGridViewTextBoxColumn();
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
            lblUserName = new Label();
            lblUserId = new Label();
            lblTotalAmount = new Label();
            lblDiscount = new Label();
            lblSubtotal = new Label();
            panel1 = new Panel();
            txtCustomer = new TextBox();
            lblSearchStock = new Label();
            btnSave = new Button();
            txtStock = new TextBox();
            label1 = new Label();
            lblDocType = new Label();
            txtDocNo = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)adDgrvDocumentDetail).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // createNewDoc
            // 
            createNewDoc.BackColor = Color.LimeGreen;
            createNewDoc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createNewDoc.ForeColor = Color.White;
            createNewDoc.Location = new Point(27, 10);
            createNewDoc.Name = "createNewDoc";
            createNewDoc.Size = new Size(124, 32);
            createNewDoc.TabIndex = 0;
            createNewDoc.Text = "YENİ STOK ➕";
            createNewDoc.UseVisualStyleBackColor = false;
            createNewDoc.Click += createNewDoc_Click;
            // 
            // dtpDocStartDate
            // 
            dtpDocStartDate.Format = DateTimePickerFormat.Short;
            dtpDocStartDate.Location = new Point(181, 19);
            dtpDocStartDate.Name = "dtpDocStartDate";
            dtpDocStartDate.Size = new Size(108, 23);
            dtpDocStartDate.TabIndex = 93;
            dtpDocStartDate.Value = new DateTime(2025, 3, 27, 0, 0, 0, 0);
            // 
            // dtpDocEndDate
            // 
            dtpDocEndDate.Format = DateTimePickerFormat.Short;
            dtpDocEndDate.Location = new Point(295, 19);
            dtpDocEndDate.Name = "dtpDocEndDate";
            dtpDocEndDate.Size = new Size(106, 23);
            dtpDocEndDate.TabIndex = 94;
            dtpDocEndDate.Value = new DateTime(2025, 3, 27, 0, 0, 0, 0);
            // 
            // adDgrvDocumentDetail
            // 
            adDgrvDocumentDetail.AllowUserToAddRows = false;
            adDgrvDocumentDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            adDgrvDocumentDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            adDgrvDocumentDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adDgrvDocumentDetail.Columns.AddRange(new DataGridViewColumn[] { DOC_NO, DOC_DATE, Customer, TYPE_NAME, STOCK_NAME, QUANTITY, TOTAL_AMOUNT, DEFAULT_PRICE, TOTAL_QUANTITY, BASE_UNIT_NAME, DISCOUNT_PER_CENT, DISCOUNT_AMOUNT, INSERT_DATE_TIME, PURCHASE_UNIT_NAME, STOCK_ID, PURCHASE_UNIT, BASE_UNIT, DETAIL_ID });
            adDgrvDocumentDetail.FilterAndSortEnabled = true;
            adDgrvDocumentDetail.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            adDgrvDocumentDetail.Location = new Point(27, 63);
            adDgrvDocumentDetail.MaxFilterButtonImageHeight = 23;
            adDgrvDocumentDetail.Name = "adDgrvDocumentDetail";
            adDgrvDocumentDetail.RightToLeft = RightToLeft.No;
            adDgrvDocumentDetail.Size = new Size(1782, 712);
            adDgrvDocumentDetail.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            adDgrvDocumentDetail.TabIndex = 95;
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
            // DOC_DATE
            // 
            DOC_DATE.DataPropertyName = "DOC_DATE";
            DOC_DATE.HeaderText = "Sənəd Tarixi";
            DOC_DATE.MinimumWidth = 24;
            DOC_DATE.Name = "DOC_DATE";
            DOC_DATE.SortMode = DataGridViewColumnSortMode.Programmatic;
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
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            STOCK_NAME.DefaultCellStyle = dataGridViewCellStyle7;
            STOCK_NAME.FillWeight = 150F;
            STOCK_NAME.HeaderText = "Stok Adı";
            STOCK_NAME.MinimumWidth = 24;
            STOCK_NAME.Name = "STOCK_NAME";
            STOCK_NAME.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // QUANTITY
            // 
            QUANTITY.DataPropertyName = "QUANTITY";
            dataGridViewCellStyle8.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            QUANTITY.DefaultCellStyle = dataGridViewCellStyle8;
            QUANTITY.FillWeight = 60F;
            QUANTITY.HeaderText = "Çəki";
            QUANTITY.MinimumWidth = 24;
            QUANTITY.Name = "QUANTITY";
            QUANTITY.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // TOTAL_AMOUNT
            // 
            TOTAL_AMOUNT.DataPropertyName = "TOTAL_AMOUNT";
            dataGridViewCellStyle9.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TOTAL_AMOUNT.DefaultCellStyle = dataGridViewCellStyle9;
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
            dataGridViewCellStyle10.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            TOTAL_QUANTITY.DefaultCellStyle = dataGridViewCellStyle10;
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
            dataGridViewCellStyle11.BackColor = Color.FromArgb(192, 255, 192);
            DISCOUNT_PER_CENT.DefaultCellStyle = dataGridViewCellStyle11;
            DISCOUNT_PER_CENT.HeaderText = "End. Faiz (%)";
            DISCOUNT_PER_CENT.MinimumWidth = 24;
            DISCOUNT_PER_CENT.Name = "DISCOUNT_PER_CENT";
            DISCOUNT_PER_CENT.SortMode = DataGridViewColumnSortMode.Programmatic;
            DISCOUNT_PER_CENT.Visible = false;
            // 
            // DISCOUNT_AMOUNT
            // 
            DISCOUNT_AMOUNT.DataPropertyName = "DISCOUNT_AMOUNT";
            dataGridViewCellStyle12.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            DISCOUNT_AMOUNT.DefaultCellStyle = dataGridViewCellStyle12;
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
            lblTotalAmount.Location = new Point(9, 41);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(80, 15);
            lblTotalAmount.TabIndex = 101;
            lblTotalAmount.Text = "Total Amount";
            // 
            // lblDiscount
            // 
            lblDiscount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(9, 24);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(54, 15);
            lblDiscount.TabIndex = 100;
            lblDiscount.Text = "Discount";
            // 
            // lblSubtotal
            // 
            lblSubtotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(9, 7);
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
            panel1.Location = new Point(1588, 781);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 71);
            panel1.TabIndex = 104;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(667, 5);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(129, 23);
            txtCustomer.TabIndex = 105;
            // 
            // lblSearchStock
            // 
            lblSearchStock.AutoSize = true;
            lblSearchStock.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSearchStock.Location = new Point(567, 9);
            lblSearchStock.Name = "lblSearchStock";
            lblSearchStock.Size = new Size(100, 19);
            lblSearchStock.TabIndex = 90;
            lblSearchStock.Text = "Müştəri Axtar";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.ForestGreen;
            btnSave.Enabled = false;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(1631, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(182, 45);
            btnSave.TabIndex = 98;
            btnSave.Text = "YADDA SAXLA ✅ 💾";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(928, 6);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(129, 23);
            txtStock.TabIndex = 107;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(831, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 19);
            label1.TabIndex = 106;
            label1.Text = "Stok Axtar";
            // 
            // lblDocType
            // 
            lblDocType.AutoSize = true;
            lblDocType.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDocType.Location = new Point(1307, 9);
            lblDocType.Name = "lblDocType";
            lblDocType.Size = new Size(90, 19);
            lblDocType.TabIndex = 108;
            lblDocType.Text = "Sənəd Növü";
            // 
            // txtDocNo
            // 
            txtDocNo.Location = new Point(1192, 8);
            txtDocNo.Name = "txtDocNo";
            txtDocNo.Size = new Size(76, 23);
            txtDocNo.TabIndex = 111;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(1099, 9);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 110;
            label3.Text = "Sənəd No:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1412, 9);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 112;
            // 
            // frmSearchEngine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1825, 881);
            Controls.Add(comboBox1);
            Controls.Add(txtDocNo);
            Controls.Add(label3);
            Controls.Add(lblDocType);
            Controls.Add(txtStock);
            Controls.Add(label1);
            Controls.Add(txtCustomer);
            Controls.Add(panel1);
            Controls.Add(lblUserName);
            Controls.Add(lblUserId);
            Controls.Add(btnSave);
            Controls.Add(adDgrvDocumentDetail);
            Controls.Add(dtpDocEndDate);
            Controls.Add(dtpDocStartDate);
            Controls.Add(lblSearchStock);
            Controls.Add(createNewDoc);
            Name = "frmSearchEngine";
            Text = "frmSearchEngine";
            WindowState = FormWindowState.Maximized;
            Load += frmSearchEngine_Load;
            ((System.ComponentModel.ISupportInitialize)adDgrvDocumentDetail).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createNewDoc;
        private DateTimePicker dtpDocStartDate;
        private DateTimePicker dtpDocEndDate;
        private Zuby.ADGV.AdvancedDataGridView adDgrvDocumentDetail;
        private Label lblUserName;
        private Label lblUserId;
        private Label lblTotalAmount;
        private Label lblDiscount;
        private Label lblSubtotal;
        private Panel panel1;
        private TextBox txtCustomer;
        private Label lblSearchStock;
        private Button btnSave;
        private DataGridViewTextBoxColumn DOC_NO;
        private DataGridViewTextBoxColumn DOC_DATE;
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
        private TextBox txtStock;
        private Label label1;
        private Label lblDocType;
        private TextBox txtDocNo;
        private Label label3;
        private ComboBox comboBox1;
    }
}
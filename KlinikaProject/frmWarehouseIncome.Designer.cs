namespace POS_BACK_OFFICE
{
    partial class frmWarehouseIncome
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWarehouseIncome));
            txtBarcode = new TextBox();
            btnSaveOffline = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            lstOfflineDocuments = new ListBox();
            btnSendToWarehouse = new Button();
            timerConnectionCheck = new System.Windows.Forms.Timer(components);
            lblStatus = new Label();
            dgvDocDetails = new DataGridView();
            btnOpenProductForm = new Button();
            txtSifarisNomresi = new TextBox();
            button1 = new Button();
            dtpDocDate1 = new DateTimePicker();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            dtpDocDate2 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDocDetails).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtBarcode
            // 
            txtBarcode.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBarcode.Location = new Point(49, 41);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(244, 33);
            txtBarcode.TabIndex = 0;
            txtBarcode.KeyDown += txtBarcode_KeyDown;
            // 
            // btnSaveOffline
            // 
            btnSaveOffline.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSaveOffline.Location = new Point(331, 39);
            btnSaveOffline.Name = "btnSaveOffline";
            btnSaveOffline.Size = new Size(243, 36);
            btnSaveOffline.TabIndex = 1;
            btnSaveOffline.Text = "Lokal Yaddaşa ver";
            btnSaveOffline.UseVisualStyleBackColor = true;
            btnSaveOffline.Click += btnSaveOffline_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(49, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(680, 247);
            dataGridView1.TabIndex = 2;
            dataGridView1.MouseDown += dataGridView1_MouseDown;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Column1.DefaultCellStyle = dataGridViewCellStyle2;
            Column1.FillWeight = 150F;
            Column1.HeaderText = "Barcode";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Column2.DefaultCellStyle = dataGridViewCellStyle3;
            Column2.FillWeight = 200F;
            Column2.HeaderText = "Çeşid adı";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 200;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Column3.DefaultCellStyle = dataGridViewCellStyle4;
            Column3.FillWeight = 150F;
            Column3.HeaderText = "Çəki (kg)";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // lstOfflineDocuments
            // 
            lstOfflineDocuments.BackColor = SystemColors.ButtonHighlight;
            lstOfflineDocuments.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstOfflineDocuments.ForeColor = SystemColors.WindowText;
            lstOfflineDocuments.FormattingEnabled = true;
            lstOfflineDocuments.ItemHeight = 21;
            lstOfflineDocuments.Location = new Point(53, 380);
            lstOfflineDocuments.Name = "lstOfflineDocuments";
            lstOfflineDocuments.Size = new Size(676, 235);
            lstOfflineDocuments.TabIndex = 3;
            lstOfflineDocuments.DrawItem += lstOfflineDocuments_DrawItem;
            lstOfflineDocuments.SelectedIndexChanged += lstOfflineDocuments_SelectedIndexChanged;
            // 
            // btnSendToWarehouse
            // 
            btnSendToWarehouse.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSendToWarehouse.Location = new Point(53, 632);
            btnSendToWarehouse.Name = "btnSendToWarehouse";
            btnSendToWarehouse.Size = new Size(345, 48);
            btnSendToWarehouse.TabIndex = 4;
            btnSendToWarehouse.Text = "Serverə Yüklə";
            btnSendToWarehouse.TextAlign = ContentAlignment.MiddleLeft;
            btnSendToWarehouse.UseVisualStyleBackColor = true;
            btnSendToWarehouse.Click += btnSendToWarehouse_Click;
            // 
            // timerConnectionCheck
            // 
            timerConnectionCheck.Enabled = true;
            timerConnectionCheck.Tick += timerConnectionCheck_Tick;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Enabled = false;
            lblStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(926, 7);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(148, 25);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Şəbəkə Statusu";
            // 
            // dgvDocDetails
            // 
            dgvDocDetails.AllowUserToAddRows = false;
            dgvDocDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvDocDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDocDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocDetails.Location = new Point(53, 705);
            dgvDocDetails.Name = "dgvDocDetails";
            dgvDocDetails.ReadOnly = true;
            dgvDocDetails.Size = new Size(675, 218);
            dgvDocDetails.TabIndex = 6;
            // 
            // btnOpenProductForm
            // 
            btnOpenProductForm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOpenProductForm.Location = new Point(594, 39);
            btnOpenProductForm.Name = "btnOpenProductForm";
            btnOpenProductForm.Size = new Size(134, 36);
            btnOpenProductForm.TabIndex = 7;
            btnOpenProductForm.Text = "Çeşidlər";
            btnOpenProductForm.UseVisualStyleBackColor = true;
            btnOpenProductForm.Click += btnOpenProductForm_Click;
            // 
            // txtSifarisNomresi
            // 
            txtSifarisNomresi.Location = new Point(509, 655);
            txtSifarisNomresi.Name = "txtSifarisNomresi";
            txtSifarisNomresi.ReadOnly = true;
            txtSifarisNomresi.Size = new Size(108, 23);
            txtSifarisNomresi.TabIndex = 68;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(623, 655);
            button1.Name = "button1";
            button1.Size = new Size(103, 25);
            button1.TabIndex = 69;
            button1.Text = "Sənəd No:";
            button1.UseVisualStyleBackColor = true;
            // 
            // dtpDocDate1
            // 
            dtpDocDate1.Format = DateTimePickerFormat.Short;
            dtpDocDate1.Location = new Point(53, 354);
            dtpDocDate1.Name = "dtpDocDate1";
            dtpDocDate1.Size = new Size(108, 23);
            dtpDocDate1.TabIndex = 90;
            dtpDocDate1.Value = new DateTime(2025, 4, 6, 0, 0, 0, 0);
            dtpDocDate1.ValueChanged += dtpDocDate_ValueChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(90, 26);
            contextMenuStrip1.Text = "SIL";
            contextMenuStrip1.Click += deleteMenuItem_Click;
            // 
            // deleteMenuItem
            // 
            deleteMenuItem.Name = "deleteMenuItem";
            deleteMenuItem.Size = new Size(89, 22);
            deleteMenuItem.Text = "SIL";
            // 
            // pictureBox1
            // 
            pictureBox1.Enabled = false;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1222, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 91;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Enabled = false;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1080, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(136, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 92;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // dtpDocDate2
            // 
            dtpDocDate2.Format = DateTimePickerFormat.Short;
            dtpDocDate2.Location = new Point(185, 354);
            dtpDocDate2.Name = "dtpDocDate2";
            dtpDocDate2.Size = new Size(108, 23);
            dtpDocDate2.TabIndex = 93;
            dtpDocDate2.Value = new DateTime(2025, 4, 6, 0, 0, 0, 0);
            dtpDocDate2.ValueChanged += dtpDocDate2_ValueChanged;
            // 
            // frmWarehouseIncome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 954);
            Controls.Add(dtpDocDate2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(dtpDocDate1);
            Controls.Add(button1);
            Controls.Add(txtSifarisNomresi);
            Controls.Add(btnOpenProductForm);
            Controls.Add(dgvDocDetails);
            Controls.Add(lblStatus);
            Controls.Add(btnSendToWarehouse);
            Controls.Add(lstOfflineDocuments);
            Controls.Add(dataGridView1);
            Controls.Add(btnSaveOffline);
            Controls.Add(txtBarcode);
            Name = "frmWarehouseIncome";
            Text = "frmWarehouseIncome";
            WindowState = FormWindowState.Minimized;
            Load += frmWarehouseIncome_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDocDetails).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBarcode;
        private Button btnSaveOffline;
        private DataGridView dataGridView1;
        private ListBox lstOfflineDocuments;
        private Button btnSendToWarehouse;
        private System.Windows.Forms.Timer timerConnectionCheck;
        private Label lblStatus;
        private DataGridView dgvDocDetails;
        private Button btnOpenProductForm;
        private TextBox txtSifarisNomresi;
        private Button button1;
        private DateTimePicker dtpDocDate1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteMenuItem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DateTimePicker dtpDocDate2;
    }
}
namespace POS_BACK_OFFICE
{
    partial class frmReseptiOlmayanMehsullar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReseptiOlmayanMehsullar));
            addgrvReseptiOlmayanList = new Zuby.ADGV.AdvancedDataGridView();
            GroupCode = new DataGridViewTextBoxColumn();
            MenuName = new DataGridViewTextBoxColumn();
            ReseptVarMi = new DataGridViewTextBoxColumn();
            Barcode = new DataGridViewTextBoxColumn();
            Pors = new DataGridViewTextBoxColumn();
            HeYox = new DataGridViewTextBoxColumn();
            txtMehsulAd = new TextBox();
            lblMenuItemCountCaption = new Label();
            lblMenuItemCount = new Label();
            label1 = new Label();
            btnCreateAutoRecipe = new Button();
            btnExceleGonder = new Button();
            btnFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)addgrvReseptiOlmayanList).BeginInit();
            SuspendLayout();
            // 
            // addgrvReseptiOlmayanList
            // 
            addgrvReseptiOlmayanList.AllowUserToAddRows = false;
            addgrvReseptiOlmayanList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            addgrvReseptiOlmayanList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            addgrvReseptiOlmayanList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addgrvReseptiOlmayanList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            addgrvReseptiOlmayanList.BorderStyle = BorderStyle.Fixed3D;
            addgrvReseptiOlmayanList.CausesValidation = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            addgrvReseptiOlmayanList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            addgrvReseptiOlmayanList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            addgrvReseptiOlmayanList.Columns.AddRange(new DataGridViewColumn[] { GroupCode, MenuName, ReseptVarMi, Barcode, Pors, HeYox });
            addgrvReseptiOlmayanList.EnableHeadersVisualStyles = false;
            addgrvReseptiOlmayanList.FilterAndSortEnabled = true;
            addgrvReseptiOlmayanList.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            addgrvReseptiOlmayanList.GridColor = SystemColors.InactiveBorder;
            addgrvReseptiOlmayanList.Location = new Point(34, 76);
            addgrvReseptiOlmayanList.MaxFilterButtonImageHeight = 23;
            addgrvReseptiOlmayanList.Name = "addgrvReseptiOlmayanList";
            addgrvReseptiOlmayanList.ReadOnly = true;
            addgrvReseptiOlmayanList.RightToLeft = RightToLeft.No;
            addgrvReseptiOlmayanList.Size = new Size(836, 612);
            addgrvReseptiOlmayanList.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            addgrvReseptiOlmayanList.TabIndex = 73;
            // 
            // GroupCode
            // 
            GroupCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            GroupCode.DataPropertyName = "GroupCode";
            GroupCode.HeaderText = "Qrup";
            GroupCode.MinimumWidth = 24;
            GroupCode.Name = "GroupCode";
            GroupCode.ReadOnly = true;
            GroupCode.SortMode = DataGridViewColumnSortMode.Programmatic;
            GroupCode.Width = 130;
            // 
            // MenuName
            // 
            MenuName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MenuName.DataPropertyName = "MenuName";
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 128);
            MenuName.DefaultCellStyle = dataGridViewCellStyle3;
            MenuName.HeaderText = "Menu adı";
            MenuName.MinimumWidth = 24;
            MenuName.Name = "MenuName";
            MenuName.ReadOnly = true;
            MenuName.SortMode = DataGridViewColumnSortMode.Programmatic;
            MenuName.Width = 200;
            // 
            // ReseptVarMi
            // 
            ReseptVarMi.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ReseptVarMi.DataPropertyName = "ReseptVarMi";
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ReseptVarMi.DefaultCellStyle = dataGridViewCellStyle4;
            ReseptVarMi.HeaderText = "Resept Var Mı";
            ReseptVarMi.MinimumWidth = 24;
            ReseptVarMi.Name = "ReseptVarMi";
            ReseptVarMi.ReadOnly = true;
            ReseptVarMi.SortMode = DataGridViewColumnSortMode.Programmatic;
            ReseptVarMi.Width = 200;
            // 
            // Barcode
            // 
            Barcode.DataPropertyName = "Barcode";
            Barcode.HeaderText = "Barcode";
            Barcode.MinimumWidth = 24;
            Barcode.Name = "Barcode";
            Barcode.ReadOnly = true;
            Barcode.SortMode = DataGridViewColumnSortMode.Programmatic;
            Barcode.Width = 82;
            // 
            // Pors
            // 
            Pors.DataPropertyName = "Pors";
            Pors.HeaderText = "Pors";
            Pors.MinimumWidth = 24;
            Pors.Name = "Pors";
            Pors.ReadOnly = true;
            Pors.SortMode = DataGridViewColumnSortMode.Programmatic;
            Pors.Width = 60;
            // 
            // HeYox
            // 
            HeYox.DataPropertyName = "HeYox";
            HeYox.HeaderText = "HəYox";
            HeYox.MinimumWidth = 24;
            HeYox.Name = "HeYox";
            HeYox.ReadOnly = true;
            HeYox.SortMode = DataGridViewColumnSortMode.Programmatic;
            HeYox.Width = 72;
            // 
            // txtMehsulAd
            // 
            txtMehsulAd.Location = new Point(229, 12);
            txtMehsulAd.Name = "txtMehsulAd";
            txtMehsulAd.Size = new Size(191, 23);
            txtMehsulAd.TabIndex = 75;
            // 
            // lblMenuItemCountCaption
            // 
            lblMenuItemCountCaption.AutoSize = true;
            lblMenuItemCountCaption.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMenuItemCountCaption.Location = new Point(714, 30);
            lblMenuItemCountCaption.Name = "lblMenuItemCountCaption";
            lblMenuItemCountCaption.Size = new Size(90, 21);
            lblMenuItemCountCaption.TabIndex = 78;
            lblMenuItemCountCaption.Text = "Menu Sayı";
            // 
            // lblMenuItemCount
            // 
            lblMenuItemCount.AutoSize = true;
            lblMenuItemCount.BackColor = Color.White;
            lblMenuItemCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMenuItemCount.Location = new Point(833, 30);
            lblMenuItemCount.Name = "lblMenuItemCount";
            lblMenuItemCount.Size = new Size(37, 21);
            lblMenuItemCount.TabIndex = 76;
            lblMenuItemCount.Text = "Say";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(229, 38);
            label1.Name = "label1";
            label1.Size = new Size(169, 21);
            label1.TabIndex = 79;
            label1.Text = "Filter üçün Menu Adı";
            // 
            // btnCreateAutoRecipe
            // 
            btnCreateAutoRecipe.BackColor = Color.FromArgb(128, 255, 128);
            btnCreateAutoRecipe.BackgroundImage = (Image)resources.GetObject("btnCreateAutoRecipe.BackgroundImage");
            btnCreateAutoRecipe.BackgroundImageLayout = ImageLayout.Stretch;
            btnCreateAutoRecipe.FlatAppearance.BorderColor = Color.Red;
            btnCreateAutoRecipe.FlatAppearance.BorderSize = 10;
            btnCreateAutoRecipe.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCreateAutoRecipe.ForeColor = Color.Black;
            btnCreateAutoRecipe.Location = new Point(887, 76);
            btnCreateAutoRecipe.Margin = new Padding(4, 3, 4, 3);
            btnCreateAutoRecipe.Name = "btnCreateAutoRecipe";
            btnCreateAutoRecipe.Size = new Size(209, 30);
            btnCreateAutoRecipe.TabIndex = 81;
            btnCreateAutoRecipe.Text = "Avtomatik Resept Yarat";
            btnCreateAutoRecipe.TextAlign = ContentAlignment.MiddleRight;
            btnCreateAutoRecipe.UseVisualStyleBackColor = false;
            btnCreateAutoRecipe.Click += btnCreateAutoRecipe_Click;
            // 
            // btnExceleGonder
            // 
            btnExceleGonder.BackColor = Color.FromArgb(128, 255, 128);
            btnExceleGonder.BackgroundImage = (Image)resources.GetObject("btnExceleGonder.BackgroundImage");
            btnExceleGonder.BackgroundImageLayout = ImageLayout.Stretch;
            btnExceleGonder.FlatAppearance.BorderColor = Color.Red;
            btnExceleGonder.FlatAppearance.BorderSize = 10;
            btnExceleGonder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnExceleGonder.ForeColor = Color.Black;
            btnExceleGonder.Location = new Point(478, 12);
            btnExceleGonder.Margin = new Padding(4, 3, 4, 3);
            btnExceleGonder.Name = "btnExceleGonder";
            btnExceleGonder.Size = new Size(121, 30);
            btnExceleGonder.TabIndex = 80;
            btnExceleGonder.Text = "EXCEL (Xlsx Format)";
            btnExceleGonder.TextAlign = ContentAlignment.MiddleRight;
            btnExceleGonder.UseVisualStyleBackColor = false;
            btnExceleGonder.Click += btnExceleGonder_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackgroundImage = (Image)resources.GetObject("btnFilter.BackgroundImage");
            btnFilter.BackgroundImageLayout = ImageLayout.Stretch;
            btnFilter.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnFilter.Location = new Point(34, 12);
            btnFilter.Margin = new Padding(4, 3, 4, 3);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(188, 58);
            btnFilter.TabIndex = 74;
            btnFilter.Text = "OK";
            btnFilter.TextAlign = ContentAlignment.MiddleRight;
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // frmReseptiOlmayanMehsullar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1604, 723);
            Controls.Add(btnCreateAutoRecipe);
            Controls.Add(btnExceleGonder);
            Controls.Add(label1);
            Controls.Add(lblMenuItemCountCaption);
            Controls.Add(lblMenuItemCount);
            Controls.Add(txtMehsulAd);
            Controls.Add(btnFilter);
            Controls.Add(addgrvReseptiOlmayanList);
            Name = "frmReseptiOlmayanMehsullar";
            Text = "frmReseptiOlmayanMehsullar";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)addgrvReseptiOlmayanList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Zuby.ADGV.AdvancedDataGridView addgrvReseptiOlmayanList;
        private TextBox txtMehsulAd;
        private Label lblMenuItemCountCaption;
        private Label lblMenuItemCount;
        private Label label1;
        private DataGridViewTextBoxColumn GroupCode;
        private DataGridViewTextBoxColumn MenuName;
        private DataGridViewTextBoxColumn ReseptVarMi;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn Pors;
        private DataGridViewTextBoxColumn HeYox;
        private Button btnCreateAutoRecipe;
        private Button btnExceleGonder;
        private Button btnFilter;
    }
}
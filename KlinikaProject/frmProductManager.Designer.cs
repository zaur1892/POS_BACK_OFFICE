namespace POS_BACK_OFFICE
{
    partial class frmProductManager
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
            txtCode = new TextBox();
            txtName = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvProducts = new DataGridView();
            ProductCode = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            lblCode = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // txtCode
            // 
            txtCode.Location = new Point(15, 43);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(176, 23);
            txtCode.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(14, 90);
            txtName.Name = "txtName";
            txtName.Size = new Size(176, 23);
            txtName.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.Location = new Point(187, 9);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 28);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Əlva Et";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUpdate.Location = new Point(285, 7);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(96, 30);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Dəyişdir";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDelete.Location = new Point(387, 9);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 30);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { ProductCode, ProductName });
            dgvProducts.Location = new Point(15, 138);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(465, 165);
            dgvProducts.TabIndex = 5;
            // 
            // ProductCode
            // 
            ProductCode.HeaderText = "Kod";
            ProductCode.Name = "ProductCode";
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Məhsul Adı";
            ProductName.Name = "ProductName";
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCode.Location = new Point(15, 9);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(65, 15);
            lblCode.TabIndex = 6;
            lblCode.Text = "Stok Kodu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(14, 72);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 7;
            label1.Text = "Stok Kodu";
            // 
            // frmProductManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 431);
            Controls.Add(label1);
            Controls.Add(lblCode);
            Controls.Add(dgvProducts);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtName);
            Controls.Add(txtCode);
            Name = "frmProductManager";
            Text = "frmProductManager";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCode;
        private TextBox txtName;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvProducts;
        private Label lblCode;
        private Label label1;
        private DataGridViewTextBoxColumn ProductCode;
        private DataGridViewTextBoxColumn ProductName;
    }
}
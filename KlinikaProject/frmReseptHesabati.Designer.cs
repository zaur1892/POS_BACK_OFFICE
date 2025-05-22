namespace POS_BACK_OFFICE
{
    partial class frmReseptHesabati
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
            dgrvReseptHesabati = new DataGridView();
            btnRaporla = new Button();
            btnExcel = new Button();
            btnPDF = new Button();
            cmbReseptGroup = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgrvReseptHesabati).BeginInit();
            SuspendLayout();
            // 
            // dgrvReseptHesabati
            // 
            dgrvReseptHesabati.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrvReseptHesabati.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgrvReseptHesabati.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrvReseptHesabati.Location = new Point(15, 80);
            dgrvReseptHesabati.Margin = new Padding(4);
            dgrvReseptHesabati.Name = "dgrvReseptHesabati";
            dgrvReseptHesabati.Size = new Size(1576, 743);
            dgrvReseptHesabati.TabIndex = 0;
            // 
            // btnRaporla
            // 
            btnRaporla.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnRaporla.Location = new Point(184, 21);
            btnRaporla.Margin = new Padding(4);
            btnRaporla.Name = "btnRaporla";
            btnRaporla.Size = new Size(154, 33);
            btnRaporla.TabIndex = 69;
            btnRaporla.Text = "Hesabat";
            btnRaporla.UseVisualStyleBackColor = true;
            btnRaporla.Click += btnRaporla_Click;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.Lime;
            btnExcel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnExcel.ForeColor = SystemColors.ActiveCaptionText;
            btnExcel.Location = new Point(346, 21);
            btnExcel.Margin = new Padding(4);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(154, 33);
            btnExcel.TabIndex = 70;
            btnExcel.Text = "EXCEL";
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // btnPDF
            // 
            btnPDF.BackColor = Color.Red;
            btnPDF.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPDF.ForeColor = SystemColors.ButtonFace;
            btnPDF.Location = new Point(522, 23);
            btnPDF.Margin = new Padding(4);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(154, 33);
            btnPDF.TabIndex = 71;
            btnPDF.Text = "PDF";
            btnPDF.UseVisualStyleBackColor = false;
            btnPDF.Click += btnPDF_Click;
            // 
            // cmbReseptGroup
            // 
            cmbReseptGroup.FormattingEnabled = true;
            cmbReseptGroup.Location = new Point(21, 22);
            cmbReseptGroup.Name = "cmbReseptGroup";
            cmbReseptGroup.Size = new Size(143, 29);
            cmbReseptGroup.TabIndex = 72;
            cmbReseptGroup.Enter += cmbReseptGroup_Enter;
            // 
            // frmReseptHesabati
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1604, 836);
            Controls.Add(cmbReseptGroup);
            Controls.Add(btnPDF);
            Controls.Add(btnExcel);
            Controls.Add(btnRaporla);
            Controls.Add(dgrvReseptHesabati);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "frmReseptHesabati";
            Text = "frmReseptHesabati";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgrvReseptHesabati).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgrvReseptHesabati;
        private Button btnRaporla;
        private Button btnExcel;
        private Button btnPDF;
        private ComboBox cmbReseptGroup;
    }
}
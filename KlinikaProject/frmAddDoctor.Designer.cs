namespace POS_BACK_OFFICE
{
    partial class frmAddDoctor
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
            txtHekimAdSoyad = new TextBox();
            lblHekimSoyad = new Label();
            lblTelefon = new Label();
            txtTelefon = new TextBox();
            lblVezifesi = new Label();
            lblDogumTarixi = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblUnvan = new Label();
            txtUnvan = new TextBox();
            btnSave = new Button();
            cmbVezife = new ComboBox();
            label1 = new Label();
            cmbXestexana = new ComboBox();
            dtpDogumTarixi = new DateTimePicker();
            SuspendLayout();
            // 
            // txtHekimAdSoyad
            // 
            txtHekimAdSoyad.Location = new Point(231, 39);
            txtHekimAdSoyad.Name = "txtHekimAdSoyad";
            txtHekimAdSoyad.Size = new Size(178, 23);
            txtHekimAdSoyad.TabIndex = 0;
            // 
            // lblHekimSoyad
            // 
            lblHekimSoyad.AutoSize = true;
            lblHekimSoyad.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblHekimSoyad.Location = new Point(34, 42);
            lblHekimSoyad.Name = "lblHekimSoyad";
            lblHekimSoyad.Size = new Size(136, 20);
            lblHekimSoyad.TabIndex = 1;
            lblHekimSoyad.Text = "Həkim Ad Soyadı :";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblTelefon.Location = new Point(34, 76);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(78, 20);
            lblTelefon.TabIndex = 3;
            lblTelefon.Text = "Telefonu :";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(231, 73);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(178, 23);
            txtTelefon.TabIndex = 2;
            // 
            // lblVezifesi
            // 
            lblVezifesi.AutoSize = true;
            lblVezifesi.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblVezifesi.Location = new Point(34, 140);
            lblVezifesi.Name = "lblVezifesi";
            lblVezifesi.Size = new Size(71, 20);
            lblVezifesi.TabIndex = 5;
            lblVezifesi.Text = "Vəzifəsi :";
            // 
            // lblDogumTarixi
            // 
            lblDogumTarixi.AutoSize = true;
            lblDogumTarixi.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblDogumTarixi.Location = new Point(34, 111);
            lblDogumTarixi.Name = "lblDogumTarixi";
            lblDogumTarixi.Size = new Size(111, 20);
            lblDogumTarixi.TabIndex = 7;
            lblDogumTarixi.Text = "Doğum Tarixi :";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Enabled = false;
            lblUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblUsername.Location = new Point(34, 179);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(198, 20);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "İstifadəçi adı (Əgər Varsa) :";
            // 
            // txtUsername
            // 
            txtUsername.Enabled = false;
            txtUsername.Location = new Point(234, 176);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(175, 23);
            txtUsername.TabIndex = 8;
            // 
            // lblUnvan
            // 
            lblUnvan.AutoSize = true;
            lblUnvan.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblUnvan.Location = new Point(34, 218);
            lblUnvan.Name = "lblUnvan";
            lblUnvan.Size = new Size(62, 20);
            lblUnvan.TabIndex = 11;
            lblUnvan.Text = "Ünvan :";
            // 
            // txtUnvan
            // 
            txtUnvan.Location = new Point(234, 215);
            txtUnvan.Name = "txtUnvan";
            txtUnvan.Size = new Size(175, 23);
            txtUnvan.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.Location = new Point(234, 290);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 33);
            btnSave.TabIndex = 12;
            btnSave.Text = "Yadda Saxla";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cmbVezife
            // 
            cmbVezife.FormattingEnabled = true;
            cmbVezife.Location = new Point(232, 143);
            cmbVezife.Name = "cmbVezife";
            cmbVezife.Size = new Size(177, 23);
            cmbVezife.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.Location = new Point(34, 247);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 15;
            label1.Text = "Xəstəxana :";
            // 
            // cmbXestexana
            // 
            cmbXestexana.FormattingEnabled = true;
            cmbXestexana.Location = new Point(232, 247);
            cmbXestexana.Name = "cmbXestexana";
            cmbXestexana.Size = new Size(177, 23);
            cmbXestexana.TabIndex = 16;
            // 
            // dtpDogumTarixi
            // 
            dtpDogumTarixi.Format = DateTimePickerFormat.Short;
            dtpDogumTarixi.Location = new Point(231, 114);
            dtpDogumTarixi.Name = "dtpDogumTarixi";
            dtpDogumTarixi.Size = new Size(178, 23);
            dtpDogumTarixi.TabIndex = 27;
            // 
            // frmAddDoctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 450);
            Controls.Add(dtpDogumTarixi);
            Controls.Add(cmbXestexana);
            Controls.Add(label1);
            Controls.Add(cmbVezife);
            Controls.Add(btnSave);
            Controls.Add(lblUnvan);
            Controls.Add(txtUnvan);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblDogumTarixi);
            Controls.Add(lblVezifesi);
            Controls.Add(lblTelefon);
            Controls.Add(txtTelefon);
            Controls.Add(lblHekimSoyad);
            Controls.Add(txtHekimAdSoyad);
            Name = "frmAddDoctor";
            Text = "frmAddDoctor";
            WindowState = FormWindowState.Maximized;
            Load += frmAddDoctor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHekimAdSoyad;
        private Label lblHekimSoyad;
        private Label lblTelefon;
        private TextBox txtTelefon;
        private Label lblVezifesi;
        private Label lblDogumTarixi;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblUnvan;
        private TextBox txtUnvan;
        private Button btnSave;
        private ComboBox cmbVezife;
        private Label label1;
        private ComboBox cmbXestexana;
        private DateTimePicker dtpDogumTarixi;
    }
}
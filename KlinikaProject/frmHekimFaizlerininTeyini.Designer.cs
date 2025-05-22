namespace POS_BACK_OFFICE
{
    partial class frmHekimFaizlerininTeyini
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
            gpTibbSahesi = new GroupBox();
            btnSaheFaizSave = new Button();
            txtSaheEdv = new TextBox();
            lblSaheEdv = new Label();
            txtSaheFaizId = new TextBox();
            txtSaheId = new TextBox();
            lblSahe = new Label();
            cmbSahe = new ComboBox();
            txtSaheGonderisFaiz = new TextBox();
            txtSaheMuayineFaiz = new TextBox();
            lblSaheGonderis = new Label();
            lblSaheMuayine = new Label();
            label2 = new Label();
            txtSaheGonderisPul = new TextBox();
            label3 = new Label();
            txtSaheMuayinePul = new TextBox();
            label1 = new Label();
            Faiz = new Label();
            gpXidmetNovu = new GroupBox();
            txtXnEdv = new TextBox();
            label8 = new Label();
            txtXnFaizId = new TextBox();
            btnXidmetNovuFaizSave = new Button();
            txtXidmetNovu = new TextBox();
            lstXidmetNovu = new ListBox();
            txtXidmetNovuId = new TextBox();
            lblXidmetNovu = new Label();
            txtXnGonderisFaiz = new TextBox();
            label6 = new Label();
            txtXnMuayineFaiz = new TextBox();
            label7 = new Label();
            lblXnGonderis = new Label();
            label4 = new Label();
            lblXnMuayine = new Label();
            label5 = new Label();
            txtXnGonderisPul = new TextBox();
            txtXnMuayinePul = new TextBox();
            gpHekimSecimi = new GroupBox();
            lblHekim = new Label();
            txtHekim = new TextBox();
            txtHekimId = new TextBox();
            lstHekim = new ListBox();
            dgrvHekimFaizTeyini = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            XidmetId = new DataGridViewTextBoxColumn();
            XidmetAdi = new DataGridViewTextBoxColumn();
            XususiQiymet = new DataGridViewTextBoxColumn();
            GonderisFaiz = new DataGridViewTextBoxColumn();
            GonderisMebleg = new DataGridViewTextBoxColumn();
            MuayineFaiz = new DataGridViewTextBoxColumn();
            MuayineMebleg = new DataGridViewTextBoxColumn();
            XususiFaiz = new DataGridViewTextBoxColumn();
            XususiMebleg = new DataGridViewTextBoxColumn();
            EDV = new DataGridViewTextBoxColumn();
            Hekim = new DataGridViewTextBoxColumn();
            gpTibbSahesi.SuspendLayout();
            gpXidmetNovu.SuspendLayout();
            gpHekimSecimi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrvHekimFaizTeyini).BeginInit();
            SuspendLayout();
            // 
            // gpTibbSahesi
            // 
            gpTibbSahesi.Controls.Add(btnSaheFaizSave);
            gpTibbSahesi.Controls.Add(txtSaheEdv);
            gpTibbSahesi.Controls.Add(lblSaheEdv);
            gpTibbSahesi.Controls.Add(txtSaheFaizId);
            gpTibbSahesi.Controls.Add(txtSaheId);
            gpTibbSahesi.Controls.Add(lblSahe);
            gpTibbSahesi.Controls.Add(cmbSahe);
            gpTibbSahesi.Controls.Add(txtSaheGonderisFaiz);
            gpTibbSahesi.Controls.Add(txtSaheMuayineFaiz);
            gpTibbSahesi.Controls.Add(lblSaheGonderis);
            gpTibbSahesi.Controls.Add(lblSaheMuayine);
            gpTibbSahesi.Controls.Add(label2);
            gpTibbSahesi.Controls.Add(txtSaheGonderisPul);
            gpTibbSahesi.Controls.Add(label3);
            gpTibbSahesi.Controls.Add(txtSaheMuayinePul);
            gpTibbSahesi.Controls.Add(label1);
            gpTibbSahesi.Controls.Add(Faiz);
            gpTibbSahesi.Location = new Point(25, 180);
            gpTibbSahesi.Name = "gpTibbSahesi";
            gpTibbSahesi.Size = new Size(247, 206);
            gpTibbSahesi.TabIndex = 26;
            gpTibbSahesi.TabStop = false;
            gpTibbSahesi.Text = "Tibb Sahəsi seçimi";
            // 
            // btnSaheFaizSave
            // 
            btnSaheFaizSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSaheFaizSave.Location = new Point(150, 175);
            btnSaheFaizSave.Name = "btnSaheFaizSave";
            btnSaheFaizSave.Size = new Size(90, 23);
            btnSaheFaizSave.TabIndex = 33;
            btnSaheFaizSave.Text = "Yadda Saxla";
            btnSaheFaizSave.UseVisualStyleBackColor = true;
            btnSaheFaizSave.Click += btnSaheFaizSave_Click;
            // 
            // txtSaheEdv
            // 
            txtSaheEdv.Location = new Point(62, 146);
            txtSaheEdv.Name = "txtSaheEdv";
            txtSaheEdv.Size = new Size(43, 23);
            txtSaheEdv.TabIndex = 42;
            // 
            // lblSaheEdv
            // 
            lblSaheEdv.AutoSize = true;
            lblSaheEdv.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSaheEdv.Location = new Point(7, 149);
            lblSaheEdv.Name = "lblSaheEdv";
            lblSaheEdv.Size = new Size(41, 20);
            lblSaheEdv.TabIndex = 41;
            lblSaheEdv.Text = "ƏDV";
            // 
            // txtSaheFaizId
            // 
            txtSaheFaizId.Enabled = false;
            txtSaheFaizId.Location = new Point(197, 146);
            txtSaheFaizId.Name = "txtSaheFaizId";
            txtSaheFaizId.Size = new Size(45, 23);
            txtSaheFaizId.TabIndex = 40;
            // 
            // txtSaheId
            // 
            txtSaheId.Enabled = false;
            txtSaheId.Location = new Point(214, 19);
            txtSaheId.Name = "txtSaheId";
            txtSaheId.Size = new Size(25, 23);
            txtSaheId.TabIndex = 39;
            // 
            // lblSahe
            // 
            lblSahe.AutoSize = true;
            lblSahe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSahe.Location = new Point(9, 29);
            lblSahe.Name = "lblSahe";
            lblSahe.Size = new Size(74, 15);
            lblSahe.TabIndex = 38;
            lblSahe.Text = "TİBBİ SAHƏ";
            // 
            // cmbSahe
            // 
            cmbSahe.FormattingEnabled = true;
            cmbSahe.Location = new Point(7, 47);
            cmbSahe.Name = "cmbSahe";
            cmbSahe.Size = new Size(232, 23);
            cmbSahe.TabIndex = 32;
            cmbSahe.SelectedIndexChanged += cmbSahe_SelectedIndexChanged;
            cmbSahe.Enter += cmbSahe_Enter;
            // 
            // txtSaheGonderisFaiz
            // 
            txtSaheGonderisFaiz.Location = new Point(7, 97);
            txtSaheGonderisFaiz.Name = "txtSaheGonderisFaiz";
            txtSaheGonderisFaiz.Size = new Size(45, 23);
            txtSaheGonderisFaiz.TabIndex = 28;
            // 
            // txtSaheMuayineFaiz
            // 
            txtSaheMuayineFaiz.Location = new Point(147, 96);
            txtSaheMuayineFaiz.Name = "txtSaheMuayineFaiz";
            txtSaheMuayineFaiz.Size = new Size(43, 23);
            txtSaheMuayineFaiz.TabIndex = 29;
            // 
            // lblSaheGonderis
            // 
            lblSaheGonderis.AutoSize = true;
            lblSaheGonderis.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSaheGonderis.Location = new Point(6, 73);
            lblSaheGonderis.Name = "lblSaheGonderis";
            lblSaheGonderis.Size = new Size(72, 20);
            lblSaheGonderis.TabIndex = 30;
            lblSaheGonderis.Text = "Göndəriş";
            // 
            // lblSaheMuayine
            // 
            lblSaheMuayine.AutoSize = true;
            lblSaheMuayine.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSaheMuayine.Location = new Point(159, 73);
            lblSaheMuayine.Name = "lblSaheMuayine";
            lblSaheMuayine.Size = new Size(69, 20);
            lblSaheMuayine.TabIndex = 31;
            lblSaheMuayine.Text = "Müayinə";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(206, 123);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 37;
            label2.Text = "Pul";
            // 
            // txtSaheGonderisPul
            // 
            txtSaheGonderisPul.Location = new Point(62, 97);
            txtSaheGonderisPul.Name = "txtSaheGonderisPul";
            txtSaheGonderisPul.Size = new Size(43, 23);
            txtSaheGonderisPul.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(150, 123);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 36;
            label3.Text = "Faiz";
            // 
            // txtSaheMuayinePul
            // 
            txtSaheMuayinePul.Location = new Point(196, 96);
            txtSaheMuayinePul.Name = "txtSaheMuayinePul";
            txtSaheMuayinePul.Size = new Size(43, 23);
            txtSaheMuayinePul.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(65, 123);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 35;
            label1.Text = "Pul";
            // 
            // Faiz
            // 
            Faiz.AutoSize = true;
            Faiz.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Faiz.Location = new Point(9, 123);
            Faiz.Name = "Faiz";
            Faiz.Size = new Size(28, 15);
            Faiz.TabIndex = 34;
            Faiz.Text = "Faiz";
            // 
            // gpXidmetNovu
            // 
            gpXidmetNovu.Controls.Add(txtXnEdv);
            gpXidmetNovu.Controls.Add(label8);
            gpXidmetNovu.Controls.Add(txtXnFaizId);
            gpXidmetNovu.Controls.Add(btnXidmetNovuFaizSave);
            gpXidmetNovu.Controls.Add(txtXidmetNovu);
            gpXidmetNovu.Controls.Add(lstXidmetNovu);
            gpXidmetNovu.Controls.Add(txtXidmetNovuId);
            gpXidmetNovu.Controls.Add(lblXidmetNovu);
            gpXidmetNovu.Controls.Add(txtXnGonderisFaiz);
            gpXidmetNovu.Controls.Add(label6);
            gpXidmetNovu.Controls.Add(txtXnMuayineFaiz);
            gpXidmetNovu.Controls.Add(label7);
            gpXidmetNovu.Controls.Add(lblXnGonderis);
            gpXidmetNovu.Controls.Add(label4);
            gpXidmetNovu.Controls.Add(lblXnMuayine);
            gpXidmetNovu.Controls.Add(label5);
            gpXidmetNovu.Controls.Add(txtXnGonderisPul);
            gpXidmetNovu.Controls.Add(txtXnMuayinePul);
            gpXidmetNovu.Location = new Point(25, 414);
            gpXidmetNovu.Name = "gpXidmetNovu";
            gpXidmetNovu.Size = new Size(247, 237);
            gpXidmetNovu.TabIndex = 27;
            gpXidmetNovu.TabStop = false;
            gpXidmetNovu.Text = "Xidmət Növü Seçimi";
            // 
            // txtXnEdv
            // 
            txtXnEdv.Location = new Point(62, 164);
            txtXnEdv.Name = "txtXnEdv";
            txtXnEdv.Size = new Size(43, 23);
            txtXnEdv.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(9, 167);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 45;
            label8.Text = "ƏDV";
            // 
            // txtXnFaizId
            // 
            txtXnFaizId.Enabled = false;
            txtXnFaizId.Location = new Point(197, 167);
            txtXnFaizId.Name = "txtXnFaizId";
            txtXnFaizId.Size = new Size(45, 23);
            txtXnFaizId.TabIndex = 44;
            // 
            // btnXidmetNovuFaizSave
            // 
            btnXidmetNovuFaizSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnXidmetNovuFaizSave.Location = new Point(152, 208);
            btnXidmetNovuFaizSave.Name = "btnXidmetNovuFaizSave";
            btnXidmetNovuFaizSave.Size = new Size(90, 23);
            btnXidmetNovuFaizSave.TabIndex = 43;
            btnXidmetNovuFaizSave.Text = "Yadda Saxla";
            btnXidmetNovuFaizSave.UseVisualStyleBackColor = true;
            btnXidmetNovuFaizSave.Click += btnXidmetNovuFaizSave_Click;
            // 
            // txtXidmetNovu
            // 
            txtXidmetNovu.Location = new Point(8, 55);
            txtXidmetNovu.Name = "txtXidmetNovu";
            txtXidmetNovu.Size = new Size(230, 23);
            txtXidmetNovu.TabIndex = 41;
            txtXidmetNovu.TextChanged += txtXidmetNovu_TextChanged;
            // 
            // lstXidmetNovu
            // 
            lstXidmetNovu.FormattingEnabled = true;
            lstXidmetNovu.ItemHeight = 15;
            lstXidmetNovu.Location = new Point(8, 81);
            lstXidmetNovu.Name = "lstXidmetNovu";
            lstXidmetNovu.Size = new Size(231, 64);
            lstXidmetNovu.TabIndex = 42;
            lstXidmetNovu.Visible = false;
            lstXidmetNovu.SelectedIndexChanged += lstXidmetNovu_SelectedIndexChanged;
            // 
            // txtXidmetNovuId
            // 
            txtXidmetNovuId.Enabled = false;
            txtXidmetNovuId.Location = new Point(214, 26);
            txtXidmetNovuId.Name = "txtXidmetNovuId";
            txtXidmetNovuId.Size = new Size(25, 23);
            txtXidmetNovuId.TabIndex = 40;
            // 
            // lblXidmetNovu
            // 
            lblXidmetNovu.AutoSize = true;
            lblXidmetNovu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblXidmetNovu.Location = new Point(8, 34);
            lblXidmetNovu.Name = "lblXidmetNovu";
            lblXidmetNovu.Size = new Size(93, 15);
            lblXidmetNovu.TabIndex = 39;
            lblXidmetNovu.Text = "XİDMƏT NÖVÜ";
            // 
            // txtXnGonderisFaiz
            // 
            txtXnGonderisFaiz.Location = new Point(10, 120);
            txtXnGonderisFaiz.Name = "txtXnGonderisFaiz";
            txtXnGonderisFaiz.Size = new Size(45, 23);
            txtXnGonderisFaiz.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(206, 146);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 38;
            label6.Text = "Pul";
            // 
            // txtXnMuayineFaiz
            // 
            txtXnMuayineFaiz.Location = new Point(150, 119);
            txtXnMuayineFaiz.Name = "txtXnMuayineFaiz";
            txtXnMuayineFaiz.Size = new Size(43, 23);
            txtXnMuayineFaiz.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(150, 146);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 37;
            label7.Text = "Faiz";
            // 
            // lblXnGonderis
            // 
            lblXnGonderis.AutoSize = true;
            lblXnGonderis.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblXnGonderis.Location = new Point(9, 96);
            lblXnGonderis.Name = "lblXnGonderis";
            lblXnGonderis.Size = new Size(72, 20);
            lblXnGonderis.TabIndex = 31;
            lblXnGonderis.Text = "Göndəriş";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(68, 146);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 36;
            label4.Text = "Pul";
            // 
            // lblXnMuayine
            // 
            lblXnMuayine.AutoSize = true;
            lblXnMuayine.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblXnMuayine.Location = new Point(150, 96);
            lblXnMuayine.Name = "lblXnMuayine";
            lblXnMuayine.Size = new Size(69, 20);
            lblXnMuayine.TabIndex = 32;
            lblXnMuayine.Text = "Müayinə";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(12, 146);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 35;
            label5.Text = "Faiz";
            // 
            // txtXnGonderisPul
            // 
            txtXnGonderisPul.Location = new Point(65, 120);
            txtXnGonderisPul.Name = "txtXnGonderisPul";
            txtXnGonderisPul.Size = new Size(43, 23);
            txtXnGonderisPul.TabIndex = 33;
            // 
            // txtXnMuayinePul
            // 
            txtXnMuayinePul.Location = new Point(199, 119);
            txtXnMuayinePul.Name = "txtXnMuayinePul";
            txtXnMuayinePul.Size = new Size(43, 23);
            txtXnMuayinePul.TabIndex = 34;
            // 
            // gpHekimSecimi
            // 
            gpHekimSecimi.Controls.Add(lblHekim);
            gpHekimSecimi.Controls.Add(txtHekim);
            gpHekimSecimi.Controls.Add(txtHekimId);
            gpHekimSecimi.Controls.Add(lstHekim);
            gpHekimSecimi.Location = new Point(27, 12);
            gpHekimSecimi.Name = "gpHekimSecimi";
            gpHekimSecimi.Size = new Size(245, 138);
            gpHekimSecimi.TabIndex = 32;
            gpHekimSecimi.TabStop = false;
            gpHekimSecimi.Text = "Həkim və ya Personal Seçimi";
            // 
            // lblHekim
            // 
            lblHekim.AutoSize = true;
            lblHekim.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblHekim.Location = new Point(7, 21);
            lblHekim.Name = "lblHekim";
            lblHekim.Size = new Size(48, 17);
            lblHekim.TabIndex = 35;
            lblHekim.Text = "Həkim";
            // 
            // txtHekim
            // 
            txtHekim.Location = new Point(7, 41);
            txtHekim.Name = "txtHekim";
            txtHekim.Size = new Size(230, 23);
            txtHekim.TabIndex = 27;
            txtHekim.TextChanged += txtHekim_TextChanged;
            // 
            // txtHekimId
            // 
            txtHekimId.Enabled = false;
            txtHekimId.Font = new Font("Segoe UI", 8.25F);
            txtHekimId.Location = new Point(212, 13);
            txtHekimId.Name = "txtHekimId";
            txtHekimId.Size = new Size(25, 22);
            txtHekimId.TabIndex = 34;
            // 
            // lstHekim
            // 
            lstHekim.FormattingEnabled = true;
            lstHekim.ItemHeight = 15;
            lstHekim.Location = new Point(7, 67);
            lstHekim.Name = "lstHekim";
            lstHekim.Size = new Size(231, 64);
            lstHekim.TabIndex = 33;
            lstHekim.Visible = false;
            lstHekim.SelectedIndexChanged += lstHekim_SelectedIndexChanged;
            // 
            // dgrvHekimFaizTeyini
            // 
            dgrvHekimFaizTeyini.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgrvHekimFaizTeyini.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrvHekimFaizTeyini.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrvHekimFaizTeyini.Columns.AddRange(new DataGridViewColumn[] { ID, XidmetId, XidmetAdi, XususiQiymet, GonderisFaiz, GonderisMebleg, MuayineFaiz, MuayineMebleg, XususiFaiz, XususiMebleg, EDV, Hekim });
            dgrvHekimFaizTeyini.Location = new Point(278, 16);
            dgrvHekimFaizTeyini.Name = "dgrvHekimFaizTeyini";
            dgrvHekimFaizTeyini.Size = new Size(1080, 721);
            dgrvHekimFaizTeyini.TabIndex = 35;
            dgrvHekimFaizTeyini.CellValueChanged += dgrvHekimFaizTeyini_CellValueChanged;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Visible = false;
            // 
            // XidmetId
            // 
            XidmetId.DataPropertyName = "XidmetId";
            XidmetId.HeaderText = "XidmetId";
            XidmetId.Name = "XidmetId";
            XidmetId.Visible = false;
            // 
            // XidmetAdi
            // 
            XidmetAdi.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            XidmetAdi.DataPropertyName = "XidmetAdi";
            XidmetAdi.HeaderText = "Xidmət Adı";
            XidmetAdi.Name = "XidmetAdi";
            XidmetAdi.Width = 91;
            // 
            // XususiQiymet
            // 
            XususiQiymet.DataPropertyName = "XususiQiymet";
            XususiQiymet.HeaderText = "XususiQiymet";
            XususiQiymet.Name = "XususiQiymet";
            // 
            // GonderisFaiz
            // 
            GonderisFaiz.DataPropertyName = "GonderisFaiz";
            GonderisFaiz.HeaderText = "Göndəriş Faiz %";
            GonderisFaiz.Name = "GonderisFaiz";
            // 
            // GonderisMebleg
            // 
            GonderisMebleg.DataPropertyName = "GonderisMebleg";
            GonderisMebleg.HeaderText = "Göndəriş AZN";
            GonderisMebleg.Name = "GonderisMebleg";
            // 
            // MuayineFaiz
            // 
            MuayineFaiz.DataPropertyName = "MuayineFaiz";
            MuayineFaiz.HeaderText = "Müayinə Faiz %";
            MuayineFaiz.Name = "MuayineFaiz";
            // 
            // MuayineMebleg
            // 
            MuayineMebleg.DataPropertyName = "MuayineMebleg";
            MuayineMebleg.HeaderText = "Müayinə AZN";
            MuayineMebleg.Name = "MuayineMebleg";
            // 
            // XususiFaiz
            // 
            XususiFaiz.DataPropertyName = "XususiFaiz";
            XususiFaiz.HeaderText = "Xüsusi Faiz %";
            XususiFaiz.Name = "XususiFaiz";
            // 
            // XususiMebleg
            // 
            XususiMebleg.DataPropertyName = "XususiMebleg";
            XususiMebleg.HeaderText = "Xüsusi AZN";
            XususiMebleg.Name = "XususiMebleg";
            // 
            // EDV
            // 
            EDV.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            EDV.DataPropertyName = "EDV";
            EDV.HeaderText = "EDV";
            EDV.Name = "EDV";
            EDV.Width = 53;
            // 
            // Hekim
            // 
            Hekim.DataPropertyName = "Hekim";
            Hekim.HeaderText = "Hekim";
            Hekim.Name = "Hekim";
            Hekim.Visible = false;
            // 
            // frmHekimFaizlerininTeyini
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(dgrvHekimFaizTeyini);
            Controls.Add(gpHekimSecimi);
            Controls.Add(gpXidmetNovu);
            Controls.Add(gpTibbSahesi);
            Name = "frmHekimFaizlerininTeyini";
            Text = "frmHekimFaizlerininTeyini";
            WindowState = FormWindowState.Maximized;
            gpTibbSahesi.ResumeLayout(false);
            gpTibbSahesi.PerformLayout();
            gpXidmetNovu.ResumeLayout(false);
            gpXidmetNovu.PerformLayout();
            gpHekimSecimi.ResumeLayout(false);
            gpHekimSecimi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrvHekimFaizTeyini).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gpTibbSahesi;
        private TextBox txtSaheId;
        private Label lblSahe;
        private ComboBox cmbSahe;
        private TextBox txtSaheGonderisFaiz;
        private TextBox txtSaheMuayineFaiz;
        private Label lblSaheGonderis;
        private Label lblSaheMuayine;
        private Label label2;
        private TextBox txtSaheGonderisPul;
        private Label label3;
        private TextBox txtSaheMuayinePul;
        private Label label1;
        private Label Faiz;
        private GroupBox gpXidmetNovu;
        private TextBox txtXidmetNovuId;
        private Label lblXidmetNovu;
        private TextBox txtXnGonderisFaiz;
        private Label label6;
        private TextBox txtXnMuayineFaiz;
        private Label label7;
        private Label lblXnGonderis;
        private Label label4;
        private Label lblXnMuayine;
        private Label label5;
        private TextBox txtXnGonderisPul;
        private TextBox txtXnMuayinePul;
        private GroupBox gpHekimSecimi;
        private Label lblHekim;
        private TextBox txtHekim;
        private TextBox txtHekimId;
        private ListBox lstHekim;
        private TextBox txtXidmetNovu;
        private ListBox lstXidmetNovu;
        private TextBox txtSaheFaizId;
        private TextBox txtSaheEdv;
        private Label lblSaheEdv;
        private Button btnSaheFaizSave;
        private Button btnXidmetNovuFaizSave;
        private TextBox txtXnEdv;
        private Label label8;
        private TextBox txtXnFaizId;
        private DataGridView dgrvHekimFaizTeyini;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn XidmetId;
        private DataGridViewTextBoxColumn XidmetAdi;
        private DataGridViewTextBoxColumn XususiQiymet;
        private DataGridViewTextBoxColumn GonderisFaiz;
        private DataGridViewTextBoxColumn GonderisMebleg;
        private DataGridViewTextBoxColumn MuayineFaiz;
        private DataGridViewTextBoxColumn MuayineMebleg;
        private DataGridViewTextBoxColumn XususiFaiz;
        private DataGridViewTextBoxColumn XususiMebleg;
        private DataGridViewTextBoxColumn EDV;
        private DataGridViewTextBoxColumn Hekim;
    }
}
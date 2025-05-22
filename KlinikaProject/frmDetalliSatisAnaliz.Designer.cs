namespace POS_BACK_OFFICE
{
    partial class frmDetalliSatisAnaliz
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
            btnGoster = new Button();
            cmbSahe = new ComboBox();
            txtSaheId = new TextBox();
            txtServiceCatId = new TextBox();
            cmbServiceCat = new ComboBox();
            txtServiceId = new TextBox();
            cmbService = new ComboBox();
            listBox1 = new ListBox();
            txtPasient = new TextBox();
            lstPasient = new ListBox();
            txtPasientId = new TextBox();
            txtGonderenHekimId = new TextBox();
            lstGonderenHekim = new ListBox();
            txtGonderenHekim = new TextBox();
            txtMuayineHekimId = new TextBox();
            lstMuayineHekim = new ListBox();
            txtMuayineHekim = new TextBox();
            lblPasient = new Label();
            lblGonderenHekim = new Label();
            lblMuayineHekim = new Label();
            lblBolme = new Label();
            label1 = new Label();
            lblXidmet = new Label();
            lblSifarisNo = new Label();
            txtSifarisNo = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            cmbTarixFiltr = new ComboBox();
            lblTarixFiltr = new Label();
            btnMHekimiDeyish = new Button();
            btnGHekimiDeyish = new Button();
            lblSatis = new Label();
            lblSatisMebleg = new Label();
            lblEndirimMebleg = new Label();
            lblEndirim = new Label();
            lblNetSatisMebleg = new Label();
            lblNetSatis = new Label();
            btnExceleGonder = new Button();
            lblSifarisSay = new Label();
            lblSifarisSayAd = new Label();
            lblXidmetSay = new Label();
            lblXidmetSayAd = new Label();
            btnKmHesabla = new Button();
            addgrvDetalliSatis = new Zuby.ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)addgrvDetalliSatis).BeginInit();
            SuspendLayout();
            // 
            // btnGoster
            // 
            btnGoster.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGoster.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGoster.Location = new Point(1090, 27);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new Size(84, 28);
            btnGoster.TabIndex = 1;
            btnGoster.Text = "Göstər OK";
            btnGoster.UseVisualStyleBackColor = true;
            btnGoster.Click += btnGoster_Click;
            // 
            // cmbSahe
            // 
            cmbSahe.AutoCompleteCustomSource.AddRange(new string[] { "Seçin" });
            cmbSahe.FormattingEnabled = true;
            cmbSahe.Items.AddRange(new object[] { "Seçin" });
            cmbSahe.Location = new Point(12, 13);
            cmbSahe.Name = "cmbSahe";
            cmbSahe.Size = new Size(175, 23);
            cmbSahe.TabIndex = 2;
            cmbSahe.SelectedIndexChanged += cmbSahe_SelectedIndexChanged;
            cmbSahe.Enter += cmbSahe_Enter;
            // 
            // txtSaheId
            // 
            txtSaheId.Enabled = false;
            txtSaheId.Font = new Font("Segoe UI", 8.25F);
            txtSaheId.Location = new Point(193, 13);
            txtSaheId.Name = "txtSaheId";
            txtSaheId.Size = new Size(14, 22);
            txtSaheId.TabIndex = 3;
            // 
            // txtServiceCatId
            // 
            txtServiceCatId.Enabled = false;
            txtServiceCatId.Font = new Font("Segoe UI", 8.25F);
            txtServiceCatId.Location = new Point(193, 42);
            txtServiceCatId.Name = "txtServiceCatId";
            txtServiceCatId.Size = new Size(14, 22);
            txtServiceCatId.TabIndex = 5;
            // 
            // cmbServiceCat
            // 
            cmbServiceCat.FormattingEnabled = true;
            cmbServiceCat.Location = new Point(12, 42);
            cmbServiceCat.Name = "cmbServiceCat";
            cmbServiceCat.Size = new Size(175, 23);
            cmbServiceCat.TabIndex = 4;
            cmbServiceCat.SelectedIndexChanged += cmbServiceCat_SelectedIndexChanged;
            cmbServiceCat.Enter += cmbServiceCat_Enter;
            // 
            // txtServiceId
            // 
            txtServiceId.Enabled = false;
            txtServiceId.Font = new Font("Segoe UI", 8.25F);
            txtServiceId.Location = new Point(193, 71);
            txtServiceId.Name = "txtServiceId";
            txtServiceId.Size = new Size(14, 22);
            txtServiceId.TabIndex = 7;
            // 
            // cmbService
            // 
            cmbService.FormattingEnabled = true;
            cmbService.Location = new Point(12, 71);
            cmbService.Name = "cmbService";
            cmbService.Size = new Size(175, 23);
            cmbService.TabIndex = 6;
            cmbService.SelectedIndexChanged += cmbService_SelectedIndexChanged;
            cmbService.TextChanged += cmbService_TextChanged;
            cmbService.Enter += cmbService_Enter;
            cmbService.Leave += cmbService_Leave;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(13, 100);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(194, 49);
            listBox1.TabIndex = 8;
            listBox1.Visible = false;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // txtPasient
            // 
            txtPasient.Location = new Point(292, 30);
            txtPasient.Name = "txtPasient";
            txtPasient.Size = new Size(151, 23);
            txtPasient.TabIndex = 9;
            txtPasient.TextChanged += txtPasient_TextChanged;
            // 
            // lstPasient
            // 
            lstPasient.FormattingEnabled = true;
            lstPasient.ItemHeight = 15;
            lstPasient.Location = new Point(292, 56);
            lstPasient.Name = "lstPasient";
            lstPasient.Size = new Size(172, 64);
            lstPasient.TabIndex = 10;
            lstPasient.Visible = false;
            lstPasient.DoubleClick += lstPasient_DoubleClick;
            // 
            // txtPasientId
            // 
            txtPasientId.Enabled = false;
            txtPasientId.Font = new Font("Segoe UI", 8.25F);
            txtPasientId.Location = new Point(447, 30);
            txtPasientId.Name = "txtPasientId";
            txtPasientId.Size = new Size(17, 22);
            txtPasientId.TabIndex = 11;
            // 
            // txtGonderenHekimId
            // 
            txtGonderenHekimId.Enabled = false;
            txtGonderenHekimId.Font = new Font("Segoe UI", 8.25F);
            txtGonderenHekimId.Location = new Point(608, 30);
            txtGonderenHekimId.Name = "txtGonderenHekimId";
            txtGonderenHekimId.Size = new Size(17, 22);
            txtGonderenHekimId.TabIndex = 14;
            // 
            // lstGonderenHekim
            // 
            lstGonderenHekim.FormattingEnabled = true;
            lstGonderenHekim.ItemHeight = 15;
            lstGonderenHekim.Location = new Point(493, 56);
            lstGonderenHekim.Name = "lstGonderenHekim";
            lstGonderenHekim.Size = new Size(132, 64);
            lstGonderenHekim.TabIndex = 13;
            lstGonderenHekim.Visible = false;
            lstGonderenHekim.DoubleClick += lstGonderenHekim_DoubleClick_1;
            // 
            // txtGonderenHekim
            // 
            txtGonderenHekim.Location = new Point(493, 30);
            txtGonderenHekim.Name = "txtGonderenHekim";
            txtGonderenHekim.Size = new Size(112, 23);
            txtGonderenHekim.TabIndex = 12;
            txtGonderenHekim.TextChanged += txtGonderenHekim_TextChanged;
            // 
            // txtMuayineHekimId
            // 
            txtMuayineHekimId.Enabled = false;
            txtMuayineHekimId.Font = new Font("Segoe UI", 8.25F);
            txtMuayineHekimId.Location = new Point(765, 29);
            txtMuayineHekimId.Name = "txtMuayineHekimId";
            txtMuayineHekimId.Size = new Size(16, 22);
            txtMuayineHekimId.TabIndex = 17;
            // 
            // lstMuayineHekim
            // 
            lstMuayineHekim.FormattingEnabled = true;
            lstMuayineHekim.ItemHeight = 15;
            lstMuayineHekim.Location = new Point(653, 56);
            lstMuayineHekim.Name = "lstMuayineHekim";
            lstMuayineHekim.Size = new Size(128, 64);
            lstMuayineHekim.TabIndex = 16;
            lstMuayineHekim.Visible = false;
            lstMuayineHekim.DoubleClick += lstMuayineHekim_DoubleClick;
            // 
            // txtMuayineHekim
            // 
            txtMuayineHekim.Location = new Point(653, 29);
            txtMuayineHekim.Name = "txtMuayineHekim";
            txtMuayineHekim.Size = new Size(109, 23);
            txtMuayineHekim.TabIndex = 15;
            txtMuayineHekim.TextChanged += txtMuayineHekim_TextChanged;
            // 
            // lblPasient
            // 
            lblPasient.AutoSize = true;
            lblPasient.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPasient.Location = new Point(292, 10);
            lblPasient.Name = "lblPasient";
            lblPasient.Size = new Size(115, 17);
            lblPasient.TabIndex = 18;
            lblPasient.Text = "Pasient Ad Soyad";
            // 
            // lblGonderenHekim
            // 
            lblGonderenHekim.AutoSize = true;
            lblGonderenHekim.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGonderenHekim.Location = new Point(493, 10);
            lblGonderenHekim.Name = "lblGonderenHekim";
            lblGonderenHekim.Size = new Size(112, 17);
            lblGonderenHekim.TabIndex = 19;
            lblGonderenHekim.Text = "Göndərən Həkim";
            // 
            // lblMuayineHekim
            // 
            lblMuayineHekim.AutoSize = true;
            lblMuayineHekim.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMuayineHekim.Location = new Point(653, 9);
            lblMuayineHekim.Name = "lblMuayineHekim";
            lblMuayineHekim.Size = new Size(109, 17);
            lblMuayineHekim.TabIndex = 20;
            lblMuayineHekim.Text = "Müayinə Həkimi";
            // 
            // lblBolme
            // 
            lblBolme.AutoSize = true;
            lblBolme.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBolme.Location = new Point(212, 16);
            lblBolme.Name = "lblBolme";
            lblBolme.Size = new Size(47, 17);
            lblBolme.TabIndex = 21;
            lblBolme.Text = "Bölmə";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(212, 45);
            label1.Name = "label1";
            label1.Size = new Size(33, 17);
            label1.TabIndex = 22;
            label1.Text = "Növ";
            // 
            // lblXidmet
            // 
            lblXidmet.AutoSize = true;
            lblXidmet.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblXidmet.Location = new Point(212, 74);
            lblXidmet.Name = "lblXidmet";
            lblXidmet.Size = new Size(53, 17);
            lblXidmet.TabIndex = 23;
            lblXidmet.Text = "Xidmət";
            // 
            // lblSifarisNo
            // 
            lblSifarisNo.AutoSize = true;
            lblSifarisNo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSifarisNo.Location = new Point(803, 9);
            lblSifarisNo.Name = "lblSifarisNo";
            lblSifarisNo.Size = new Size(66, 17);
            lblSifarisNo.TabIndex = 25;
            lblSifarisNo.Text = "Sifariş №";
            // 
            // txtSifarisNo
            // 
            txtSifarisNo.Location = new Point(803, 29);
            txtSifarisNo.Name = "txtSifarisNo";
            txtSifarisNo.Size = new Size(66, 23);
            txtSifarisNo.TabIndex = 24;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(965, 29);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(94, 23);
            dateTimePicker2.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(856, 29);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(100, 23);
            dateTimePicker1.TabIndex = 26;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(904, 9);
            label2.Name = "label2";
            label2.Size = new Size(100, 17);
            label2.TabIndex = 28;
            label2.Text = "Tarix  -  Aralığı";
            // 
            // cmbTarixFiltr
            // 
            cmbTarixFiltr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbTarixFiltr.FormattingEnabled = true;
            cmbTarixFiltr.Items.AddRange(new object[] { "Dünən", "Keçən Həftə", "Bu Ay", "Keçən Ay", "Bu il", "Keçən İl", "Son On İllik" });
            cmbTarixFiltr.Location = new Point(965, 58);
            cmbTarixFiltr.Name = "cmbTarixFiltr";
            cmbTarixFiltr.Size = new Size(94, 23);
            cmbTarixFiltr.TabIndex = 29;
            cmbTarixFiltr.SelectedIndexChanged += cmbTarixFiltr_SelectedIndexChanged;
            // 
            // lblTarixFiltr
            // 
            lblTarixFiltr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTarixFiltr.AutoSize = true;
            lblTarixFiltr.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTarixFiltr.Location = new Point(856, 64);
            lblTarixFiltr.Name = "lblTarixFiltr";
            lblTarixFiltr.Size = new Size(99, 17);
            lblTarixFiltr.TabIndex = 30;
            lblTarixFiltr.Text = "Tarix  Filtrləri :";
            // 
            // btnMHekimiDeyish
            // 
            btnMHekimiDeyish.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMHekimiDeyish.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMHekimiDeyish.ForeColor = Color.DarkRed;
            btnMHekimiDeyish.Location = new Point(856, 124);
            btnMHekimiDeyish.Name = "btnMHekimiDeyish";
            btnMHekimiDeyish.Size = new Size(202, 24);
            btnMHekimiDeyish.TabIndex = 31;
            btnMHekimiDeyish.Text = "Müayinə H-i Dəyiş!";
            btnMHekimiDeyish.UseVisualStyleBackColor = true;
            btnMHekimiDeyish.Click += btnMHekimiDeyish_Click;
            // 
            // btnGHekimiDeyish
            // 
            btnGHekimiDeyish.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGHekimiDeyish.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGHekimiDeyish.ForeColor = Color.DarkRed;
            btnGHekimiDeyish.Location = new Point(856, 98);
            btnGHekimiDeyish.Name = "btnGHekimiDeyish";
            btnGHekimiDeyish.Size = new Size(203, 24);
            btnGHekimiDeyish.TabIndex = 32;
            btnGHekimiDeyish.Text = "Göndərən H-i Dəyiş!";
            btnGHekimiDeyish.UseVisualStyleBackColor = true;
            btnGHekimiDeyish.Click += btnGHekimiDeyish_Click;
            // 
            // lblSatis
            // 
            lblSatis.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSatis.AutoSize = true;
            lblSatis.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSatis.Location = new Point(1089, 56);
            lblSatis.Name = "lblSatis";
            lblSatis.Size = new Size(45, 17);
            lblSatis.TabIndex = 33;
            lblSatis.Text = "Satış :";
            // 
            // lblSatisMebleg
            // 
            lblSatisMebleg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSatisMebleg.AutoSize = true;
            lblSatisMebleg.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSatisMebleg.ForeColor = Color.DarkOrange;
            lblSatisMebleg.Location = new Point(1202, 56);
            lblSatisMebleg.Name = "lblSatisMebleg";
            lblSatisMebleg.Size = new Size(15, 17);
            lblSatisMebleg.TabIndex = 34;
            lblSatisMebleg.Text = "0";
            // 
            // lblEndirimMebleg
            // 
            lblEndirimMebleg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEndirimMebleg.AutoSize = true;
            lblEndirimMebleg.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEndirimMebleg.ForeColor = Color.Red;
            lblEndirimMebleg.Location = new Point(1203, 73);
            lblEndirimMebleg.Name = "lblEndirimMebleg";
            lblEndirimMebleg.Size = new Size(15, 17);
            lblEndirimMebleg.TabIndex = 36;
            lblEndirimMebleg.Text = "0";
            // 
            // lblEndirim
            // 
            lblEndirim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEndirim.AutoSize = true;
            lblEndirim.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEndirim.Location = new Point(1089, 73);
            lblEndirim.Name = "lblEndirim";
            lblEndirim.Size = new Size(64, 17);
            lblEndirim.TabIndex = 35;
            lblEndirim.Text = "Endirim :";
            // 
            // lblNetSatisMebleg
            // 
            lblNetSatisMebleg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNetSatisMebleg.AutoSize = true;
            lblNetSatisMebleg.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblNetSatisMebleg.ForeColor = Color.Green;
            lblNetSatisMebleg.Location = new Point(1203, 90);
            lblNetSatisMebleg.Name = "lblNetSatisMebleg";
            lblNetSatisMebleg.Size = new Size(15, 17);
            lblNetSatisMebleg.TabIndex = 38;
            lblNetSatisMebleg.Text = "0";
            // 
            // lblNetSatis
            // 
            lblNetSatis.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblNetSatis.AutoSize = true;
            lblNetSatis.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblNetSatis.Location = new Point(1089, 90);
            lblNetSatis.Name = "lblNetSatis";
            lblNetSatis.Size = new Size(74, 17);
            lblNetSatis.TabIndex = 37;
            lblNetSatis.Text = "NET Satış :";
            // 
            // btnExceleGonder
            // 
            btnExceleGonder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExceleGonder.BackColor = Color.Lime;
            btnExceleGonder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnExceleGonder.Location = new Point(1203, 26);
            btnExceleGonder.Name = "btnExceleGonder";
            btnExceleGonder.Size = new Size(84, 28);
            btnExceleGonder.TabIndex = 40;
            btnExceleGonder.Text = "EXCEL";
            btnExceleGonder.UseVisualStyleBackColor = false;
            btnExceleGonder.Click += btnExceleGonder_Click;
            // 
            // lblSifarisSay
            // 
            lblSifarisSay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSifarisSay.AutoSize = true;
            lblSifarisSay.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSifarisSay.ForeColor = Color.Red;
            lblSifarisSay.Location = new Point(1204, 130);
            lblSifarisSay.Name = "lblSifarisSay";
            lblSifarisSay.Size = new Size(15, 17);
            lblSifarisSay.TabIndex = 44;
            lblSifarisSay.Text = "0";
            // 
            // lblSifarisSayAd
            // 
            lblSifarisSayAd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSifarisSayAd.AutoSize = true;
            lblSifarisSayAd.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 162);
            lblSifarisSayAd.ForeColor = Color.Red;
            lblSifarisSayAd.Location = new Point(1090, 130);
            lblSifarisSayAd.Name = "lblSifarisSayAd";
            lblSifarisSayAd.Size = new Size(74, 17);
            lblSifarisSayAd.TabIndex = 43;
            lblSifarisSayAd.Text = "Sifariş Sayı :";
            // 
            // lblXidmetSay
            // 
            lblXidmetSay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblXidmetSay.AutoSize = true;
            lblXidmetSay.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblXidmetSay.ForeColor = Color.Red;
            lblXidmetSay.Location = new Point(1204, 113);
            lblXidmetSay.Name = "lblXidmetSay";
            lblXidmetSay.Size = new Size(15, 17);
            lblXidmetSay.TabIndex = 42;
            lblXidmetSay.Text = "0";
            // 
            // lblXidmetSayAd
            // 
            lblXidmetSayAd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblXidmetSayAd.AutoSize = true;
            lblXidmetSayAd.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 162);
            lblXidmetSayAd.ForeColor = Color.Red;
            lblXidmetSayAd.Location = new Point(1090, 113);
            lblXidmetSayAd.Name = "lblXidmetSayAd";
            lblXidmetSayAd.Size = new Size(80, 17);
            lblXidmetSayAd.TabIndex = 41;
            lblXidmetSayAd.Text = "Xidmət Sayı :";
            // 
            // btnKmHesabla
            // 
            btnKmHesabla.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnKmHesabla.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKmHesabla.Location = new Point(752, 153);
            btnKmHesabla.Name = "btnKmHesabla";
            btnKmHesabla.Size = new Size(307, 27);
            btnKmHesabla.TabIndex = 45;
            btnKmHesabla.Text = "Sifarişdəki KM Yenidən Hesabla";
            btnKmHesabla.UseVisualStyleBackColor = true;
            btnKmHesabla.Click += btnKmHesabla_Click;
            // 
            // addgrvDetalliSatis
            // 
            addgrvDetalliSatis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            addgrvDetalliSatis.FilterAndSortEnabled = true;
            addgrvDetalliSatis.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            addgrvDetalliSatis.Location = new Point(32, 212);
            addgrvDetalliSatis.MaxFilterButtonImageHeight = 23;
            addgrvDetalliSatis.Name = "addgrvDetalliSatis";
            addgrvDetalliSatis.RightToLeft = RightToLeft.No;
            addgrvDetalliSatis.Size = new Size(1064, 518);
            addgrvDetalliSatis.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            addgrvDetalliSatis.TabIndex = 46;
            // 
            // frmDetalliSatisAnaliz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1350, 729);
            Controls.Add(addgrvDetalliSatis);
            Controls.Add(btnKmHesabla);
            Controls.Add(lblSifarisSay);
            Controls.Add(lblSifarisSayAd);
            Controls.Add(lblXidmetSay);
            Controls.Add(lblXidmetSayAd);
            Controls.Add(btnExceleGonder);
            Controls.Add(lblNetSatisMebleg);
            Controls.Add(lblNetSatis);
            Controls.Add(lblEndirimMebleg);
            Controls.Add(lblEndirim);
            Controls.Add(lblSatisMebleg);
            Controls.Add(lblSatis);
            Controls.Add(btnGHekimiDeyish);
            Controls.Add(btnMHekimiDeyish);
            Controls.Add(lblTarixFiltr);
            Controls.Add(cmbTarixFiltr);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblSifarisNo);
            Controls.Add(txtSifarisNo);
            Controls.Add(lblXidmet);
            Controls.Add(label1);
            Controls.Add(lblBolme);
            Controls.Add(lblMuayineHekim);
            Controls.Add(lblGonderenHekim);
            Controls.Add(lblPasient);
            Controls.Add(txtGonderenHekim);
            Controls.Add(txtMuayineHekimId);
            Controls.Add(lstMuayineHekim);
            Controls.Add(txtMuayineHekim);
            Controls.Add(txtGonderenHekimId);
            Controls.Add(lstGonderenHekim);
            Controls.Add(txtPasientId);
            Controls.Add(lstPasient);
            Controls.Add(txtPasient);
            Controls.Add(listBox1);
            Controls.Add(txtServiceId);
            Controls.Add(cmbService);
            Controls.Add(txtServiceCatId);
            Controls.Add(cmbServiceCat);
            Controls.Add(txtSaheId);
            Controls.Add(cmbSahe);
            Controls.Add(btnGoster);
            Name = "frmDetalliSatisAnaliz";
            Text = "frmDetalliSatisAnaliz";
            WindowState = FormWindowState.Maximized;
            Load += frmDetalliSatisAnaliz_Load;
            ((System.ComponentModel.ISupportInitialize)addgrvDetalliSatis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView adaddgrvDetalliSatis;
        private Button btnGoster;
        private ComboBox cmbSahe;
        private TextBox txtSaheId;
        private TextBox txtServiceCatId;
        private ComboBox cmbServiceCat;
        private TextBox txtServiceId;
        private ComboBox cmbService;
        private ListBox listBox1;
        private TextBox txtPasient;
        private ListBox lstPasient;
        private TextBox txtPasientId;
        private TextBox txtGonderenHekimId;
        private ListBox lstGonderenHekim;
        private TextBox txtGonderenHekim;
        private TextBox txtMuayineHekimId;
        private ListBox lstMuayineHekim;
        private TextBox txtMuayineHekim;
        private Label lblPasient;
        private Label lblGonderenHekim;
        private Label lblMuayineHekim;
        private Label lblBolme;
        private Label label1;
        private Label lblXidmet;
        private Label lblSifarisNo;
        private TextBox txtSifarisNo;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private ComboBox cmbTarixFiltr;
        private Label lblTarixFiltr;
        private Button btnMHekimiDeyish;
        private Button btnGHekimiDeyish;
        private Label lblSatis;
        private Label lblSatisMebleg;
        private Label lblEndirimMebleg;
        private Label lblEndirim;
        private Label lblNetSatisMebleg;
        private Label lblNetSatis;
        private Button btnExceleGonder;
        private Label lblSifarisSay;
        private Label lblSifarisSayAd;
        private Label lblXidmetSay;
        private Label lblXidmetSayAd;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn SifarisNo;
        private DataGridViewTextBoxColumn Tarix;
        private DataGridViewTextBoxColumn Pasient;
        private DataGridViewTextBoxColumn Xidmet;
        private Button btnKmHesabla;
        private Zuby.ADGV.AdvancedDataGridView addgrvDetalliSatis;
    }
}
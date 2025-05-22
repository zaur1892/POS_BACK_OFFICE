namespace POS_BACK_OFFICE
{
    partial class frmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            btnAddDoctor = new Button();
            btnAddNewService = new Button();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            btnAddSettings = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // btnAddDoctor
            // 
            btnAddDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAddDoctor.Location = new Point(111, 28);
            btnAddDoctor.Name = "btnAddDoctor";
            btnAddDoctor.Size = new Size(214, 61);
            btnAddDoctor.TabIndex = 0;
            btnAddDoctor.Text = "User Əlavə Et";
            btnAddDoctor.UseVisualStyleBackColor = true;
            btnAddDoctor.Click += btnAddDoctor_Click;
            // 
            // btnAddNewService
            // 
            btnAddNewService.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAddNewService.Location = new Point(112, 105);
            btnAddNewService.Name = "btnAddNewService";
            btnAddNewService.Size = new Size(213, 62);
            btnAddNewService.TabIndex = 3;
            btnAddNewService.Text = "Yeni Çeşid Əlavə Et";
            btnAddNewService.UseVisualStyleBackColor = true;
            btnAddNewService.Click += btnAddNewService_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Hekim;
            pictureBox1.Location = new Point(21, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(21, 105);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(69, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(21, 187);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(69, 62);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // btnAddSettings
            // 
            btnAddSettings.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAddSettings.Location = new Point(112, 187);
            btnAddSettings.Name = "btnAddSettings";
            btnAddSettings.Size = new Size(213, 61);
            btnAddSettings.TabIndex = 8;
            btnAddSettings.Text = "APP SETTINGS";
            btnAddSettings.UseVisualStyleBackColor = true;
            btnAddSettings.Click += btnAddSettings_Click;
            // 
            // frmSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 560);
            Controls.Add(pictureBox5);
            Controls.Add(btnAddSettings);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(btnAddNewService);
            Controls.Add(btnAddDoctor);
            Name = "frmSetting";
            Text = "s";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddDoctor;
        private Button btnAddNewService;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private Button btnAddSettings;
    }
}
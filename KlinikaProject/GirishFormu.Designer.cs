namespace POS_BACK_OFFICE
{
    partial class GirishFormu
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
            btnGirish = new Button();
            txtUsername = new TextBox();
            txtPass = new TextBox();
            lblUserId = new Label();
            SuspendLayout();
            // 
            // btnGirish
            // 
            btnGirish.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGirish.Location = new Point(362, 222);
            btnGirish.Name = "btnGirish";
            btnGirish.Size = new Size(136, 32);
            btnGirish.TabIndex = 71;
            btnGirish.Text = "Giriş";
            btnGirish.UseVisualStyleBackColor = true;
            btnGirish.Click += btnGirish_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(362, 139);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(136, 23);
            txtUsername.TabIndex = 72;
            txtUsername.Text = "Z";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(362, 180);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(136, 23);
            txtPass.TabIndex = 73;
            txtPass.Text = "1";
            txtPass.KeyDown += txtPass_KeyDown;
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUserId.Location = new Point(504, 149);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(41, 13);
            lblUserId.TabIndex = 106;
            lblUserId.Text = "UserID";
            lblUserId.Visible = false;
            // 
            // GirishFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblUserId);
            Controls.Add(txtPass);
            Controls.Add(txtUsername);
            Controls.Add(btnGirish);
            Name = "GirishFormu";
            Text = "GirishFormu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGirish;
        private TextBox txtUsername;
        private TextBox txtPass;
        private Label lblUserId;
    }
}
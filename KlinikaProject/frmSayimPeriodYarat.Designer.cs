namespace POS_BACK_OFFICE
{
    partial class frmSayimPeriodYarat
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
            dtpSayimEnd = new DateTimePicker();
            dtpSayimStart = new DateTimePicker();
            btnCreateSayimStoklarla = new Button();
            SuspendLayout();
            // 
            // dtpSayimEnd
            // 
            dtpSayimEnd.Format = DateTimePickerFormat.Short;
            dtpSayimEnd.Location = new Point(78, 80);
            dtpSayimEnd.Name = "dtpSayimEnd";
            dtpSayimEnd.Size = new Size(117, 23);
            dtpSayimEnd.TabIndex = 24;
            // 
            // dtpSayimStart
            // 
            dtpSayimStart.Enabled = false;
            dtpSayimStart.Format = DateTimePickerFormat.Short;
            dtpSayimStart.Location = new Point(78, 36);
            dtpSayimStart.Name = "dtpSayimStart";
            dtpSayimStart.Size = new Size(117, 23);
            dtpSayimStart.TabIndex = 23;
            // 
            // btnCreateSayimStoklarla
            // 
            btnCreateSayimStoklarla.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCreateSayimStoklarla.Location = new Point(79, 116);
            btnCreateSayimStoklarla.Name = "btnCreateSayimStoklarla";
            btnCreateSayimStoklarla.Size = new Size(116, 27);
            btnCreateSayimStoklarla.TabIndex = 25;
            btnCreateSayimStoklarla.Text = "Yarat";
            btnCreateSayimStoklarla.UseVisualStyleBackColor = true;
            btnCreateSayimStoklarla.Click += btnCreateSayimStoklarla_Click;
            // 
            // frmSayimPeriodYarat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 218);
            Controls.Add(btnCreateSayimStoklarla);
            Controls.Add(dtpSayimEnd);
            Controls.Add(dtpSayimStart);
            Name = "frmSayimPeriodYarat";
            Text = "frmSayimPeriodYarat";
            Load += frmSayimPeriodYarat_Load;
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpSayimEnd;
        private DateTimePicker dtpSayimStart;
        private Button btnCreateSayimStoklarla;
    }
}
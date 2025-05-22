using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_BACK_OFFICE
{
    public enum AlertType { Success, Warning, Info, Error }

    public class CustomAlertForm : Form
    {
        public CustomAlertForm(string title, string message, AlertType alertType = AlertType.Warning)
        {
            this.Width = 400;
            this.Height = 200;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;

            // Alert Type-a əsaslanaraq rəngləri dəyişirik
            if (alertType == AlertType.Success)
            {
                this.BackColor = Color.FromArgb(51, 204, 51); // Yaşıl tonlar (Uğurlu əməliyyat)
                title = "Uğurlu Əməliyyat"; // Başlıq "Uğurlu Əməliyyat"
            }
            else if (alertType == AlertType.Warning)
            {
                this.BackColor = Color.FromArgb(255, 51, 51); // Qırmızı ton (Xəta)
            }
            else if (alertType == AlertType.Info)
            {
                this.BackColor = Color.FromArgb(51, 153, 255); // Mavi ton (Məlumat)
            }
            else if (alertType == AlertType.Error)
            {
                this.BackColor = Color.FromArgb(204, 0, 0); // Tünd qırmızı (Xəta)
            }

            Label lblTitle = new Label()
            {
                Text = title,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.White,
                Dock = DockStyle.Top,
                Height = 50,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label lblMessage = new Label()
            {
                Text = message,
                Font = new Font("Segoe UI", 12),
                ForeColor = Color.WhiteSmoke,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Button btnClose = new Button()
            {
                Text = "OK",
                Dock = DockStyle.Bottom,
                Height = 40,
                BackColor = Color.White,
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat
            };
            btnClose.Click += (sender, e) => { this.Close(); };

            this.Controls.Add(lblMessage);
            this.Controls.Add(lblTitle);
            this.Controls.Add(btnClose);
        }

        // Static metod vasitəsilə alert göstərmək
        public static void ShowAlert(string title, string message, AlertType alertType = AlertType.Warning)
        {
            CustomAlertForm alert = new CustomAlertForm(title, message, alertType);
            alert.ShowDialog();
        }
    }

}

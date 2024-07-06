using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class EmailBUS
    {
        public void sendAdvertisedEmail(string email)
        {
            string fromEmail = "tidecareer@gmail.com";
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587; // port cua gmail
            string smtpUser = "tidecareer@gmail.com";
            string smtpPass = "urhr gjuw zazy yxqf"; // Mật khẩu ứng dụng đã tạo tren gmail

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);
                mail.To.Add(email);
                mail.Subject = "Please contract our Sales to extend our recruitment services!";
                mail.Body = $"Here is our sale's Information: https://www.facebook.com/profile.php?id=100037472770927";

                SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(smtpUser, smtpPass);
                smtpClient.EnableSsl = true;

                smtpClient.Send(mail);
                //MessageBox.Show("Email sent successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email. Error: {ex.Message}");
            }

        }
        public void sendMultiAdvertisedEmail(string[] emails)
        {
            string fromEmail = "tidecareer@gmail.com";
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587; // port cua gmail
            string smtpUser = "tidecareer@gmail.com";
            string smtpPass = "urhr gjuw zazy yxqf"; // Mật khẩu ứng dụng đã tạo tren gmail

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);

                foreach (string email in emails)
                {
                    mail.To.Add(email);
                }
                
                mail.Subject = "Please contract our Sales to extend our recruitment services!";
                mail.Body = $"Here is our sale's Information: https://www.facebook.com/profile.php?id=100037472770927";

                SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(smtpUser, smtpPass);
                smtpClient.EnableSsl = true;

                smtpClient.Send(mail);
                //MessageBox.Show("Email sent successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email. Error: {ex.Message}");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using ForgotPasswordDAO = DAO.ForgotPasswordDAO;
using System.Windows.Forms;

namespace BUS
{
    public class ForgotPasswordBUS
    {
        ForgotPasswordDAO forgotPasswordDAO = new ForgotPasswordDAO();
        public bool IsEmailExist(string email) => forgotPasswordDAO.IsEmailExist(email);
        public string GetPassword(string email) => forgotPasswordDAO.GetPassword(email);

        public void SendPassword(string email)
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
                mail.Subject = "Reset password Successfully!";
                mail.Body = $"Here is your password: {GetPassword(email)}";

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

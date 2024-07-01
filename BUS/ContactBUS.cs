using System;
using ContactDAO = DAO.ContactDAO;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Xml.Linq;

namespace BUS
{
    public class ContactBUS
    {
        ContactDAO contactDAO = new ContactDAO();
        public bool IsCompanyExist(string companyName)
        {
            return contactDAO.IsCompanyExist(companyName);
        }
        public bool IsEmailExist(string email)
        {
            return contactDAO.IsEmailExist(email);
        }

        public void InsertNewEmployer(string fullName, string workTittle, string workEmail, string phoneNumber, string cpnName, string cpnLocation, string taxCode) 
            => contactDAO.InsertNewEmployer(fullName, workTittle, workEmail, phoneNumber, cpnName, cpnLocation, taxCode);

        public void SendMailToEmployer(string workEmail, string password)
        {
            //// Thông tin email
            //string fromEmail = "tidecareer@gmail.com";
            //string toEmail = workEmail;
            //string subject = "Registered Successfully!";
            //string body = $"Thank you for choosing Career Tide! Here is your password: {password}";

            //// Thông tin SMTP
            //string smtpServer = "smtp.gmail.com";
            //int smtpPort = 587; // Cong SMTP cua Gmail
            //// Our email
            //string smtpUser = "tidecareer@gmail.com"; // Sử dụng cùng địa chỉ email
            //string smtpPass = "heongusi22"; // Mật khẩu của email
            string fromEmail = "tidecareer@gmail.com";
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;
            string smtpUser = "tidecareer@gmail.com";
            string smtpPass = "urhr gjuw zazy yxqf"; // Mật khẩu ứng dụng đã tạo tren gmail
                                            //try
                                            //{
                                            //    MailMessage mail = new MailMessage();
                                            //    mail.From = new MailAddress(fromEmail);
                                            //    mail.To.Add(toEmail);
                                            //    mail.Subject = subject;
                                            //    mail.Body = body;

            //    SmtpClient smtp = new SmtpClient(smtpServer, smtpPort);
            //    smtp.Credentials = new NetworkCredential(smtpUser, smtpPass);
            //    smtp.EnableSsl = true;

            //    smtp.Send(mail);
            //    //Console.WriteLine("Email sent successfully.");
            //    MessageBox.Show("Email sent successfully.");
            //}
            //catch (Exception ex)
            //{
            //    //Console.WriteLine("Failed to send email. Error: " + ex.Message);
            //    MessageBox.Show("Failed to send email. Error: " + ex.Message);
            //}
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);
                mail.To.Add(workEmail);
                mail.Subject = "Registered Successfully!";
                mail.Body = $"Thank you for choosing Career Tide! Here is your password: {password}";

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

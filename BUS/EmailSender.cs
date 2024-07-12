using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace BUS
{
    public class EmailSender
    {
        public static void SendEmailWithAttachment(string toEmail, string subject, string body, byte[] attachmentData, string attachmentName)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("tidecareer@gmail.com");
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;

                // Add attachment
                using (MemoryStream ms = new MemoryStream(attachmentData))
                {
                    Attachment attachment = new Attachment(ms, attachmentName, "application/pdf");
                    mail.Attachments.Add(attachment);

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential("tidecareer@gmail.com", "urhr gjuw zazy yxqf");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
            }
        }

        public static void SendEmail(string toEmail, string subject, string body)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("tidecareer@gmail.com");
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;


                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential("tidecareer@gmail.com", "urhr gjuw zazy yxqf");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                } 
            }
        }
    }
}

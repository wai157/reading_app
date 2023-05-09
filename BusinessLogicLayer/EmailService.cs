using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class EmailService
    {
        private int code;
        private string GenerateEmailBody()
        {
            Random rand = new Random();
            code = rand.Next(100000, 1000000);

            StringBuilder mailBody = new StringBuilder();
            mailBody.AppendFormat("<h3>Thân gửi bạn đọc,</h3>");
            mailBody.AppendFormat("<p>Mã xác thực tài khoản của bạn là:</p>");
            mailBody.AppendFormat("<big style=\"color: rgb(78, 164, 220)\"> " + code + "</big>");
            mailBody.AppendFormat("<p>Mã xác thực sẽ có hiệu lực trong vòng 30 phút.</p>");
            mailBody.AppendFormat("<p>Omega 3 team.</p>");
            mailBody.AppendFormat("<h5 style=\"color: rgb(119, 119, 119)\">Đây là email tự động. Vui lòng không trả lời email này.</p>");

            return mailBody.ToString();
        }

        public int SendEmail(string address)
        {
            string smtpHost = ConfigurationManager.AppSettings["SmtpHost"];
            int smtpPort = int.Parse(ConfigurationManager.AppSettings["SmtpPort"]);
            string smtpUsername = ConfigurationManager.AppSettings["SmtpUsername"];
            string smtpPassword = ConfigurationManager.AppSettings["SmtpPassword"];

            var message = new MailMessage();
            message.IsBodyHtml = true;
            message.To.Add(new MailAddress(address));
            message.Subject = "<noreply> Mã xác thực tài khoản";
            message.Body = GenerateEmailBody();
            message.From = new MailAddress(smtpUsername);

            // set up email client
            var smtpClient = new SmtpClient(smtpHost, smtpPort)
            {
                UseDefaultCredentials = false,
                EnableSsl = true
            };
            smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);

            // send email
            smtpClient.Send(message);
            return code;
        }
    }
}

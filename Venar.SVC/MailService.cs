using Venar.Entities;
using System.Collections.Specialized;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace Venar.SVC
{
    public class MailService
    {
        MailSettings settingsMail;

        public MailService()
        {
            var section = (NameValueCollection)ConfigurationManager.GetSection("MailSettings");
            settingsMail = new MailSettings(
                section["Server"], int.Parse(section["Port"]), section["FromName"],
                section["FromEmail"], section["UserName"], section["Password"]
            );
        }

        public void SendMail(MailData dataMail)
        {
            var mail = new MailMessage();
            mail.To.Add(dataMail.MailTo);
            mail.Subject = dataMail.Subject;
            mail.From = new MailAddress(settingsMail.FromEmail, settingsMail.FromName);
            mail.IsBodyHtml = true;
            mail.Body = dataMail.Body;

            //Nos Conectamos a Gmail
            var client = new SmtpClient();
            client.Host = settingsMail.Server;
            client.Port = settingsMail.Port;
            client.Credentials = new NetworkCredential(settingsMail.UserName,
                settingsMail.Password);
            client.EnableSsl = true;

            //Enviamos el correo
            client.Send(mail);

            client.Dispose();

        }
    }
}

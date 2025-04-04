using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TestMail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MailServer
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.Credentials = new System.Net.NetworkCredential("webshopnassen@gmail.com", "qiqs wsuu xtaq glzq");  //Google App Password
            smtpClient.EnableSsl = true;

            //MailBericht
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("webshopnassen@gmail.com");
            mailMessage.To.Add("ludwig.nassen@hasp-o.be");
            mailMessage.Subject = "Testmail";
            mailMessage.Body = "Dit is een test\n Tot ziens!";

            //versturen
            smtpClient.Send(mailMessage);
        }
    }
}

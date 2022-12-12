using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace email_test
{

    internal class Program
    {
        static void Main(string[] args)
        {

            string fromMail = "claudiopractica87@gmail.com";
            string fromPassword = "gkmjurzoppscgdnb";
            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "Test Subject";
            message.To.Add(new MailAddress("Claudio.corteslsf@gmail.com"));
            message.Body = "<html><body> Hola tu código de seguridad es el siguiente:  </body></html>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };
            smtpClient.Send(message);
            ;
            Console.WriteLine("Hola, este es un mensaje para hacer un commit");
        
        }
    }







    /**
     * 
     * 
   
     */

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using Microsoft.VisualBasic;
using System.Net;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Utill
{
    public class SendMail
    {
        public void SendEmail(string toAddress, string attach)
        {


            Random rn = new Random();
            int no = rn.Next(1000, 2000);
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            SmtpServer.UseDefaultCredentials = true;
            mail.From = new MailAddress("onlinerentingapp@gmail.com"); // From

            mail.To.Add(toAddress);// To

            mail.Attachments.Add(new Attachment(@attach));
            //System.Net.Mail.Attachment attachment;
            //attachment = new System.Net.Mail.Attachment("Test.txt");
            //mail.Attachments.Add(attachment);


            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("onlinerentingapp@gmail.com", "Autogreen");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }
    }
}
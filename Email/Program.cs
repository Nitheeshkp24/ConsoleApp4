using Microsoft.VisualBasic;
using System;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;

namespace Email
{

    public class Email
    {
        public void SendEmail(string toAddress, string msg, string subject,string attach)
        {
            //Random rn = new Random();
            //int otp = rn.Next(1000);
            //string OTP = otp.ToString();


            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            SmtpServer.UseDefaultCredentials = true;
            mail.From = new MailAddress("onlinerentingapp@gmail.com"); // From

            mail.To.Add(toAddress);// To
            mail.Subject = subject;
            mail.Body = msg;
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



    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Email");
            string To = Console.ReadLine();
            Console.WriteLine("Enter Sub");
            string sub = Console.ReadLine();
            Console.WriteLine("Enter msg");
            string msg = Console.ReadLine();
            Console.WriteLine("attachment location");
            string attach = Console.ReadLine();

            Email ob = new Email();
            ob.SendEmail(To, msg, sub,attach);



            Console.WriteLine("Done");

            Console.ReadLine();
        }
    }
}
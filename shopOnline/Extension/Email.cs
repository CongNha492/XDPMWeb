using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace shopOnline.Extension
{
    public class Email
    {
        static SmtpClient smtpClient = new SmtpClient("smtp.yandex.com")
        {
            Port = 587,
            Credentials = new NetworkCredential("shoponlineaspnet@ducvu2002.tk", "auxltnexyxbiqcwx"),
            EnableSsl = true,
        };

        public static void sendMail(string email, string subject, string body)
        {
            try
            {
                smtpClient.Send("shoponlineaspnet@ducvu2002.tk", email, subject, body);
            } catch { }
        }
    }
}

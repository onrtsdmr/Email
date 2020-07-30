using System;
using System.Net;
using System.Net.Mail;

namespace EmailService.Extensions
{
    public static class Email
    {
        public static void EmailSend(this string mailTo)
        {
            try
            {
                var to = new MailAddress(mailTo);

                var from = new MailAddress(Strings.Email.UserName);

                var mail = new MailMessage(from, to)
                {
                    Subject = Strings.Email.Subject,
                    Body = Strings.Email.HtmlBody,
                    IsBodyHtml = true
                };


                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    Credentials = new NetworkCredential(
                        Strings.Email.UserName, Strings.Email.Password),
                    EnableSsl = true
                };
                smtp.Send(mail);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
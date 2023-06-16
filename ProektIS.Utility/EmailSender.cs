using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektIS.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //var emailToSend = new MimeKit.MimeMessage();
            //emailToSend.From.Add(MimeKit.MailboxAddress.Parse("Zdravo@proektis.com"));
            //emailToSend.To.Add(MimeKit.MailboxAddress.Parse(email));
            //emailToSend.Subject = subject;
            //emailToSend.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = htmlMessage };

            ////prati mail

            //using (var emailClinet = new SmtpClient())
            //{
            //    emailClinet.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
            //    emailClinet.Authenticate("proektis@outlook.com", "Proekt1@");
            //    emailClinet.Send(emailToSend);
            //    emailClinet.Disconnect(true);
            //}
            return Task.CompletedTask;
        }
    }
}

using Microsoft.AspNetCore.Identity.UI.Services;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlCenter.WebUI.EmailServices
{
    public class EmailSender : IEmailSender
    {//

        //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
        private const string SendGridKey = "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";
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(SendGridKey, subject, htmlMessage, email);
        }

        private Task Execute(string sendGridKey, string subject, string message, string email)
        {
            var client = new SendGridClient(sendGridKey);

            var msg = new SendGridMessage()
            {
                From = new EmailAddress("info.responsivesoft@gmail.com", "RESPONSIVE SOFT"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message,
            };
            msg.AddTo(new EmailAddress(email));
            return client.SendEmailAsync(msg);
        }
    }
}

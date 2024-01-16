using Microsoft.AspNetCore.Identity.UI.Services;

namespace WebProjectMVC.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // Email gönderme işleri olacaksa buraya yazılır
            return Task.CompletedTask;
        }
    }
}

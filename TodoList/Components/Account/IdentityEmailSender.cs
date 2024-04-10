using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using TodoList.Data;


namespace TodoList.Components.Account
{
    // Remove the "else if (EmailSender is IdentityNoOpEmailSender)" block from RegisterConfirmation.razor after updating with a real implementation.
    internal sealed class IdentityEmailSender : IEmailSender<ApplicationUser>, IEmailSender
    {
        private readonly IEmailSender _emailSender;

        public IdentityEmailSender(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }
        public Task SendMailAsync(string email,string subject, string message) =>
            _emailSender.SendEmailAsync(email, subject, message);
        public Task SendConfirmationLinkAsync(ApplicationUser user, string email, string confirmationLink) =>
            _emailSender.SendEmailAsync(email, "Confirm your email", $"Please confirm your account by <a href='{confirmationLink}'>clicking here</a>.");

        public Task SendPasswordResetLinkAsync(ApplicationUser user, string email, string resetLink) =>
            _emailSender.SendEmailAsync(email, "Reset your password", $"Please reset your password by <a href='{resetLink}'>clicking here</a>.");

        public Task SendPasswordResetCodeAsync(ApplicationUser user, string email, string resetCode) =>
            _emailSender.SendEmailAsync(email, "Reset your password", $"Please reset your password using the following code: {resetCode}");

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return _emailSender.SendEmailAsync(email, subject, htmlMessage);
        }
    }


}

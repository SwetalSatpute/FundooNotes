
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;

/// <summary>
/// Email service class implement interface
/// </summary>
/// <seealso cref="FundooNotes.Interfaces.IEmailSender" />
public class EmailService : IEmailSender
{
    /// <summary>
    /// The email settings
    /// </summary>
    private readonly EmailSettings emailSettings;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmailService"/> class.
    /// </summary>
    /// <param name="emailSettings">The email settings.</param>
    public EmailService(IOptions<EmailSettings> emailSettings)
    {
        this.emailSettings = emailSettings.Value;
    }

    /// <summary>
    /// Sends the email asynchronous.
    /// </summary>
    /// <param name="email">The email.</param>
    /// <param name="subject">The subject.</param>
    /// <param name="message">The message.</param>
    /// <returns>
    /// return status code
    /// </returns>
    /// <exception cref="InvalidOperationException">exception generated</exception>
    public Task SendEmailAsync(string email, string subject, string message)
    {
        try
        {
            var credentials = new NetworkCredential(this.emailSettings.UserID, this.emailSettings.Password);
            var mail = new MailMessage()
            {
                From = new MailAddress(this.emailSettings.UserID, this.emailSettings.FromAddress),
                Subject = subject,
                Body = message,
                IsBodyHtml = true
            };
            mail.To.Add(new MailAddress(email));

            var client = new SmtpClient()
            {
                Port = this.emailSettings.SMTPPort,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = this.emailSettings.SmtpClient,
                EnableSsl = true,
                Credentials = credentials
            };

            //// sending mail
            client.Send(mail);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException(ex.Message);
        }

        return Task.CompletedTask;
    }
}
//-----------------------------------------------------------------------
// <copyright file="EmailService.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Fundoo.Common.Models;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;

/// <summary>
/// Email service class implement interface
/// </summary>
/// <seealso cref="FundooNotes.Interfaces.IEmailSender" />
public class EmailService : Fundoo.Common.Models.IEmailSender
{
    /// <summary>
    /// The email settings
    /// </summary>
    private readonly EmailModel emailSetting;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmailService"/> class.
    /// </summary>
    /// <param name="emailSettings">The email settings.</param>
    public EmailService(IOptions<EmailModel> emailSettings)
    {
        this.emailSetting = emailSettings.Value;
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
            var credentials = new NetworkCredential(this.emailSetting.UserID, this.emailSetting.Password);
            var mail = new MailMessage()
            {
                From = new MailAddress(this.emailSetting.UserID, this.emailSetting.FromAddress),
                Subject = subject,
                Body = message,
                IsBodyHtml = true
            };
            mail.To.Add(new MailAddress(email));

            var client = new SmtpClient()
            {
                Port = this.emailSetting.SMTPPort,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = this.emailSetting.SmtpClient,
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
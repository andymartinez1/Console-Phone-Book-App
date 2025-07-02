using System.Net;
using System.Net.Mail;
using Spectre.Console;

namespace Phone_Book.Services;

public class MailMessage
{
    public static void SendEmail()
    {
        string toEmail = ContactService.GetContactByEmail();
        string subject = AnsiConsole.Ask<string>("Subject: ", "");
        string body = AnsiConsole.Ask<string>("Mail: ");

        var fromAddress = new MailAddress("youraddress@example.com", "Your Name");
        var toAddress = new MailAddress(toEmail);
        const string fromPassword = "yourpassword";

        var smtp = new SmtpClient
        {
            Host = "smtp.example.com",
            Port = 587,
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
        };

        using var message = new System.Net.Mail.MailMessage(fromAddress, toAddress)
        {
            Subject = subject,
            Body = body,
            IsBodyHtml = false,
        };
        smtp.Send(message);
    }
}

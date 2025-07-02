using MimeKit;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace Phone_Book.Services;

public class MailMessage
{
    public static void SendEmail()
    {
        var email = new MimeMessage();

        email.From.Add(new MailboxAddress("Sender Name", "sender@email.com"));
        email.To.Add(new MailboxAddress("Receiver Name", "receiver@email.com"));

        email.Subject = "Testing out email sending";
        email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
        {
            Text = "<b>Hello all the way from the land of C#</b>",
        };

        using (var smtp = new SmtpClient())
        {
            smtp.Connect("smtp.gmail.com", 587);

            // Note: only needed if the SMTP server requires authentication
            smtp.Authenticate("smtp_username", "smtp_password");

            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}

using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;

// create email message
var email = new MimeMessage();
email.From.Add(MailboxAddress.Parse("viet99cm@gmail.com"));
email.To.Add(MailboxAddress.Parse("mailtocm@gmail.com"));
email.Subject = "Test Email Subject";
email.Body = new TextPart(TextFormat.Plain) { Text = "Ví dụ Nội dung tin nhắn văn bản thuần túy" };

// send email
try
{
    using var smtp = new SmtpClient();
    smtp.Connect("smtp-relay.sendinblue.com", 465, SecureSocketOptions.Auto);
    smtp.Authenticate("viet99cm@gmail.com", "36vDRcNH9SK2Vn48");
    smtp.Send(email);
    smtp.Disconnect(true);
    Console.WriteLine("Gửi mail thành công.");
}
catch (Exception)
{
    Console.WriteLine("Gửi mail thất bại.");
}

using System.Net;
using System.Net.Mail;


var client = new SmtpClient("smtp.gmail.com", 587);
client.DeliveryMethod = SmtpDeliveryMethod.Network;

client.EnableSsl = true;

client.Credentials = new NetworkCredential(userName: "MenSyen", password: "svmf sdfs okgv qipg" ;

var message = new MailMessage()
{
    Body = "Hello",
    Subject = "Test",
    From = new MailAddress("haciyevtaleh1999@gmail.com", "cry of silence")
};

message.To.Add("nonameless@gmail.com");
message.CC.Add("hesenhacizade2@gmail.com");


client.Send(message);   
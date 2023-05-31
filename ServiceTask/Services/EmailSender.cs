using ServiceTask.Models;
using System.Net;
using System.Net.Mail;
using System.Reflection.Metadata;

namespace ServiceTask.Services
{
    public class EmailSender:IEmailSender
    {
        public Task SendEmailAsync(UserInfo userInfo)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl=true,
                UseDefaultCredentials=false,
                Credentials=new NetworkCredential("Saraabdallat99@gmail.com", "gkkvjjbnechdcbwn")
            };
            return client.SendMailAsync(
                new MailMessage(from: "Saraabdallat99@gmail.com",
                to:userInfo.email,
                userInfo.subject="Service Info",
                userInfo.message="Your Name:"+userInfo.name+" and You Mobile is"+userInfo.mobile+" You Choose this service:"+userInfo.service+"you are intrest in:"+userInfo.intrested
                    )
                );
        }
    }
}

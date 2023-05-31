using ServiceTask.Models;

namespace ServiceTask.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(UserInfo userInfo);
    }
}

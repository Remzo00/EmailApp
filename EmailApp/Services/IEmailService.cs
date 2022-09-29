using EmailApp.Models;

namespace EmailApp.Services
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}

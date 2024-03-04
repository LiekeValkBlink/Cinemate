using Cinemate.EmailSender.Models;

namespace Cinemate.EmailSender.Services.EmailServices
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}

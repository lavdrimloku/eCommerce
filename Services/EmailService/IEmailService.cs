using ecommerce_1.Data;

namespace SimpleEmailApp.Services.EmailService
{
    public interface IEmailService
    {
        void SendEmail(EmailConfiguration request);
    }
}

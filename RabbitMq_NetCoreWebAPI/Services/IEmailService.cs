using RabbitMq_NetCoreWebAPI.Models;

namespace RabbitMq_NetCoreWebAPI.Services
{
    public interface IEmailService
    {
        public IEnumerable<Email> GetEmailList();
        public Email GetEmailById(int id);
        public Email GetEmailByEmailType(Enums.Enums.emailTypes enumType);
        public Email AddEmail(Email email);
        public Email UpdateEmail(Email email);
        public bool DeleteEmail(int Id);
    }
}

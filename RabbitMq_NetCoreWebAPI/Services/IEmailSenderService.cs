using RabbitMq_NetCoreWebAPI.Models;

namespace RabbitMq_NetCoreWebAPI.Services
{
    public interface IEmailSenderService
    {
        public List<Customer> SendEmail(Email email, List<Customer> customer);
 
    }
}

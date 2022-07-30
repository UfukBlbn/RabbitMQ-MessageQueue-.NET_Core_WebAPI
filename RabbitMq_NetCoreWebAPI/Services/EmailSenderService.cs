using RabbitMq_NetCoreWebAPI.Data;
using RabbitMq_NetCoreWebAPI.Models;

namespace RabbitMq_NetCoreWebAPI.Services
{
    public class EmailSenderService : IEmailSenderService
    {
        private readonly DbContextClass _dbContext;
        public EmailSenderService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Customer> SendEmail(Email email, List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                customer.RecievedEmails.Add(email);
            }
            return customers;
        }
    }
}

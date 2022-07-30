using RabbitMq_NetCoreWebAPI.Data;
using RabbitMq_NetCoreWebAPI.Models;

namespace RabbitMq_NetCoreWebAPI.Services
{
    public class EmailService : IEmailService
    {
        private readonly DbContextClass _dbContext;
        public EmailService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public Email AddEmail(Email email)
        {
            var result = _dbContext.Emails.Add(email);
            _dbContext.SaveChanges();
            return result.Entity;
        }

        public bool DeleteEmail(int Id)
        {
            var filteredData = _dbContext.Emails.Where(x => x.EmailId == Id).FirstOrDefault();
            var result = _dbContext.Remove(filteredData);
            _dbContext.SaveChanges();
            return result != null ? true : false;
        }

        public Email GetEmailByEmailType(Enums.Enums.emailTypes enumType)
        {
            return _dbContext.Emails.Where(x => x.EmailType.Equals(enumType)).FirstOrDefault();
        }

        public Email GetEmailById(int id)
        {
            return _dbContext.Emails.Where(x => x.EmailId == id).FirstOrDefault();
        }

        public IEnumerable<Email> GetEmailList()
        {
            return _dbContext.Emails.ToList();
        }

        public Email UpdateEmail(Email email)
        {
            var result = _dbContext.Emails.Update(email);
            _dbContext.SaveChanges();
            return result.Entity;
        }
    }
}

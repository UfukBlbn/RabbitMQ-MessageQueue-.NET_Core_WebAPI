using RabbitMq_NetCoreWebAPI.Data;
using RabbitMq_NetCoreWebAPI.Models;

namespace RabbitMq_NetCoreWebAPI.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly DbContextClass _dbContext;
        public CustomerService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public Customer AddCustomer(Customer customer)
        {
            var result = _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
            return result.Entity;
        }

        public bool DeleteCustomer(int Id)
        {
            var filteredData = _dbContext.Customers.Where(x => x.CustomerId == Id).FirstOrDefault();
            var result = _dbContext.Remove(filteredData);
            _dbContext.SaveChanges();
            return result != null ? true : false;
        }

        public Customer GetCustomerById(int id)
        {
            return _dbContext.Customers.Where(x => x.CustomerId == id).FirstOrDefault();

        }

        public IEnumerable<Customer> GetCustomerList()
        {
            return _dbContext.Customers.ToList();
        }

       

        public Customer UpdateCustomer(Customer customer)
        {
            var result = _dbContext.Customers.Update(customer);
            _dbContext.SaveChanges();
            return result.Entity;
        }

        public List<Customer> GetSendEmailAcceptedCustomerList()
        {
            return _dbContext.Customers.Where(x => x.IsAcceptEmail == true).ToList();
        }

        public List<Customer> GetCustomersByCustomerType(Enums.Enums.customerTypes enumType)
        {
            return _dbContext.Customers.Where(x => x.CustomerType.Equals(enumType) && x.IsAcceptEmail == true).ToList();
        }
    }
}

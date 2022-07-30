using RabbitMq_NetCoreWebAPI.Models;

namespace RabbitMq_NetCoreWebAPI.Services
{
    public interface ICustomerService
    {
        public IEnumerable<Customer> GetCustomerList();
        public List<Customer> GetSendEmailAcceptedCustomerList();
        public List<Customer> GetCustomersByCustomerType(Enums.Enums.customerTypes enumType);
        public Customer GetCustomerById(int id);
        public Customer AddCustomer(Customer customer);
        public Customer UpdateCustomer(Customer customer);
        public bool DeleteCustomer(int Id);
    }
}

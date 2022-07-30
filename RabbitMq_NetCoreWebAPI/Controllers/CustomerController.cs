using Microsoft.AspNetCore.Mvc;
using RabbitMq_NetCoreWebAPI.Models;
using RabbitMq_NetCoreWebAPI.RabbitMq;
using RabbitMq_NetCoreWebAPI.Services;

namespace RabbitMq_NetCoreWebAPI.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService customerService;
        private readonly IRabbitMqProducer _rabbitMqProducer;
        public CustomerController(ICustomerService _customerService, IRabbitMqProducer rabbitMqProducer)
        {
            customerService = _customerService;
            _rabbitMqProducer = rabbitMqProducer;
        }
        [HttpGet("customerlist")]
        public IEnumerable<Customer> CustomerList()
        {
            var customerList = customerService.GetCustomerList();
            return customerList;
        }
        [HttpGet("getCustomerbyid")]
        public Customer GetCustomerById(int Id)
        {
            return customerService.GetCustomerById(Id);
        }
        [HttpPost("addCustomer")]
        public Customer AddCustomer(Customer customer)
        {
            var customerData = customerService.AddCustomer(customer);
 
            return customerData;
        }
        [HttpPut("updateCustomer")]
        public Customer UpdateCustomer(Customer customer)
        {
            return customerService.UpdateCustomer(customer);
        }
        [HttpDelete("deleteCustomer")]
        public bool DeleteCustomer(int Id)
        {
            return customerService.DeleteCustomer(Id);
        }
    }
}

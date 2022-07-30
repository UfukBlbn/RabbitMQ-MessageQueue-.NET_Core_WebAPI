using Microsoft.AspNetCore.Mvc;
using RabbitMq_NetCoreWebAPI.Models;
using RabbitMq_NetCoreWebAPI.Models.ApıRequest;
using RabbitMq_NetCoreWebAPI.RabbitMq;
using RabbitMq_NetCoreWebAPI.Services;

namespace RabbitMq_NetCoreWebAPI.Controllers
{
    public class EmailSenderController : Controller
    {
        private readonly IProductService productService;
        private readonly IRabbitMqProducer _rabbitMqProducer;
        private readonly ICustomerService _customerService;
        private readonly IEmailService _emailService;
        private readonly IEmailSenderService _emailSenderService;
        public EmailSenderController(IProductService _productService, IEmailService emailService, IRabbitMqProducer rabbitMqProducer, ICustomerService customerService, IEmailSenderService emailSenderService)
        {
            productService = _productService;
            _rabbitMqProducer = rabbitMqProducer;
            _customerService = customerService;
            _emailService = emailService;
            _emailSenderService = emailSenderService;
        }

        [HttpPost("sendEmail")]
        public BaseResponse<SendEmailResponse> SendEmail(SendEmailRequest request)
        {
            var targetEmailTemplate = _emailService.GetEmailByEmailType(request.EmailType);
            var targetCustomers = _customerService.GetCustomersByCustomerType(request.CustomerType);
            var sendedCustomers = _emailSenderService.SendEmail(targetEmailTemplate, targetCustomers);
            var response = new SendEmailResponse();
            foreach (var sendedCustomer in sendedCustomers)
            {
                response.EmailRecievedCustomers.Add(sendedCustomer);
               
            }

            //send the inserted email data to the queue and consumer will listening this data from queue
            _rabbitMqProducer.SendProductMessage(sendedCustomers);
            return BaseResponse<SendEmailResponse>.returnSuccess(null);


        }



    }
}

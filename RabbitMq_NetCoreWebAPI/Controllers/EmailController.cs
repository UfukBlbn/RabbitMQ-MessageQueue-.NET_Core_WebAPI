using Microsoft.AspNetCore.Mvc;
using RabbitMq_NetCoreWebAPI.Models;
using RabbitMq_NetCoreWebAPI.RabbitMq;
using RabbitMq_NetCoreWebAPI.Services;

namespace RabbitMq_NetCoreWebAPI.Controllers
{
    public class EmailController : Controller
    {
        private readonly IEmailService emailService;
        private readonly IRabbitMqProducer _rabbitMqProducer;
        public EmailController(IEmailService _emailService, IRabbitMqProducer rabbitMqProducer)
        {
            emailService = _emailService;
            _rabbitMqProducer = rabbitMqProducer;
        }
        [HttpGet("Emaillist")]
        public IEnumerable<Email> EmailList()
        {
            var emailList = emailService.GetEmailList();
            return emailList;
        }
        [HttpGet("getEmailbyid")]
        public Email GetEmailById(int Id)
        {
            return emailService.GetEmailById(Id);
        }
        [HttpPost("addEmail")]
        public Email AddEmail(Email email)
        {
            var emailData = emailService.AddEmail(email);
            //send the inserted Email data to the queue and consumer will listening this data from queue
            _rabbitMqProducer.SendEmailMessage(emailData);
            return emailData;
        }
        [HttpPut("updateEmail")]
        public Email UpdateEmail(Email email)
        {
            return emailService.UpdateEmail(email);
        }
        [HttpDelete("deleteEmail")]
        public bool DeleteEmail(int Id)
        {
            return emailService.DeleteEmail(Id);
        }
    }
}

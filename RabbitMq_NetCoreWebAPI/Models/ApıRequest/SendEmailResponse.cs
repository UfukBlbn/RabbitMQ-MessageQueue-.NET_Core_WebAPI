namespace RabbitMq_NetCoreWebAPI.Models.ApıRequest
{
    public class SendEmailResponse
    {
        public List<Customer> EmailRecievedCustomers { get; set; } = new List<Customer>();
    }
}

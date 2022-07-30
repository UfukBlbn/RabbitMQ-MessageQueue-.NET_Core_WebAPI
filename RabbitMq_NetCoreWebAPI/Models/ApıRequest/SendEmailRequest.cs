namespace RabbitMq_NetCoreWebAPI.Models.ApıRequest
{
    public class SendEmailRequest
    {
        public Enums.Enums.emailTypes EmailType { get; set; }
        public Enums.Enums.customerTypes CustomerType { get; set; }

    }
}

namespace RabbitMq_NetCoreWebAPI.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public Enums.Enums.customerTypes CustomerType { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public bool IsAcceptEmail { get; set; }
        public bool IsAccepSms { get; set; }
        public List<Email> RecievedEmails { get; set; } = new List<Email>();
    }
}

namespace RabbitMq_NetCoreWebAPI.Models
{
    public class Email
    {
        public int EmailId { get; set; }
        public string EmailSubject { get; set; }
        public string EmailTitle { get; set; }
        public string EmailContent { get; set; }
        public Enums.Enums.emailTypes EmailType { get; set; }
        public DateTime SendDate { get; set; }
    

    }
}

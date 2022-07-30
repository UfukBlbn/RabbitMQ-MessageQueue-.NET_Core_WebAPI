namespace RabbitMq_NetCoreWebAPI.RabbitMq
{
    public interface IRabbitMqProducer
    {
        public void SendProductMessage<T>(T message);
        public void SendEmailMessage<T>(T message);
    }
}

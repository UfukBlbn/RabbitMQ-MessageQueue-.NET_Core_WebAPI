﻿namespace RabbitMq_NetCoreWebAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
       
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        
        public int ProductPrice { get; set; }
       
        public int ProductStock { get; set; }
 
    }
}

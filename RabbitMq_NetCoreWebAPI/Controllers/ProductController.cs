 using Microsoft.AspNetCore.Mvc;
using RabbitMq_NetCoreWebAPI.Models;
using RabbitMq_NetCoreWebAPI.RabbitMq;
using RabbitMq_NetCoreWebAPI.Services;

namespace RabbitMq_NetCoreWebAPI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly IRabbitMqProducer _rabbitMqProducer;
        public ProductController(IProductService _productService, IRabbitMqProducer rabbitMqProducer)
        {
            productService = _productService;
            _rabbitMqProducer = rabbitMqProducer;
        }
        [HttpGet("productlist")]
        public IEnumerable<Product> ProductList()
        {
            var productList = productService.GetProductList();
            return productList;
        }
        [HttpGet("getproductbyid")]
        public Product GetProductById(int Id)
        {
            return productService.GetProductById(Id);
        }
        [HttpPost("addproduct")]
        public Product AddProduct(Product product)
        {
            var productData = productService.AddProduct(product);
            //send the inserted product data to the queue and consumer will listening this data from queue
            _rabbitMqProducer.SendProductMessage(productData);
            return productData;
        }
        [HttpPut("updateproduct")]
        public Product UpdateProduct(Product product)
        {
            return productService.UpdateProduct(product);
        }
        [HttpDelete("deleteproduct")]
        public bool DeleteProduct(int Id)
        {
            return productService.DeleteProduct(Id);
        }
    }

}

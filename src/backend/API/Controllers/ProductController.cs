using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private static readonly string[] ProductNames = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private Dictionary<string, Category> Categories = new Dictionary<string, Category>() {
            {"computer mouse",new Category{Name="computer mouse", 
            Description="The accessory to control pointer on any screen device, can be usb or wireless",}},
              {"keyboard",new Category{Name="keyboard", 
            Description="The accessory to be able to type on any screen device, can be usb or wireless"}},
        };

        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Product(ProductNames[index] + ProductNames[ProductNames.Length - index])
            {
                Detail = new ProductDetail{Description=$"The best description of any product ever"},
                Category = Categories["computer mouse"],
            })
            .ToArray();
        }
    }
}

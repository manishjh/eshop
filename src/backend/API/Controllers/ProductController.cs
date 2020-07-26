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
        //temporarily have categories added like this.
        private static Dictionary<string, Category> Categories = new Dictionary<string, Category>() {
            {"computer mouse",new Category{Name="computer mouse",
            Description="The accessory to control pointer on any screen device, can be usb or wireless",}},
              {"keyboard",new Category{Name="keyboard",
            Description="The accessory to be able to type on any screen device, can be usb or wireless"}},
        };

        //temporarily add products like this.
        private static Dictionary<string, Product> Products = new Dictionary<string, Product>(){
            {"product 1", new Product("product 1"){
                            Category = Categories["computer mouse"],
                            Inventory = null,
                            Detail = new ProductDetail{
                                        Description = "The best description of any product ever",
                                        },
                            }
            },
              {"product 2", new Product("product 2"){
                            Category = Categories["computer mouse"],
                            Inventory = null,
                            Detail = new ProductDetail{
                                        Description = "The best description of any product ever",
                                        },
                            }
            },
              {"product 3", new Product("product 3"){
                            Category = Categories["computer mouse"],
                            Inventory = null,
                            Detail = new ProductDetail{
                                        Description = "The best description of any product ever",
                                        },
                            }
            },
              {"product 4", new Product("product 4"){
                            Category = Categories["computer mouse"],
                            Inventory = null,
                            Detail = new ProductDetail{
                                        Description = "The best description of any product ever",
                                        },
                            }
            },
              {"product 5", new Product("product 5"){
                            Category = Categories["computer mouse"],
                            Inventory = null,
                            Detail = new ProductDetail{
                                        Description = "The best description of any product ever",
                                        },
                            }
            },
              {"product 6", new Product("product 6"){
                            Category = Categories["computer mouse"],
                            Inventory = null,
                            Detail = new ProductDetail{
                                        Description = "The best description of any product ever",
                                        },
                            }
            },
              {"product 7", new Product("product 7"){
                            Category = Categories["computer mouse"],
                            Inventory = null,
                            Detail = new ProductDetail{
                                        Description = "The best description of any product ever",
                                        },
                            }
            },
              {"product 8", new Product("product 8"){
                            Category = Categories["computer mouse"],
                            Inventory = null,
                            Detail = new ProductDetail{
                                        Description = "The best description of any product ever",
                                        },
                            }
            },
              {"product 9", new Product("product 9"){
                            Category = Categories["computer mouse"],
                            Inventory = null,
                            Detail = new ProductDetail{
                                        Description = "The best description of any product ever",
                                        },
                            }
            },
              {"product 10", new Product("product 10"){
                            Category = Categories["computer mouse"],
                            Inventory = null,
                            Detail = new ProductDetail{
                                        Description = "The best description of any product ever",
                                        },
                            }
            },
              {"product 11", new Product("product 11"){
                            Category = Categories["computer mouse"],
                            Inventory = null,
                            Detail = new ProductDetail{
                                        Description = "The best description of any product ever",
                                        },
                            }
            },
              {"product 12", new Product("product 12"){
                            Category = Categories["computer mouse"],
                            Inventory = null,
                            Detail = new ProductDetail{
                                        Description = "The best description of any product ever",
                                        },
                            }
            },         
        };

        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> Get(int id = 0)
        {
            return Products.Skip(id * 5).Take(5).Select(x => x.Value).ToArray();
        }
    }
}

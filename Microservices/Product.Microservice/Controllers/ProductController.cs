using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Product.Microservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet("getProdcut")]
        public ActionResult<IEnumerable<string>> Get()
        {
            Product product  = GetDummyData();
            return Ok(product);
        }
        private Product GetDummyData()
        {
            Product product = new Product
            {
                Id = 1,
                Name = "iPhone",
                Price = "4999 AED"
            };
            return product;
        }
    }
}

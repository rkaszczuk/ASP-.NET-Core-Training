using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public IActionResult GetProductList()
        {
            return Ok(productService.GetProductsList());
        }
    }
}
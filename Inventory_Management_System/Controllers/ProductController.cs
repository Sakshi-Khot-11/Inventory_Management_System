using Inventory_Management_System.Services;
    using Microsoft.AspNetCore.Mvc;

namespace Inventory_Management_System.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController:ControllerBase
    {
        private readonly ProductServices _store;
        public ProductController(ProductServices productServices)
        {
            _store = productServices;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _store.GetAllProducts();
            return Ok(products);
        }
            
       
    }
}

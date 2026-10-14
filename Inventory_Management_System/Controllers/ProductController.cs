using Inventory_Management_System.Services;
 using Microsoft.AspNetCore.Mvc;
using Inventory_Management_System.Models;

namespace Inventory_Management_System.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
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

        [HttpPost]
        public IActionResult PostProducts(Product product) {
            if (_store.products.Any(p => p.ID == product.ID))
                return Conflict("Product ID already exists ");
            _store.products.Add(product);
            return Ok(product);


        }
        [HttpPut("{id:int}")]
        public IActionResult PutProducts(int id,Product updatedProduct)
        {
            var product = _store.products.FirstOrDefault(p => p.ID == id);

            if (product == null)
                return NotFound("Product is not available");
            product.Name = updatedProduct.Name;
            product.Stock = updatedProduct.Stock;
            product.Price = updatedProduct.Price;
            return Ok(product);
        }


       
    }
}

using Inventory_Management_System.Models;

namespace Inventory_Management_System.Services

{
    public class ProductServices
    {
        public List<Product> products = new List<Product>
    {
        new Product
        {
            ID=1,
            Name="Laptop",
            Stock=2,
            Price=50000,
        },
        new Product
        {
            ID=2,
            Name="Mobile",
            Stock=8,
            Price=20000,
        },
        new Product
        {
            ID=3,
            Name="Headphone",
            Stock=20,
            Price=1000,
        },
        new Product
        {
            ID=4,
            Name="LED",
            Stock=8,
            Price=25000,
        },
    };
        public List<Product> GetAllProducts()
        {
            return products;
        }
    }
}

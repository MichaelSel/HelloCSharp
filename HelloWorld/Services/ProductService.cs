using HelloWorld.Interfaces;
using HelloWorld.Models;
using HelloWorld.Defaults;
namespace HelloWorld.Services
{
    public class ProductService : IProductService
    {
        public IEnumerable<Product> GetAllProducts()
        {
            return new List<Product> { new Product { Id = 1, Name = "Sample Product", Price = ProductDefaults.DefaultPrice } };
        }

        public Product GetProductById(int id)
        {
            return new Product { Id = id, Name = "Sample Product", Price = 10.99M };
        }
    }
}
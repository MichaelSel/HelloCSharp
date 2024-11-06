using HelloWorld.Interfaces;
using HelloWorld.Models;

namespace HelloWorld.Services
{
    public class ProductService : IProductService
    {
        public IEnumerable<Product> GetAllProducts()
        {
            return new List<Product> { new Product { Id = 1, Name = "Sample Product", Price = 10.99M } };
        }

        public Product GetProductById(int id)
        {
            return new Product { Id = id, Name = "Sample Product", Price = 10.99M };
        }
    }
}
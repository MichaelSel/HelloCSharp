using HelloWorld.Models;

namespace HelloWorld.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
    }
}
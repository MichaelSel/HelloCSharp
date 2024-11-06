using HelloWorld.Models;

namespace HelloWorld.Interfaces
{
    /*
     * This interface defines the methods that a ProductService class must implement
     * It's comparable to a TypeScript interface
     */
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
    }
}
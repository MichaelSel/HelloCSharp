using HelloWorld.Defaults;

namespace HelloWorld.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; } = ProductDefaults.DefaultPrice; // Using a default value defined in ProductDefaults
    }
}
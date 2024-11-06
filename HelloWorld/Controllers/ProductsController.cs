using HelloWorld.Attributes;
using HelloWorld.Interfaces;
using Microsoft.AspNetCore.Mvc;
using HelloWorld.Routes;

namespace HelloWorld.Controllers;

[Route(ApiRoutes.Products.GetAll)] // Attribute indication -> This tells the framework that this controller should be called when a request is made to the specified route
[ApiController] // Attribute indication -> This tells the framework that this controller should be treated as a controller for API requests
[Version("1.2", "Michael", 2024)]  // Applying custom VersionAttribute to enhance the class with metadata
public class ProductsController(IProductService productService) : ControllerBase
{
    [Version("1.1", "Eugene")]  
    [HttpGet] // Attribute indication -> This tells the framework that this method should be called when an HTTP GET request is made to the specified route
    public IActionResult GetAllProducts()
    {
        var products = productService.GetAllProducts();
        return Ok(products);
    }
}

[Route(ApiRoutes.Products.GetById)]
[ApiController]
public class ProductController(IProductService productService) : ControllerBase
{
    [HttpGet]
    public IActionResult GetProductById(int id) // The id parameter is automatically bound to the value in the route
    {
        var products = productService.GetProductById(id);
        return Ok(products);
    }
}





// More below

[Route("another-route")] // This can also be a literal string
[ApiController]
public class AnotherController : ControllerBase
{
    [HttpGet("first")] // This is a route template that appends to the route specified in the class attribute (so "another-route/first")
    public IActionResult Get()
    {
        return Ok("Get from another route!");
    }
    
    [HttpPost("first")] 
    public IActionResult Post()
    {
        return Ok("Post from another route!");
    }
    
    [HttpPut("second")]
    public IActionResult Put()
    {
        return Ok("Put from yet another route!");
    }
}

using HelloWorld.Interfaces;
using Microsoft.AspNetCore.Mvc;
using HelloWorld.Routes;

namespace HelloWorld.Controllers;

[Route(ApiRoutes.Products.GetAll)]
[ApiController]
public class ProductsController(IProductService productService) : ControllerBase
{
    [HttpGet]
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
    public IActionResult GetProductById(int id)
    {
        var products = productService.GetProductById(id);
        return Ok(products);
    }
}
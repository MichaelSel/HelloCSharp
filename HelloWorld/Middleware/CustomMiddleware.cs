using Microsoft.AspNetCore.Http;

namespace HelloWorld.Middleware
{
    public class CustomMiddleware(RequestDelegate next)
    {
        public async Task InvokeAsync(HttpContext context)
        {
            // Custom logic before request
            await next(context); // Call the next middleware
            // Custom logic after request
        }
    }
}
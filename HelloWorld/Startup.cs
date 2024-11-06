using HelloWorld.Configurations;
using HelloWorld.Data;
using HelloWorld.Interfaces;
using HelloWorld.Middleware;
using HelloWorld.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace HelloWorld;

public class Startup(IConfiguration configuration)
{
    private IConfiguration Configuration { get; } = configuration;

    // ConfigureServices is where we register services and configure DI.
    public void ConfigureServices(IServiceCollection services)
    {
        // Register DbContext with configuration from appsettings.json
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

        // Register application services
        services.AddTransient<IProductService, ProductService>();

        // Register custom middleware if needed
        services.AddScoped<CustomMiddleware>();

        // Add support for controllers
        services.AddControllers();

        // Register Swagger for API documentation
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
        });

        // Register configuration options
        services.Configure<DatabaseSettings>(Configuration.GetSection("DatabaseSettings"));
    }

    // Configure is where we set up the HTTP request pipeline.
    public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Developer exception page for detailed error information in Development mode
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;  // Swagger UI at the root (localhost:5000/)
            });
        }
        else
        {
            // Configure exception handling for production
            app.UseExceptionHandler("/error");
            app.UseHsts();
        }

        // Enable HTTPS redirection
        app.UseHttpsRedirection();

        // Register custom middleware
        app.UseMiddleware<CustomMiddleware>();

        // Enable routing
        app.UseRouting();

        // Authentication & Authorization (if applicable)
        app.UseAuthentication();
        app.UseAuthorization();

        // Map controller endpoints
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
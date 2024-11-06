# ASP.NET Core Boilerplate Educational App

This repository is an educational ASP.NET Core application designed to demonstrate foundational concepts in ASP.NET Core development. It serves as a boilerplate project for learning and experimenting with various ASP.NET Core features, including routing, dependency injection, middleware, custom attributes, and more.

## Overview

This app is a basic API designed around a sample product and order management system. It uses a clean and modular structure to help illustrate best practices in ASP.NET Core, making it easy for developers to understand how different components fit together.

## Key Features

- **Modular Project Structure**: Organized folders for controllers, models, middleware, services, attributes, and configurations.
- **Routing and Attribute-Based Routing**: Demonstrates how to set up attribute-based routing in controllers and centralize route paths.
- **Dependency Injection**: Uses DI to inject services into controllers, promoting decoupled and testable code.
- **Custom Middleware**: Illustrates how to create and use custom middleware for pre- and post-processing of HTTP requests.
- **Custom Attributes**: Implements a custom attribute to add metadata (versioning) to controllers and actions.
- **Configurations**: Shows how to manage configurations and default settings in `appsettings.json` and configuration classes.
- **Swagger Integration**: Provides API documentation and testing through Swagger.

## Project Structure

The project is structured in a modular and scalable way. Here’s an overview of the folder structure and its purpose:

```plaintext
MyApiProject/
├── Controllers/          # API controllers for handling HTTP requests
│   ├── ProductsController.cs
│   ├── OrdersController.cs
│
├── Models/               # Data models or entities representing resources
│   ├── Product.cs
│   ├── Order.cs
│
├── Middleware/           # Custom middleware components
│   ├── CustomMiddleware.cs
│
├── Routes/               # Centralized route configurations
│   ├── ApiRoutes.cs
│
├── Interfaces/           # Interfaces for services, supporting Dependency Injection
│   ├── IProductService.cs
│   ├── IOrderService.cs
│
├── Services/             # Business logic or service implementations
│   ├── ProductService.cs
│   ├── OrderService.cs
│
├── Attributes/           # Custom attributes for metadata or custom behavior
│   ├── VersionAttribute.cs
│
├── Configurations/       # Configuration classes mapping to appsettings.json
│   ├── DatabaseSettings.cs
│   ├── SwaggerSettings.cs
│
├── Defaults/             # Default values or settings for various entities
│   ├── ProductDefaults.cs
│
├── Data/                 # Database-related classes (e.g., DbContext, seed data)
│   ├── AppDbContext.cs
│
├── Program.cs            # Entry point of the application
├── Startup.cs            # Configures services and middleware pipeline
├── appsettings.json      # Application configuration
└── appsettings.Development.json # Development environment configuration
```

## Concepts and Features Covered

### 1. **Controllers and Routing**
   - Demonstrates the use of attribute-based routing with `[Route]`, `[HttpGet]`, `[HttpPost]`, etc.
   - Centralized routes are defined in `Routes/ApiRoutes.cs` to avoid hardcoding paths and improve maintainability.

### 2. **Dependency Injection (DI)**
   - Registers services in `Startup.cs` (e.g., `IProductService` and `ProductService`) and uses constructor injection to inject dependencies into controllers.
   - Promotes a decoupled architecture, allowing easy testing and flexibility in service implementation.

### 3. **Custom Middleware**
   - Shows how to create and register custom middleware to handle request processing in the `Middleware/CustomMiddleware.cs` file.
   - Middleware can be used for logging, authentication, response modifications, and more.

### 4. **Custom Attributes**
   - Implements a custom `VersionAttribute` to add metadata like version, author, and year to controllers or actions.
   - Demonstrates the use of attributes for extending class or method behavior, as well as reflection to read attribute data.

### 5. **Models and Data Access**
   - Defines models in the `Models` folder to represent database entities, such as `Product` and `Order`.
   - `Data/AppDbContext.cs` serves as the data access layer using Entity Framework Core, which connects to a database and performs CRUD operations.

### 6. **Configurations and Default Settings**
   - Stores configuration settings in `Configurations/DatabaseSettings.cs` and manages them in `appsettings.json`.
   - Default values, like `ProductDefaults`, are organized in the `Defaults` folder to centralize constants.

### 7. **Swagger Integration for API Documentation**
   - Integrates Swagger (via Swashbuckle) in `Startup.cs` to automatically generate API documentation and provide an interactive UI for testing endpoints.

## Getting Started

To run the project, you need .NET SDK 6.0 or later.

1. **Clone the repository**:
    ```bash
    git clone https://github.com/yourusername/MyApiProject.git
    cd MyApiProject
    ```

2. **Install dependencies and restore packages**:
    ```bash
    dotnet restore
    ```

3. **Run the application**:
    ```bash
    dotnet run
    ```

4. **Access the API documentation** (Swagger):
   - Go to `http://localhost:5000/swagger` to view and test the API.

## Requirements

- **.NET SDK** 6.0 or later
- **SQL Server** (if using Entity Framework Core with SQL Server, configure the connection string in `appsettings.json`)

## Educational Benefits

This boilerplate app is designed to teach essential concepts in ASP.NET Core development:
- Organizing large-scale ASP.NET Core projects
- Implementing routing and managing API endpoints
- Using Dependency Injection to decouple components
- Extending application behavior with custom middleware and attributes
- Managing configurations and default settings
- Leveraging Swagger for API documentation

Feel free to modify and extend this project to experiment with new features or to adapt it as a starting point for your own ASP.NET Core projects.

## License

This project is for educational purposes and is provided under the MIT License.

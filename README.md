# ASP.NET Core MVC Exercise Application

A comprehensive educational project demonstrating various ASP.NET Core MVC concepts and best practices. This sample application ("OrnekUygulama" in Turkish) showcases essential MVC patterns, routing techniques, validation methods, and modern web development practices.

## 🚀 Features

This exercise application demonstrates the following ASP.NET Core MVC concepts:

- **MVC Architecture**: Controllers, Views, and Models implementation
- **Custom Routing**: Named routes and route constraints
- **Dependency Injection**: Singleton, Scoped, and Transient service lifetimes
- **FluentValidation**: Modern validation techniques
- **Custom Middleware**: Extension methods and pipeline customization
- **Image Processing**: Using Magick.NET for image manipulation
- **ViewComponents**: Reusable UI components
- **Bootstrap Integration**: Modern responsive UI framework

## 📋 Prerequisites

Before running this application, ensure you have the following installed:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)
- A modern web browser

## 🛠️ Getting Started

### Installation

1. Clone the repository:
```bash
git clone https://github.com/Masvord/ExerciseForMVC.git
cd ExerciseForMVC
```

2. Restore the NuGet packages:
```bash
dotnet restore
```

3. Build the solution:
```bash
dotnet build
```

4. Run the application:
```bash
cd OrnekUygulama
dotnet run
```

5. Open your browser and navigate to `https://localhost:5001` or `http://localhost:5000`

## 📁 Project Structure

```
ExerciseForMVC/
├── OrnekUygulama/
│   ├── Controllers/           # MVC Controllers
│   │   ├── HomeController.cs
│   │   ├── PersonelController.cs
│   │   └── ProductController.cs
│   ├── Models/               # Data models and ViewModels
│   ├── Views/                # Razor views and layouts
│   ├── ViewComponents/       # Reusable UI components
│   ├── Middlewares/          # Custom middleware implementations
│   ├── Extensions/           # Extension methods
│   ├── Handlers/             # Custom request handlers
│   ├── Constraints/          # Custom route constraints
│   ├── wwwroot/             # Static files (CSS, JS, images)
│   └── Program.cs           # Application entry point
└── OrnekUygulama.sln        # Solution file
```

## 🎯 Key Learning Concepts

### 1. Dependency Injection Patterns

The application demonstrates three different service lifetimes in [`Program.cs`](OrnekUygulama/Program.cs):

```csharp
// Singleton - Single instance for the entire application
builder.Services.AddSingleton<Personel>();

// Scoped - New instance per request
builder.Services.AddScoped<Personel>();

// Transient - New instance every time it's requested
builder.Services.AddTransient<Personel>();
```

### 2. Custom Routing and Constraints

Named routes with custom constraints are configured in [`Program.cs`](OrnekUygulama/Program.cs):

```csharp
// Named route with integer constraint and optional parameter
app.MapControllerRoute("GetProduct Yönlendirmesi", 
    "getProducts/{tryId:int:length(1)?}", 
    new { controller = "product", action = "GetProducts" });

// Custom constraint implementation
app.MapControllerRoute("GetTupleProduct Yönlendirmesi", 
    "GetTupleProduct/{tryId:custom?}", 
    new { controller = "product", action = "GetTupleProduct" });
```

### 3. FluentValidation Integration

The project uses FluentValidation for modern, fluent validation patterns:

```csharp
builder.Services.AddFluentValidationAutoValidation();
```

### 4. Custom Middleware

Custom middleware is implemented and registered using extension methods:

```csharp
app.UseHello(); // Custom middleware extension
```

## 🔧 Configuration

### Development Environment

The application includes development-specific configurations in [`appsettings.Development.json`](OrnekUygulama/appsettings.Development.json) for enhanced debugging and development experience.

### Runtime Compilation

Razor runtime compilation is enabled for faster development cycles:

```csharp
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
```

## 📦 Dependencies

Key NuGet packages used in this project:

- **ASP.NET Core MVC**: Core framework
- **FluentValidation**: Modern validation library
- **Bootstrap 5.3.3**: UI framework
- **Magick.NET**: Image processing capabilities
- **Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation**: Development productivity

For a complete list of dependencies, see [`OrnekUygulama.csproj`](OrnekUygulama/OrnekUygulama.csproj).

## 🎨 UI and Styling

The application uses Bootstrap 5.3.3 for responsive design and modern UI components. Static files are served from the [`wwwroot`](OrnekUygulama/wwwroot/) directory.

## 🧪 Testing the Features

### Route Testing

Test the custom routing by navigating to:
- `/DataAnnotations` - Demonstrates data annotations
- `/getProducts/1` - Shows parameterized routing
- `/GetTupleProduct/test` - Tests custom constraints

### Image Processing

The application includes image processing capabilities through the ImageHandler. Test by accessing:
- `/image/{imageName}?h=height` - Image manipulation endpoint

## 🤝 Contributing

This is an educational project. Feel free to:
1. Fork the repository
2. Create a feature branch
3. Add new MVC concepts or improve existing ones
4. Submit a pull request

## 📚 Learning Resources

To better understand the concepts demonstrated in this project, consider reviewing:

- [ASP.NET Core MVC Documentation](https://docs.microsoft.com/en-us/aspnet/core/mvc/)
- [Dependency Injection in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection)
- [FluentValidation Documentation](https://docs.fluentvalidation.net/)
- [ASP.NET Core Routing](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/routing)

## 📄 License

This project is intended for educational purposes. Please refer to the repository for any specific licensing information.

---

**Note**: This is a Turkish educational project ("Örnek Uygulama" means "Sample Application"). Comments and some variable names in the source code are in Turkish, reflecting its educational context.
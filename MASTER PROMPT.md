You are a senior .NET backend architect.

Generate a complete, runnable .NET 10 REST API project that is production-quality and copy-paste ready.

Requirements:

PROJECT TYPE:

* ASP.NET Core .NET 10 Web API
* Minimal API style (NOT MVC Controllers)
* Clean and simple architecture
* Feature-based folder structure

FEATURES:

* CRUD REST API for a Product entity
* Entity Framework Core with SQL Server
* DTO pattern (never expose entities directly)
* Async/await everywhere
* Dependency Injection best practices
* Swagger enabled
* Proper HTTP status codes

PROJECT STRUCTURE:
Create full folders and files:

/Data
AppDbContext.cs
/Models
Product.cs
/DTOs
ProductDto.cs
/Endpoints
ProductEndpoints.cs
Program.cs
appsettings.json

IMPLEMENT:

1. Product model (Id, Name, Price)
2. DbContext configuration
3. Endpoint grouping (/api/products)
4. GET all
5. GET by id
6. POST create
7. PUT update
8. DELETE
9. EF migrations ready setup

CODING RULES:

* Use modern C# features (.NET 10 compatible)
* Use records for DTOs
* Use extension method for endpoint mapping
* No unnecessary comments
* Clean readable code
* Follow Microsoft best practices

OUTPUT FORMAT:

* Show each file separately
* Include full file contents
* Must compile without modification

BONUS:

* Include commands to run migrations
* Include dotnet CLI commands to run project

Do NOT explain theory.
Output only the complete working project.

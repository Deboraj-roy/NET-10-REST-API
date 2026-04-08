using Microsoft.EntityFrameworkCore;
using REST_API.Data;
using REST_API.DTOs;
using REST_API.Models;

namespace REST_API.Endpoints;

public static class ProductEndpoints
{
    public static void MapProductEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/api/products")
            .WithName("Products")
            .WithOpenApi();

        group.MapGet("/", GetAllProducts)
            .WithName("GetAllProducts")
            .WithSummary("Get all products")
            .Produces<List<ProductDto>>(StatusCodes.Status200OK);

        group.MapGet("/{id}", GetProductById)
            .WithName("GetProductById")
            .WithSummary("Get a product by ID")
            .Produces<ProductDto>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);

        group.MapPost("/", CreateProduct)
            .WithName("CreateProduct")
            .WithSummary("Create a new product")
            .Produces<ProductDto>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest);

        group.MapPut("/{id}", UpdateProduct)
            .WithName("UpdateProduct")
            .WithSummary("Update an existing product")
            .Produces<ProductDto>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest);

        group.MapDelete("/{id}", DeleteProduct)
            .WithName("DeleteProduct")
            .WithSummary("Delete a product")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound);
    }

    private static async Task<IResult> GetAllProducts(AppDbContext db)
    {
        var products = await db.Products
            .AsNoTracking()
            .Select(p => new ProductDto(p.Id, p.Name, p.Price, p.CreatedAt))
            .ToListAsync();

        return Results.Ok(products);
    }

    private static async Task<IResult> GetProductById(int id, AppDbContext db)
    {
        var product = await db.Products
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.Id == id);

        return product is null
            ? Results.NotFound()
            : Results.Ok(new ProductDto(product.Id, product.Name, product.Price, product.CreatedAt));
    }

    private static async Task<IResult> CreateProduct(CreateProductDto dto, AppDbContext db)
    {
        if (string.IsNullOrWhiteSpace(dto.Name) || dto.Price < 0)
        {
            return Results.BadRequest("Name is required and price must be non-negative");
        }

        var product = new Product
        {
            Name = dto.Name,
            Price = dto.Price
        };

        db.Products.Add(product);
        await db.SaveChangesAsync();

        var productDto = new ProductDto(product.Id, product.Name, product.Price, product.CreatedAt);
        return Results.Created($"/api/products/{product.Id}", productDto);
    }

    private static async Task<IResult> UpdateProduct(int id, UpdateProductDto dto, AppDbContext db)
    {
        if (string.IsNullOrWhiteSpace(dto.Name) || dto.Price < 0)
        {
            return Results.BadRequest("Name is required and price must be non-negative");
        }

        var product = await db.Products.FirstOrDefaultAsync(p => p.Id == id);

        if (product is null)
        {
            return Results.NotFound();
        }

        product.Name = dto.Name;
        product.Price = dto.Price;

        db.Products.Update(product);
        await db.SaveChangesAsync();

        var productDto = new ProductDto(product.Id, product.Name, product.Price, product.CreatedAt);
        return Results.Ok(productDto);
    }

    private static async Task<IResult> DeleteProduct(int id, AppDbContext db)
    {
        var product = await db.Products.FirstOrDefaultAsync(p => p.Id == id);

        if (product is null)
        {
            return Results.NotFound();
        }

        db.Products.Remove(product);
        await db.SaveChangesAsync();

        return Results.NoContent();
    }
}

namespace REST_API.DTOs;

public record CreateProductDto(string Name, decimal Price);

public record UpdateProductDto(string Name, decimal Price);

public record ProductDto(int Id, string Name, decimal Price, DateTime CreatedAt);

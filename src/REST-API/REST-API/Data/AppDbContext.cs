using Microsoft.EntityFrameworkCore;
using REST_API.Models;

namespace REST_API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(p => p.Id);
            entity.Property(p => p.Name).IsRequired().HasMaxLength(255);
            entity.Property(p => p.Price).HasPrecision(10, 2);
            entity.Property(p => p.CreatedAt).HasDefaultValueSql("GETUTCDATE()");
            entity.HasIndex(p => p.Name).IsUnique();
        });
    }
}

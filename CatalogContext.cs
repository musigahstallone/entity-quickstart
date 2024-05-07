using Microsoft.EntityFrameworkCore;
using MongoDB.EntityFrameworkCore.Extensions;

namespace entity_quickstart;

public class CatalogContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<CatalogItem> Products { get; init; }
    public DbSet<CatalogBrand> Brands { get; init; }

    protected override void OnModelCreating(ModelBuilder mb)
    {
        base.OnModelCreating(mb);

        mb.Entity<CatalogItem>(
            b =>
            {
                b.ToCollection("Products");
                b.Property(c => c.Id).HasElementName("_id");
            }
        );
        mb.Entity<CatalogBrand>(
            b =>
            {
                b.ToCollection("Brands");
                b.Property(c => c.Id).HasElementName("_id");
            }
        );

    }
}

using HelpApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HelpApp.Infra.Data.EntitiesConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(200).IsRequired();

            builder.Property(p => p.Price).HasPrecision(10, 2);

            builder.HasOne(e => e.Category).WithMany(e => e.Products)
                .HasForeignKey(e => e.CategoryId);

            builder.HasData(
                new Product { Id = 1, Name= "Smartphone", Description="Samsung", Price=2009.99m, Stock= 100, Image="smartphone.jpg"},
                new Product { Id = 2, Name = "Colar", Description = "Prata", Price = 49.99m, Stock = 30, Image = "colar.jpg" },
                new Product { Id = 3, Name = "Lápis", Description = "Grafite", Price = 9.99m, Stock = 50, Image = "lapis.jpg" }
                );
        }
    }
}

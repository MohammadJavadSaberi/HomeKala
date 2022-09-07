using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Domain.ProductAgg;

namespace ShopManagement.Infrastructure.Mappings
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products").HasKey(p => p.Id);

            builder.Property(p => p.Name).HasMaxLength(255).IsRequired();
            builder.Property(p => p.Code).HasMaxLength(15).IsRequired();
            builder.Property(p => p.ShortDescription).HasMaxLength(255).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(550).IsRequired();
            builder.Property(p => p.Picture).HasMaxLength(700).IsRequired();
            builder.Property(p => p.PictureAlt).HasMaxLength(255).IsRequired();
            builder.Property(p => p.PictureTitle).HasMaxLength(500).IsRequired();
            builder.Property(p => p.Keywords).HasMaxLength(100).IsRequired();
            builder.Property(p => p.MetaDescription).HasMaxLength(140).IsRequired();
            builder.Property(p => p.Slug).HasMaxLength(400).IsRequired();

            builder.HasOne(p => p.Category)
                .WithMany(p => p.Products).HasForeignKey(p => p.ProductCategoryId);

            builder.HasMany(p => p.ProductPictures)
                .WithOne(p => p.Product).HasForeignKey(p => p.ProductId);
        }
    }
}

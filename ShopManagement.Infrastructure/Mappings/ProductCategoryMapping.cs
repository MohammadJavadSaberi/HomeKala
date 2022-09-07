using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Domain.ProductCategoryAgg;

namespace ShopManagement.Infrastructure.Mappings
{
    public class ProductCategoryMapping : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("ProductCategories").HasKey(p => p.Id);

            builder.Property(p => p.Name).HasMaxLength(255).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(550).IsRequired();
            builder.Property(p => p.Picture).HasMaxLength(700).IsRequired();
            builder.Property(p => p.PictureAlt).HasMaxLength(255).IsRequired();
            builder.Property(p => p.PictureTitle).HasMaxLength(500).IsRequired();
            builder.Property(p => p.Keywords).HasMaxLength(100).IsRequired();
            builder.Property(p => p.MetaDescription).HasMaxLength(140).IsRequired();
            builder.Property(p => p.Slug).HasMaxLength(400).IsRequired();

            builder.HasMany(p => p.Products)
                .WithOne(p => p.Category).HasForeignKey(p => p.ProductCategoryId);
        }
    }
}

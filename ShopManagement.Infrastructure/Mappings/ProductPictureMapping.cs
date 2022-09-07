using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Domain.ProductPictureAgg;

namespace ShopManagement.Infrastructure.Mappings
{
    public class ProductPictureMapping : IEntityTypeConfiguration<ProductPicture>
    {
        public void Configure(EntityTypeBuilder<ProductPicture> builder)
        {
            builder.ToTable("ProductPictures").HasKey(p => p.Id);

            builder.Property(p => p.Picture).HasMaxLength(700).IsRequired();
            builder.Property(p => p.PictureAlt).HasMaxLength(255).IsRequired();
            builder.Property(p => p.PictureTitle).HasMaxLength(500).IsRequired();

            builder.HasOne(p => p.Product)
                .WithMany(p => p.ProductPictures).HasForeignKey(p => p.ProductId);
        }
    }
}

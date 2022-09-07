using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement.Domain.SlideAgg;

namespace ShopManagement.Infrastructure.Mappings
{
    public class SlideMapping : IEntityTypeConfiguration<Slide>
    {
        public void Configure(EntityTypeBuilder<Slide> builder)
        {
            builder.ToTable("Slides").HasKey(p => p.Id);

            builder.Property(p => p.Picture).HasMaxLength(700).IsRequired();
            builder.Property(p => p.PictureAlt).HasMaxLength(255).IsRequired();
            builder.Property(p => p.PictureTitle).HasMaxLength(500).IsRequired();
            builder.Property(p => p.Heading).HasMaxLength(550).IsRequired();
            builder.Property(p => p.Title).HasMaxLength(300).IsRequired();
            builder.Property(p => p.Link).HasMaxLength(700).IsRequired();
            builder.Property(p => p.BtnText).HasMaxLength(300).IsRequired();
        }
    }
}

using CommentManagement.Domain.CommentAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CommentManagement.Infrastructure.Mappings
{
    public class CommentMapping : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments").HasKey(p => p.Id);

            builder.Property(p => p.Name).HasMaxLength(200).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(800).IsRequired();
            builder.Property(p => p.Message).HasMaxLength(1200).IsRequired();

            builder.HasOne(p => p.Parent)
                .WithMany(p => p.Childern).HasForeignKey(p => p.ParentId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}

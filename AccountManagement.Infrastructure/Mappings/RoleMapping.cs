using AccountManagement.Domain.RoleAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountManagement.Infrastructure.Mappings
{
    public class RoleMapping : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles").HasKey(p => p.Id);

            builder.Property(p => p.Title).HasMaxLength(200).IsRequired();

            builder.HasMany(p => p.Accounts)
                .WithOne(p => p.Role).HasForeignKey(p => p.RoleId);

            builder.OwnsMany(p => p.Premissions, nb =>
            {
                nb.ToTable("Premissions").HasKey(p => p.Id);

                nb.Property(p => p.Name).HasMaxLength(255).IsRequired();

                nb.WithOwner(p => p.Role);
            });
        }
    }
}

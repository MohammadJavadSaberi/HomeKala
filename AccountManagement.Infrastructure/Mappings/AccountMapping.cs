using AccountManagement.Domain.AccountAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountManagement.Infrastructure.Mappings
{
    public class AccountMapping : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Accounts").HasKey(p => p.Id);

            builder.Property(p => p.FullName).HasMaxLength(150).IsRequired();
            builder.Property(p => p.UserName).HasMaxLength(150).IsRequired();
            builder.Property(p => p.PassWord).HasMaxLength(1050).IsRequired();
            builder.Property(p => p.Mobile).HasMaxLength(12).IsRequired();
            builder.Property(p => p.ProfilePicture).HasMaxLength(1050).IsRequired();

            builder.HasOne(p => p.Role)
                .WithMany(p => p.Accounts).HasForeignKey(p => p.RoleId);
        }
    }
}

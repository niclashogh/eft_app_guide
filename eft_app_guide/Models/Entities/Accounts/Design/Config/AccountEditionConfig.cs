using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Accounts.Design.Config
{
    public class AccountEditionConfig : IEntityTypeConfiguration<AccountEdition>
    {
        public void Configure(EntityTypeBuilder<AccountEdition> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Name);

            // Link @ to Account
            builder
                .HasMany(x => x.Accounts)
                .WithOne(x => x.AccountEdition)
                .HasForeignKey(x => x.AccountEditionId);
        }
    }
}

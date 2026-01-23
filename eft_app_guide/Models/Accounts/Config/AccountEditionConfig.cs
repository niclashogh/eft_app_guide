using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Accounts.Config
{
    public class AccountEditionConfig : IEntityTypeConfiguration<AccountEdition>
    {
        public void Configure(EntityTypeBuilder<AccountEdition> builder)
        {
            builder.HasKey(x => x.Id);

            // Link AccountEdition to Account
            builder
                .HasMany(x => x.Accounts)
                .WithOne(x => x.Edition)
                .HasForeignKey(x => x.AccountEditionId);

            // Link AccountEdition to AccountEditionReward
            builder
                .HasMany(x => x.Rewards)
                .WithOne(x => x.Edition)
                .HasForeignKey(x => x.AccountEditionId);
        }
    }
}

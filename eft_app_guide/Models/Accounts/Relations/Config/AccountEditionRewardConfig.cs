using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Accounts.Relations.Config
{
    public class AccountEditionRewardConfig : IEntityTypeConfiguration<AccountEditionReward>
    {
        public void Configure(EntityTypeBuilder<AccountEditionReward> builder)
        {
            builder.HasKey(x => new { x.AccountEditionId, x.RewardDomainId });

            // Link @ to AccountEdition
            builder
                .HasOne(x => x.AccountEdition)
                .WithMany(x => x.AccountEditionRewards)
                .HasForeignKey(x => x.AccountEditionId);

            // Link @ to RewardDomain
            builder
                .HasOne(x => x.RewardDomain)
                .WithMany(x => x.AccountEditionRewards)
                .HasForeignKey(x => x.RewardDomainId);
        }
    }
}

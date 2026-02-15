using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Accounts.Config
{
    public class AccountEditionRewardConfig : IEntityTypeConfiguration<AccountEditionReward>
    {
        public void Configure(EntityTypeBuilder<AccountEditionReward> builder)
        {
            builder.HasKey(x => new { x.AccountEditionId, x.RewardId });

            // Link @ to AccountEdition
            builder
                .HasOne(x => x.AccountEdition)
                .WithMany(x => x.AccountEditionRewards)
                .HasForeignKey(x => x.AccountEditionId);

            // Link @ to Reward
            builder
                .HasOne(x => x.Reward)
                .WithMany(x => x.AccountEditionRewards)
                .HasForeignKey(x => x.RewardId);
        }
    }
}

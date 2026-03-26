using eft_app_guide.Models.Rewards.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Rewards.Config
{
    public class RewardDomainConfig : IEntityTypeConfiguration<RewardDomain>
    {
        public void Configure(EntityTypeBuilder<RewardDomain> builder) // TODO : + AchievementReward, + QuestReward
        {
            builder.HasKey(x => x.Id);

            // Link @ to AccountEditionReward
            builder
                .HasMany(x => x.AccountEditionRewards)
                .WithOne(x => x.RewardDomain)
                .HasForeignKey(x => x.RewardDomainId);

            // Link @ to ChapterTaskReward
            builder
                .HasMany(x => x.ChapterTaskRewards)
                .WithOne(x => x.RewardDomain)
                .HasForeignKey(x => x.RewardDomainId);
        }
    }
}

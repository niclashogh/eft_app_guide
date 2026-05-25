using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Achievements.Relations.Config
{
    public class AchievementRewardConfig : IEntityTypeConfiguration<AchievementReward>
    {
        public void Configure(EntityTypeBuilder<AchievementReward> builder)
        {
            builder.HasKey(x => new { x.AchievementId, x.RewardTargetTypeId });

            // Link @ to Achievement
            builder
                .HasOne(x => x.Achievement)
                .WithMany(x => x.AchievementRewards)
                .HasForeignKey(x => x.AchievementId);

            // Link @ to RewardDomain
            builder
                .HasOne(x => x.RewardTargetType)
                .WithMany(x => x.AchievementRewards)
                .HasForeignKey(x => x.RewardTargetTypeId);
        }
    }
}

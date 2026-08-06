using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Achievements.Relations.Config
{
    public class AchievementRewardConfig : IEntityTypeConfiguration<AchievementReward>
    {
        public void Configure(EntityTypeBuilder<AchievementReward> builder)
        {
            builder.HasKey(x => new { x.AchievementId, x.ProgressionRewardId });

            // Link @ to Achievement
            builder
                .HasOne(x => x.Achievement)
                .WithMany(x => x.AchievementRewards)
                .HasForeignKey(x => x.AchievementId);

            // Link @ to ProgressionReward
            builder
                .HasOne(x => x.ProgressionReward)
                .WithMany(/* NOT DECLARED TO DECLUTTER ProgressionReward */)
                .HasForeignKey(x => x.ProgressionRewardId);
        }
    }
}

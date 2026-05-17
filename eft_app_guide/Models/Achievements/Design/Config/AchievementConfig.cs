using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Achievements.Design.Config
{
    public class AchievementConfig : IEntityTypeConfiguration<Achievement>
    {
        public void Configure(EntityTypeBuilder<Achievement> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to AchievementRarity
            builder
                .HasOne(x => x.AchievementRarity)
                .WithMany(x => x.Achievements)
                .HasForeignKey(x => x.AchivementRarityId);

            // Link @ to AchievementReward
            builder
                .HasMany(x => x.AchievementRewards)
                .WithOne(x => x.Achievement)
                .HasForeignKey(x => x.AchievementId);

            // Link @ to CharacterAchievementProgress
            builder
                .HasMany(x => x.CharacterAchievementProgressions)
                .WithOne(x => x.Achievement)
                .HasForeignKey(x => x.AchievementId);
        }
    }
}

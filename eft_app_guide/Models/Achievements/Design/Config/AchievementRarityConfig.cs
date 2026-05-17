using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Achievements.Design.Config
{
    public class AchievementRarityConfig : IEntityTypeConfiguration<AchievementRarity>
    {
        public void Configure(EntityTypeBuilder<AchievementRarity> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Achievement
            builder
                .HasMany(x => x.Achievements)
                .WithOne(x => x.AchievementRarity)
                .HasForeignKey(x => x.AchivementRarityId);
        }
    }
}

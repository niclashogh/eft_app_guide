using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Characters.State.Config
{
    public class CharacterAchievementProgressConfig : IEntityTypeConfiguration<CharacterAchievementProgress>
    {
        public void Configure(EntityTypeBuilder<CharacterAchievementProgress> builder)
        {
            builder.HasKey(x => new { x.CharacterId, x.AchievementId });

            // Link @ to Character
            builder
                .HasOne(x => x.Character)
                .WithMany(x => x.CharacterAchievementProgressions)
                .HasForeignKey(x => x.CharacterId);

            // Link @ to Achievement
            builder
                .HasOne(x => x.Achievement)
                .WithMany(x => x.CharacterAchievementProgressions)
                .HasForeignKey(x => x.AchievementId);
        }
    }
}

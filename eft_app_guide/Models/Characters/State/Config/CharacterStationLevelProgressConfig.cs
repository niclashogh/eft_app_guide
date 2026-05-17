using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Characters.State.Config
{
    public class CharacterStationLevelProgressConfig : IEntityTypeConfiguration<CharacterStationLevelProgress>
    {
        public void Configure(EntityTypeBuilder<CharacterStationLevelProgress> builder)
        {
            builder.HasKey(x => new { x.CharacterId, x.StationLevelId });

            // Link @ to Character
            builder
                .HasOne(x => x.Character)
                .WithMany(x => x.CharacterStationLevelProgressions)
                .HasForeignKey(x => x.CharacterId);

            // Link @ to StationLevel
            builder
                .HasOne(x => x.StationLevel)
                .WithMany(x => x.CharacterStationLevelProgressions)
                .HasForeignKey(x => x.StationLevelId);
        }
    }
}

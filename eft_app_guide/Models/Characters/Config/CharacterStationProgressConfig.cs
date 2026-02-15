using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Characters.Config
{
    public class CharacterStationProgressConfig : IEntityTypeConfiguration<CharacterStationProgress>
    {
        public void Configure(EntityTypeBuilder<CharacterStationProgress> builder)
        {
            builder.HasKey(x => new { x.CharacterId, x.StationLevelId });

            // Link @ to Character
            builder
                .HasOne(x => x.Character)
                .WithMany(x => x.CharacterStationProgressions)
                .HasForeignKey(x => x.CharacterId);

            // Link @ to StationLevel
            builder
                .HasOne(x => x.StationLevel)
                .WithMany(x => x.CharacterStationProgressions)
                .HasForeignKey(x => x.StationLevelId);
        }
    }
}

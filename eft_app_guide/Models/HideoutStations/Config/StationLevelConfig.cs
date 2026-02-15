using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace eft_app_guide.Models.HideoutStations.Config
{
    public class StationLevelConfig : IEntityTypeConfiguration<StationLevel>
    {
        public void Configure(EntityTypeBuilder<StationLevel> builder) // TODO - ADD Effect AND FINISH
        {
            builder.HasKey(x => x.Id);

            // Link @ to StationLevel
            builder
                .HasOne(x => x.Station)
                .WithMany(x => x.StationLevels)
                .HasForeignKey(x => x.StationId);

            // Link @ to StationLevelCrafting
            builder
                .HasMany(x => x.StationLevelCraftings)
                .WithOne(x => x.StationLevel)
                .HasForeignKey(x => x.StationLevelId);

            // Link @ to StationLevelEffect
            builder
                .HasMany(x => x.StationLevelEffects)
                .WithOne(x => x.StationLevel)
                .HasForeignKey(x => x.StationLevelId);

            // Link @ to CharacterStationProgress
            builder
                .HasMany(x => x.CharacterStationProgressions)
                .WithOne(x => x.StationLevel)
                .HasForeignKey(x => x.StationLevelId);
        }
    }
}

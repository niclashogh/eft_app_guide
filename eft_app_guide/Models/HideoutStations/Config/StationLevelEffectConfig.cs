using eft_app_guide.Models.HideoutStations.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.HideoutStations.Config
{
    public class StationLevelEffectConfig : IEntityTypeConfiguration<StationLevelEffect>
    {
        public void Configure(EntityTypeBuilder<StationLevelEffect> builder)
        {
            builder.HasKey(x => new { x.StationLevelId, x.StationEffectId});

            // Link @ to StationLevel
            builder
                .HasOne(x => x.StationLevel)
                .WithMany(x => x.StationLevelEffects)
                .HasForeignKey(x => x.StationLevelId);

            // Link @ to StationEffect
            builder
                .HasOne(x => x.StationEffect)
                .WithMany(x => x.StationLevelEffects)
                .HasForeignKey(x => x.StationEffectId);
        }
    }
}

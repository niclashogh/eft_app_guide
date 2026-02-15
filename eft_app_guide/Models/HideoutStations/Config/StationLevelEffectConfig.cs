using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.HideoutStations.Config
{
    public class StationLevelEffectConfig : IEntityTypeConfiguration<StationLevelEffect>
    {
        public void Configure(EntityTypeBuilder<StationLevelEffect> builder) // TODO - ADD Effect AND FINISH
        {
            builder.HasKey(x => new { x.StationLevelId, x.EffectId});

            // Link @ to StationLevel

            // Link @ to Effect

        }
    }
}

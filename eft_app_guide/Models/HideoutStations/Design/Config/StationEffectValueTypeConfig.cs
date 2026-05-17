using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.HideoutStations.Design.Config
{
    public class StationEffectValueTypeConfig : IEntityTypeConfiguration<StationEffectValueType>
    {
        public void Configure(EntityTypeBuilder<StationEffectValueType> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to StationEffect
            builder
                .HasMany(x => x.StationEffects)
                .WithOne(x => x.StationEffectValueType)
                .HasForeignKey(x => x.StationEffectValueTypeId);
        }
    }
}

using eft_app_guide.Models.HideoutStations._temp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.HideoutStations.Design.Config
{
    public class StationEffectConfig : IEntityTypeConfiguration<StationEffect>
    {
        public void Configure(EntityTypeBuilder<StationEffect> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to StationEffectValueType
            builder
                .HasOne(x => x.StationEffectValueType)
                .WithMany(x => x.StationEffects)
                .HasForeignKey(x => x.StationEffectValueTypeId);

            // Link @ to StationEffectCharacterMajorSkill
            builder
                .HasOne(x => x.StationEffectCharacterMajorSkill)
                .WithOne(x => x.StationEffect)
                .HasForeignKey<StationEffectCharacterMajorSkill>(x => x.StationEffectId);

            // Link @ to StationLevelEffect
            builder
                .HasMany(x => x.StationLevelEffects)
                .WithOne(x => x.StationEffect)
                .HasForeignKey(x => x.StationEffectId);
        }
    }
}

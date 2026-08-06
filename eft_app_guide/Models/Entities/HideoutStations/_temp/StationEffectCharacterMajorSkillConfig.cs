using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.HideoutStations._temp
{
    public class StationEffectCharacterMajorSkillConfig : IEntityTypeConfiguration<StationEffectCharacterMajorSkill>
    {
        public void Configure(EntityTypeBuilder<StationEffectCharacterMajorSkill> builder)
        {
            builder.HasKey(x => x.StationEffectId);

            // Link @ to StationEffect
            builder
                .HasOne(x => x.StationEffect)
                .WithOne(x => x.StationEffectCharacterMajorSkill)
                .HasForeignKey<StationEffectCharacterMajorSkill>(x => x.StationEffectId);

            // Link @ to CharacterMajorSkill
            builder
                .HasOne(x => x.CharacterMajorSkill)
                .WithMany(x => x.StationEffectCharacterMajorSkills)
                .HasForeignKey(x => x.CharacterMajorSkillId);

        }
    }
}

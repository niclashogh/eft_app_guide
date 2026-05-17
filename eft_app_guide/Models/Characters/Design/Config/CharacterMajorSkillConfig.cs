using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Characters.Design.Config
{
    public class CharacterMajorSkillConfig : IEntityTypeConfiguration<CharacterMajorSkill>
    {
        public void Configure(EntityTypeBuilder<CharacterMajorSkill> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Name);

            // Link @ to CharacterMinorSkill
            builder
                .HasMany(x => x.CharacterMinorSkills)
                .WithOne(x => x.CharacterMajorSkill)
                .HasForeignKey(x => x.CharacterMajorSkillId);

            // Link @ to CharacterMajorSkillProgress
            builder
                .HasMany(x => x.CharacterMajorSkillProgressions)
                .WithOne(x => x.CharacterMajorSkill)
                .HasForeignKey(x => x.CharacterMajorSkillId);

            // Link @ to StationEffectCharacterMajorSkill
            builder
                .HasMany(x => x.StationEffectCharacterMajorSkills)
                .WithOne(x => x.CharacterMajorSkill)
                .HasForeignKey(x => x.CharacterMajorSkillId);
        }
    }
}

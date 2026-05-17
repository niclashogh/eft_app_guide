using eft_app_guide.DataTransferObjects.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Characters.Design.Config
{
    public class CharacterMinorSkillConfig : IEntityTypeConfiguration<CharacterMinorSkill>
    {
        public void Configure(EntityTypeBuilder<CharacterMinorSkill> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Name);

            builder
                .Property(x => x.LevelStepImprovement)
                .HasConversion(p => p.Value, v => new Percent(v));

            builder
                .Property(x => x.ImprovementCap)
                .HasConversion(p => p.Value, v => new Percent(v));

            // Link @ to CharacterMajorSkill
            builder
                .HasOne(x => x.CharacterMajorSkill)
                .WithMany(x => x.CharacterMinorSkills)
                .HasForeignKey(x => x.CharacterMajorSkillId);
        }
    }
}

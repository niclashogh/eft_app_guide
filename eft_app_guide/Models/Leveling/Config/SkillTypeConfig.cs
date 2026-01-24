using eft_app_guide.Models.Leveling;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Leveling.Config
{
    public class SkillTypeConfig : IEntityTypeConfiguration<SkillType>
    {
        public void Configure(EntityTypeBuilder<SkillType> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to SkillLevelDefinition
            builder
                .HasMany(x => x.LevelDifinitions)
                .WithOne(x => x.SkillType)
                .HasForeignKey(x => x.SkillTypeId);

            // Link @ to CharacterSkillProgress
            builder
                .HasMany(x => x.CharacterSkillProgressions)
                .WithOne(x => x.SkillType)
                .HasForeignKey(x => x.CharacterSkillTypeId);
        }
    }
}

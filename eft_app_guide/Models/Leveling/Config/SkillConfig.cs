using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Leveling.Config
{
    public class SkillConfig : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to SkillLevel
            builder
                .HasMany(x => x.SkillLevels)
                .WithOne(x => x.Skill)
                .HasForeignKey(x => x.SkillId);

            // Link @ to CharacterSkillProgress
            //builder
                //.HasMany(x => x.CharacterSkillProgressions)
                //.WithOne(x => x.Skill)
                //.HasForeignKey(x => x.SkillId);
        }
    }
}

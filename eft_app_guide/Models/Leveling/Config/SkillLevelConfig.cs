using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace eft_app_guide.Models.Leveling.Config
{
    public class SkillLevelConfig : IEntityTypeConfiguration<SkillLevel>
    {
        public void Configure(EntityTypeBuilder<SkillLevel> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Skill
            builder
                .HasOne(x => x.Skill)
                .WithMany(x => x.SkillLevels)
                .HasForeignKey(x => x.SkillId);
        }
    }
}

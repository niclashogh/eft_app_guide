using eft_app_guide.Models.Entities.Skills.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Skills.Design.Config
{
    public class SkillGroupConfig : IEntityTypeConfiguration<SkillGroup>
    {
        public void Configure(EntityTypeBuilder<SkillGroup> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Skill
            builder
                .HasMany(x => x.Skills)
                .WithOne(x => x.SkillGroup)
                .HasForeignKey(x => x.SkillGroupId);
        }
    }
}

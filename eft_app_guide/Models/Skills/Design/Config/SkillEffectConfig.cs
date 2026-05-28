using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Skills.Design.Config
{
    public class SkillEffectConfig : IEntityTypeConfiguration<SkillEffect>
    {
        public void Configure(EntityTypeBuilder<SkillEffect> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Skill
            builder
                .HasOne(x => x.Skill)
                .WithMany(x => x.SkillEffects)
                .HasForeignKey(x => x.SkillId);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Skills.Design.Config
{
    public class SkillConfig : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to SkillGroup
            builder
                .HasOne(x => x.SkillGroup)
                .WithMany(x => x.Skills)
                .HasForeignKey(x => x.SkillGroupId);

            // Link @ to LevelingProfile
            builder
                .HasOne(x => x.LevelingProfile)
                .WithMany(x => x.Skills)
                .HasForeignKey(x => x.LevelingProfileId);

            // Link @ to SkillEffect
            builder
                .HasMany(x => x.SkillEffects)
                .WithOne(x => x.Skill)
                .HasForeignKey(x => x.SkillId);
        }
    }
}

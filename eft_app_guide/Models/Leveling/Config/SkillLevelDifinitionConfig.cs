using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace eft_app_guide.Models.Leveling.Config
{
    public class SkillLevelDifinitionConfig : IEntityTypeConfiguration<SkillLevelDefinition>
    {
        public void Configure(EntityTypeBuilder<SkillLevelDefinition> builder)
        {
            builder
                .HasKey(x => x.Id);

            // Link @ to SkillType
            builder
                .HasOne(x => x.SkillType)
                .WithMany(x => x.LevelDifinitions)
                .HasForeignKey(x => x.SkillTypeId);
        }
    }
}

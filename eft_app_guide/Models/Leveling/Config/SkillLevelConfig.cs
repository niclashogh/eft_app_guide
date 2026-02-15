using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace eft_app_guide.Models.Leveling.Config
{
    public class SkillLevelConfig : IEntityTypeConfiguration<SkillLevel>
    {
        public void Configure(EntityTypeBuilder<SkillLevel> builder) // MISSING
        {
            builder
                .HasKey(x => x.Id);
        }
    }
}

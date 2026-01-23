using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Operator.Config
{
    public class OperatorSkillLevelConfig : IEntityTypeConfiguration<OperatorSkillLevel>
    {
        public void Configure(EntityTypeBuilder<OperatorSkillLevel> builder)
        {
            builder.HasKey(x => x.Id);

            // Link OperatorSkillLevel to OperatorSkillType
            builder
                .HasOne(x => x.OperatorSkillType)
                .WithMany(x => x.OperatorSkillLevels)
                .HasForeignKey(x => x.OperatorSkillTypeId);
        }
    }
}

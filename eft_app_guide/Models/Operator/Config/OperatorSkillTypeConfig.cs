using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Operator.Config
{
    public class OperatorSkillTypeConfig : IEntityTypeConfiguration<OperatorSkillType>
    {
        public void Configure(EntityTypeBuilder<OperatorSkillType> builder)
        {
            builder.HasKey(x => x.Id);

            // Link OperatorSkillType to OperatorSkillLevel
            builder
                .HasMany(x => x.OperatorSkillLevels)
                .WithOne(x => x.OperatorSkillType)
                .HasForeignKey(x => x.OperatorSkillTypeId);

            // Link OperatorSkillType to CharacterOperatorSkillType
            builder
                .HasMany(x => x.CharacterOperatorSkillTypes)
                .WithOne(x => x.OperatorSkillType)
                .HasForeignKey(x => x.OperatorSkillTypeId);
        }
    }
}

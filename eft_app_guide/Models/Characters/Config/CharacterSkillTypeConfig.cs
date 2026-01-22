using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Characters.Config
{
    public class CharacterSkillTypeConfig : IEntityTypeConfiguration<CharacterSkillType>
    {
        public void Configure(EntityTypeBuilder<CharacterSkillType> builder)
        {
            builder.HasKey(x => x.Id);

            // Link CharacterSkillType to CharacterSkill
            builder
                .HasMany(x => x.Skills)
                .WithOne(x => x.Type)
                .HasForeignKey(x => x.CharacterSkillTypeId);
        }
    }
}

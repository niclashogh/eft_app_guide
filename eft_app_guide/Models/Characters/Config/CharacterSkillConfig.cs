using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Characters.Config
{
    public class CharacterSkillConfig : IEntityTypeConfiguration<CharacterSkill>
    {
        public void Configure(EntityTypeBuilder<CharacterSkill> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasIndex(x => new { x.CharacterId, x.CharacterSkillTypeId })
                .IsUnique();

            // Link CharacterSkill to CharacterSkillType
            builder
                .HasOne(x => x.Type)
                .WithMany(x => x.Skills)
                .HasForeignKey(x => x.CharacterSkillTypeId);

            // Link CharacterSkill to Character
            builder
                .HasOne(x => x.Character)
                .WithMany(x => x.Skills)
                .HasForeignKey(x => x.CharacterId);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Characters.Config
{
    public class CharacterOperatorSkillTypeConfig : IEntityTypeConfiguration<CharacterOperatorSkillType>
    {
        public void Configure(EntityTypeBuilder<CharacterOperatorSkillType> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasIndex(x => new { x.CharacterId, x.OperatorSkillTypeId })
                .IsUnique();

            // Link CharacterOperatorSkillType to Character
            builder
                .HasOne(x => x.Character)
                .WithMany(x => x.CharacterOperatorSkillTypes)
                .HasForeignKey(x => x.CharacterId);

            // Link CharacterOperatorSkillType to OperatorSkillType
            builder
                .HasOne(x => x.OperatorSkillType)
                .WithMany(x => x.CharacterOperatorSkillTypes)
                .HasForeignKey(x => x.OperatorSkillTypeId);
        }
    }
}

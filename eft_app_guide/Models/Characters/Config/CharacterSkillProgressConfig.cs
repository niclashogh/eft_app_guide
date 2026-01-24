using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Characters.Config
{
    public class CharacterSkillProgressConfig : IEntityTypeConfiguration<CharacterSkillProgress>
    {
        public void Configure(EntityTypeBuilder<CharacterSkillProgress> builder)
        {
            builder.HasKey(x => new { x.CharacterId, x.CharacterSkillTypeId });

            // Link @ to Character
            builder
                .HasOne(x => x.Character)
                .WithMany(x => x.SkillProgressions)
                .HasForeignKey(x => x.CharacterId);

            // Link @ to SkillType
            builder
                .HasOne(x => x.SkillType)
                .WithMany(x => x.CharacterSkillProgressions)
                .HasForeignKey(x => x.CharacterSkillTypeId);
        }
    }
}

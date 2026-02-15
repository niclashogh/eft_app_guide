using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Characters.Config
{
    public class CharacterSkillProgressConfig : IEntityTypeConfiguration<CharacterSkillProgress>
    {
        public void Configure(EntityTypeBuilder<CharacterSkillProgress> builder)
        {
            builder.HasKey(x => new { x.CharacterId, x.SkillId });

            // Link @ to Character
            builder
                .HasOne(x => x.Character)
                .WithMany(x => x.CharacterSkillProgressions)
                .HasForeignKey(x => x.CharacterId);

            // Link @ to Skill
            builder
                .HasOne(x => x.Skill)
                .WithMany(x => x.CharacterSkillProgressions)
                .HasForeignKey(x => x.SkillId);
        }
    }
}

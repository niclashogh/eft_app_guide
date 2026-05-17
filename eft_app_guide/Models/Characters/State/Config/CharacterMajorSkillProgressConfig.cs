using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Characters.State.Config
{
    public class CharacterMajorSkillProgressConfig : IEntityTypeConfiguration<CharacterMajorSkillProgress>
    {
        public void Configure(EntityTypeBuilder<CharacterMajorSkillProgress> builder)
        {
            builder.HasKey(x => new { x.CharacterId, x.CharacterMajorSkillId });

            // Link @ to Character
            builder
                .HasOne(x => x.Character)
                .WithMany(x => x.CharacterMajorSkillProgressions)
                .HasForeignKey(x => x.CharacterId);

            // Link @ to CharacterMajorSkill
            builder
                .HasOne(x => x.CharacterMajorSkill)
                .WithMany(x => x.CharacterMajorSkillProgressions)
                .HasForeignKey(x => x.CharacterMajorSkillId);
        }
    }
}

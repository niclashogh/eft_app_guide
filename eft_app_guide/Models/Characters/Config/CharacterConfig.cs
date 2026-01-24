using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Characters.Config
{
    public class CharacterConfig : IEntityTypeConfiguration<Character>
    {
        public void Configure(EntityTypeBuilder<Character> builder)
        {
            builder.HasKey(x => new { x.AccountId, x.FactionId });

            // Link @ to Account
            builder
                .HasOne(x => x.Account)
                .WithOne(x => x.Character)
                .HasForeignKey<Character>(x => x.AccountId);

            // Link @ to Faction
            builder
                .HasOne(x => x.Faction)
                .WithMany(x => x.Characters)
                .HasForeignKey(x => x.FactionId);

            // link @ to CharacterSkillProgress
            builder
                .HasMany(x => x.SkillProgressions)
                .WithOne(x => x.Character)
                .HasForeignKey(x => x.CharacterId);

            // Link @ to CharacterQuestProgress
            builder
                .HasMany(x => x.QuestProgressions)
                .WithOne(x => x.Character)
                .HasForeignKey(x => x.CharacterId);
        }
    }
}

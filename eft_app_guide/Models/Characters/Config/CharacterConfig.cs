using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Characters.Config
{
    public class CharacterConfig : IEntityTypeConfiguration<Character>
    {
        public void Configure(EntityTypeBuilder<Character> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasIndex(x => x.AccountId)
                .IsUnique();

            // Link Character to Account
            builder
                .HasOne(x => x.Account)
                .WithOne(x => x.Character)
                .HasForeignKey<Character>(x => x.AccountId);

            // Link Character to Faction
            builder
                .HasOne(x => x.Faction)
                .WithMany(x => x.Characters)
                .HasForeignKey(x => x.FactionId);

            // link Character to CharacterOperatorSkillType
            builder
                .HasMany(x => x.CharacterOperatorSkillTypes)
                .WithOne(x => x.Character)
                .HasForeignKey(x => x.CharacterId);

            // Link Character to CharacterQuest
            builder
                .HasMany(x => x.CharacterQuests)
                .WithOne(x => x.Character)
                .HasForeignKey(x => x.CharacterId);
        }
    }
}

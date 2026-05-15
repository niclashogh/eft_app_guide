using eft_app_guide.Models.Characters.State;
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

            // Link @ to CharacterMapAccess
            builder
                .HasMany(x => x.CharacterMapAccesses)
                .WithOne(x => x.Character)
                .HasForeignKey(x => x.CharacterId);

            // link @ to CharacterMajorSkillProgress
            builder
                .HasMany(x => x.CharacterMajorSkillProgressions)
                .WithOne(x => x.Character)
                .HasForeignKey(x => x.CharacterId);

            // Link @ to CharacterQuestProgress
            builder
                .HasMany(x => x.CharacterQuestProgressions)
                .WithOne(x => x.Character)
                .HasForeignKey(x => x.CharacterId);

            // Link @ to CharacterStationLevelProgress
            builder
                .HasMany(x => x.CharacterStationLevelProgressions)
                .WithOne(x => x.Character)
                .HasForeignKey(x => x.CharacterId);

            // Link @ to CharacterTraderReputation
            builder
                .HasMany(x => x.CharacterTraderReputations)
                .WithOne(x => x.Character)
                .HasForeignKey(x => x.CharacterId);

            // Link @ to CharacterAchievementProgress
            builder
                .HasMany(x => x.CharacterAchievementProgressions)
                .WithOne(x => x.Character)
                .HasForeignKey(x => x.CharacterId);

            // Link @ to CharacterRaid
            builder
                .HasMany(x => x.CharacterRaids)
                .WithOne(x => x.Character)
                .HasForeignKey(x => x.CharacterId);
        }
    }
}

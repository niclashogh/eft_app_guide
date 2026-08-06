using eft_app_guide.Models.Entities.Characters.State;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Characters.State.Config
{
    public class CharacterQuestProgressConfig : IEntityTypeConfiguration<CharacterQuestProgress>
    {
        public void Configure(EntityTypeBuilder<CharacterQuestProgress> builder)
        {
            builder.HasKey(x => new { x.CharacterId, x.QuestId});

            // Link @ to Character
            builder
                .HasOne(x => x.Character)
                .WithMany(x => x.CharacterQuestProgressions)
                .HasForeignKey(x => x.CharacterId);

            // Link @ to Quest
            builder
                .HasOne(x => x.Quest)
                .WithMany(x => x.CharacterQuestProgressions)
                .HasForeignKey(x => x.QuestId);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Characters.Config
{
    public class CharacterQuestConfig : IEntityTypeConfiguration<CharacterQuest>
    {
        public void Configure(EntityTypeBuilder<CharacterQuest> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasIndex(x => new { x.CharacterId, x.QuestId })
                .IsUnique();

            // Link CharacterQuset to Character
            builder
                .HasOne(x => x.Character)
                .WithMany(x => x.CharacterQuests)
                .HasForeignKey(x => x.CharacterId);

            // Link CharacterQuest to Quest
            builder
                .HasOne(x => x.Quest)
                .WithMany(x => x.CharacterQuests)
                .HasForeignKey(x => x.QuestId);
        }
    }
}

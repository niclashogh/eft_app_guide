using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Quests.Design.Config
{
    public class QuestConfig : IEntityTypeConfiguration<Quest>
    {
        public void Configure(EntityTypeBuilder<Quest> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to QuestLine
            builder
                .HasOne(x => x.QuestLine)
                .WithMany(x => x.Quests)
                .HasForeignKey(x => x.QuestLineId);

            // Link @ to Patron
            builder
                .HasOne(x => x.Patron)
                .WithMany(x => x.Quests)
                .HasForeignKey(x => x.PatronId);

            // Link @ to QuestGroup
            builder
                .HasMany(x => x.QuestGroups)
                .WithOne(x => x.Quest)
                .HasForeignKey(x => x.QuestId);

            // Link @ to QuestTask
            builder
                .HasMany(x => x.QuestTasks)
                .WithOne(x => x.Quest)
                .HasForeignKey(x => x.QuestId);

            // Link @ to CharacterQuestProgress
            builder
                .HasMany(x => x.CharacterQuestProgressions)
                .WithOne(x => x.Quest)
                .HasForeignKey(x => x.QuestId);
        }
    }
}

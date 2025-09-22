using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Quests.Config
{
    public class QuestConfig : IEntityTypeConfiguration<Quest>
    {
        public void Configure(EntityTypeBuilder<Quest> builder)
        {
            builder.HasKey(x => x.Id);

            // Link Quest to QuestLine
            builder
                .HasOne(x => x.QuestLine)
                .WithMany(x => x.Quests)
                .HasForeignKey(x => x.QuestLineId);

            // Link Quest to Trader
            builder
                .HasOne(x => x.Trader)
                .WithMany(x => x.Quests)
                .HasForeignKey(x => x.TraderName);

            // Link Quest to QuestRequirement
            builder
                .HasMany(x => x.QuestRequirements)
                .WithOne(x => x.Quest)
                .HasForeignKey(x => x.QuestId);

            // Link Quest to QuestReward
            builder
                .HasMany(x => x.QuestRewards)
                .WithOne(x => x.Quest)
                .HasForeignKey(x => x.QuestId);

            // Link Quest to QuestTask
            builder
                .HasMany(x => x.QuestTasks)
                .WithOne(x => x.Quest)
                .HasForeignKey(x => x.QuestId);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Quests.Config
{
    public class QuestTaskConfig : IEntityTypeConfiguration<QuestTask>
    {
        public void Configure(EntityTypeBuilder<QuestTask> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Quest
            builder
                .HasOne(x => x.Quest)
                .WithMany(x => x.QuestTasks)
                .HasForeignKey(x => x.QuestId);

            // Link @ to QuestTaskGroup
            builder
                .HasOne(x => x.QuestTaskGroup)
                .WithOne(x => x.QuestTask)
                .HasForeignKey<QuestTaskGroup>(x => x.QuestTaskId);

            // Link @ to QuestTaskMap
            builder
                .HasMany(x => x.QuestTaskMaps)
                .WithOne(x => x.QuestTask)
                .HasForeignKey(x => x.QuestTaskId);

            // Link @ to QuestTaskDisplay
            builder
                .HasOne(x => x.QuestTaskDisplay)
                .WithOne(x => x.QuestTask)
                .HasForeignKey<QuestTaskDisplay>(x => x.QuestTaskId);
        }
    }
}

using eft_app_guide.Models.Entities.Quests.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Quests.Design.Config
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
                .HasMany(x => x.QuestTaskGroups)
                .WithOne(x => x.QuestTask)
                .HasForeignKey(x => x.QuestTaskId);

            // Link @ to QuestTaskMap
            builder
                .HasMany(x => x.QuestTaskMaps)
                .WithOne(x => x.QuestTask)
                .HasForeignKey(x => x.QuestTaskId);

            // Link @ to QuestTaskDisplay
            builder
                .HasMany(x => x.QuestTaskDisplays)
                .WithOne(x => x.QuestTask)
                .HasForeignKey(x => x.QuestTaskId);
        }
    }
}

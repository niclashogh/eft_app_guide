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

            // Link @ to Map
            builder
                .HasOne(x => x.Map)
                .WithMany(x => x.QuestTasks)
                .HasForeignKey(x => x.MapId);

            // Link @ to QuestTaskDisplay
            builder
                .HasOne(x => x.QuestTaskDisplay)
                .WithOne(x => x.QuestTask)
                .HasForeignKey<QuestTaskDisplay>(x => x.QuestTaskId);
        }
    }
}

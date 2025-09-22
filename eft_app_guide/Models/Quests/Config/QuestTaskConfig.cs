using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Quests.Config
{
    public class QuestTaskConfig : IEntityTypeConfiguration<QuestTask>
    {
        public void Configure(EntityTypeBuilder<QuestTask> builder)
        {
            builder.HasKey(x => x.Id);

            // Link QuestTask to Quest
            builder
                .HasOne(x => x.Quest)
                .WithMany(x => x.QuestTasks)
                .HasForeignKey(x => x.QuestId);
        }
    }
}

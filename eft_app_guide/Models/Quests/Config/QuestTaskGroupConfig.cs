using eft_app_guide.Models.Quests.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Quests.Config
{
    public class QuestTaskGroupConfig : IEntityTypeConfiguration<QuestTaskGroup>
    {
        public void Configure(EntityTypeBuilder<QuestTaskGroup> builder)
        {
            builder.HasKey(x => x.QuestTaskId);

            // Link @ to QuestTask
            builder
                .HasOne(x => x.QuestTask)
                .WithOne(x => x.QuestTaskGroup)
                .HasForeignKey<QuestTaskGroup>(x => x.QuestTaskId);
        }
    }
}

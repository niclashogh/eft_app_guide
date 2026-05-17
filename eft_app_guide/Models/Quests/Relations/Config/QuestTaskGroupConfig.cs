using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Quests.Relations.Config
{
    public class QuestTaskGroupConfig : IEntityTypeConfiguration<QuestTaskGroup>
    {
        public void Configure(EntityTypeBuilder<QuestTaskGroup> builder)
        {
            builder.HasKey(x => new { x.QuestTaskId, x.GroupId });

            // Link @ to QuestTask
            builder
                .HasOne(x => x.QuestTask)
                .WithMany(x => x.QuestTaskGroups)
                .HasForeignKey(x => x.QuestTaskId);

            // Link @ to Group
            builder
                .HasOne(x => x.Group)
                .WithMany(x => x.QuestTaskGroups)
                .HasForeignKey(x => x.GroupId);
        }
    }
}

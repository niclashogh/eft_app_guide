using eft_app_guide.Models.Quests.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Quests.Config
{
    public class QuestTaskMapConfig : IEntityTypeConfiguration<QuestTaskMap>
    {
        public void Configure(EntityTypeBuilder<QuestTaskMap> builder)
        {
            builder.HasKey(x => new { x.QuestTaskId, x.MapId });

            // Link @ to QuestTask
            builder
                .HasOne(x => x.QuestTask)
                .WithMany(x => x.QuestTaskMaps)
                .HasForeignKey(x => x.QuestTaskId);

            // Link @ to Map
            builder
                .HasOne(x => x.Map)
                .WithMany(x => x.QuestTasksMaps)
                .HasForeignKey(x => x.MapId);
        }
    }
}

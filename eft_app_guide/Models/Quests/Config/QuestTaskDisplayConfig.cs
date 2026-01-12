using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Quests.Config
{
    public class QuestTaskDisplayConfig : IEntityTypeConfiguration<QuestTaskDisplay>
    {
        public void Configure(EntityTypeBuilder<QuestTaskDisplay> builder)
        {
            builder.HasKey(x => x.QuestTaskId);

            // link QuestTaskDisplay to QuestTask
            builder
                .HasOne(x => x.QuestTask)
                .WithOne(x => x.Display)
                .HasForeignKey<QuestTaskDisplay>(x => x.QuestTaskId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

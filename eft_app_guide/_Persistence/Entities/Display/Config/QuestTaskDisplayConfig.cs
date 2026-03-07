using eft_app_guide._Persistence.Entities.Display.Poi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide._Persistence.Entities.Display.Config
{
    public class QuestTaskDisplayConfig : IEntityTypeConfiguration<QuestTaskDisplay>
    {
        public void Configure(EntityTypeBuilder<QuestTaskDisplay> builder)
        {
            builder.HasKey(x => x.QuestTaskId);

            // link @ to QuestTask
            builder
                .HasOne(x => x.QuestTask)
                .WithMany(x => x.QuestTaskDisplays)
                .HasForeignKey(x => x.QuestTaskId);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Quests.Config
{
    public class QuestGroupConfig : IEntityTypeConfiguration<QuestGroup>
    {
        public void Configure(EntityTypeBuilder<QuestGroup> builder)
        {
            builder.HasKey(x => x.QuestId);

            // Link @ to Quest
            builder
                .HasOne(x => x.Quest)
                .WithOne(x => x.QuestGroup)
                .HasForeignKey<QuestGroup>(x => x.QuestId);
        }
    }
}

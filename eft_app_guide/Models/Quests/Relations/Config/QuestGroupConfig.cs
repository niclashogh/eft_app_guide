using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Quests.Relations.Config
{
    public class QuestGroupConfig : IEntityTypeConfiguration<QuestGroup>
    {
        public void Configure(EntityTypeBuilder<QuestGroup> builder)
        {
            builder.HasKey(x => new { x.QuestId, x.GroupId });

            // Link @ to Quest
            builder
                .HasOne(x => x.Quest)
                .WithMany(x => x.QuestGroups)
                .HasForeignKey(x => x.QuestId);

            // Link @ to Group
            builder
                .HasOne(x => x.Group)
                .WithMany(x => x.QuestGroups)
                .HasForeignKey(x => x.GroupId);
        }
    }
}

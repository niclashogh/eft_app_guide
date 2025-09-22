using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Quests.Config
{
    public class QuestRewardConfig : IEntityTypeConfiguration<QuestReward>
    {
        public void Configure(EntityTypeBuilder<QuestReward> builder)
        {
            builder.HasKey(x => x.Id);

            // Link QuestReward to Quest
            builder
                .HasOne(x => x.Quest)
                .WithMany(x => x.QuestRewards)
                .HasForeignKey(x => x.QuestId);

            // Link QuestReward to Item
            builder
                .HasOne(x => x.Item)
                .WithMany(x => x.QuestRewards)
                .HasForeignKey(x => x.QuestId);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Quests.Relations.Config
{
    public class QuestRewardConfig : IEntityTypeConfiguration<QuestReward>
    {
        public void Configure(EntityTypeBuilder<QuestReward> builder)
        {
            builder.HasKey(x => x.QuestId);

            // Link @ to Quest
            builder
                .HasOne(x => x.Quest)
                .WithMany(x => x.QuestRewards)
                .HasForeignKey(x => x.QuestId);

            // Link @ to RewardDomain
            builder
                .HasOne(x => x.RewardTargetType)
                .WithMany(x => x.QuestRewards)
                .HasForeignKey(x => x.RewardTargetTypeId);
        }
    }
}

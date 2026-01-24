using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Chapters.Config
{
    public class ChapterTaskRewardConfig : IEntityTypeConfiguration<ChapterTaskReward>
    {
        public void Configure(EntityTypeBuilder<ChapterTaskReward> builder)
        {
            builder.HasKey(x => new { x.ChapterTaskId, x.RewardId });

            // Link @ to ChapterTask
            builder
                .HasOne(x => x.Task)
                .WithMany(x => x.Rewards)
                .HasForeignKey(x => x.RewardId);

            // Link @ to Reward
            builder
                .HasOne(x => x.Reward)
                .WithMany(x => x.ChapterTaskRewards)
                .HasForeignKey(x => x.RewardId);
        }
    }
}

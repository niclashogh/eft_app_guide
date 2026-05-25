using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Chapters.Relations.Config
{
    public class ChapterTaskRewardConfig : IEntityTypeConfiguration<ChapterTaskReward>
    {
        public void Configure(EntityTypeBuilder<ChapterTaskReward> builder)
        {
            builder.HasKey(x => new { x.ChapterTaskId, x.RewardTargetTypeId });

            // Link @ to ChapterTask
            builder
                .HasOne(x => x.Task)
                .WithMany(x => x.ChapterTaskRewards)
                .HasForeignKey(x => x.RewardTargetTypeId);

            // Link @ to RewardDomain
            builder
                .HasOne(x => x.RewardTargetType)
                .WithMany(x => x.ChapterTaskRewards)
                .HasForeignKey(x => x.RewardTargetTypeId);
        }
    }
}

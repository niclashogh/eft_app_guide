using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Chapters.Config
{
    public class ChapterTaskRewardConfig : IEntityTypeConfiguration<ChapterTaskReward>
    {
        public void Configure(EntityTypeBuilder<ChapterTaskReward> builder)
        {
            builder.HasKey(x => new { x.ChapterTaskId, x.RewardDomainId });

            // Link @ to ChapterTask
            builder
                .HasOne(x => x.Task)
                .WithMany(x => x.ChapterTaskRewards)
                .HasForeignKey(x => x.RewardDomainId);

            // Link @ to RewardDomain
            builder
                .HasOne(x => x.RewardDomain)
                .WithMany(x => x.ChapterTaskRewards)
                .HasForeignKey(x => x.RewardDomainId);
        }
    }
}

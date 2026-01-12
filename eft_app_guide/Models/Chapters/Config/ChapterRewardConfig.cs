using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Chapters.Config
{
    public class ChapterRewardConfig : IEntityTypeConfiguration<ChapterReward>
    {
        public void Configure(EntityTypeBuilder<ChapterReward> builder)
        {
            builder.HasKey(x => x.Id);

            // link ChapterReward to Chapter
            builder
                .HasOne(x => x.Chapter)
                .WithMany(x => x.Rewards)
                .HasForeignKey(x => x.ChapterId);
        }
    }
}

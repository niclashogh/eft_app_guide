using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Chapters.Config
{
    public class ChapterTaskConfig : IEntityTypeConfiguration<ChapterTask>
    {
        public void Configure(EntityTypeBuilder<ChapterTask> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Chapter
            builder
                .HasOne(x => x.Chapter)
                .WithMany(x => x.Tasks)
                .HasForeignKey(x => x.ChapterId);

            // Link @ to ChapterTaskDisplay
            builder
                .HasOne(x => x.Display)
                .WithOne(x => x.Task)
                .HasForeignKey<ChapterTaskDisplay>(x => x.ChapterTaskId);

            // Link @ to ChapterTaskMap
            builder
                .HasMany(x => x.MapRelations)
                .WithOne(x => x.ChapterTask)
                .HasForeignKey(x => x.ChapterTaskId);

            // Link @ to ChapterRewards
            builder
                .HasMany(x => x.Rewards)
                .WithOne(x => x.Task)
                .HasForeignKey(x => x.ChapterTaskId);
        }
    }
}

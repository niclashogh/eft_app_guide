using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Chapters.Config
{
    public class ChapterTaskConfig : IEntityTypeConfiguration<ChapterTask>
    {
        public void Configure(EntityTypeBuilder<ChapterTask> builder)
        {
            builder.HasKey(x => x.Id);

            // Link ChapterTask to Chapter
            builder
                .HasOne(x => x.Chapter)
                .WithMany(x => x.Tasks)
                .HasForeignKey(x => x.ChapterId);

            // Link ChapterTask to Map
            builder
                .HasOne(x => x.Map)
                .WithMany(x => x.ChapterTasks)
                .HasForeignKey(x => x.MapId);

            // Link ChapterTaskDisplay to ChapterTask
            builder
                .HasOne(x => x.Display)
                .WithOne(x => x.ChapterTask)
                .HasForeignKey<ChapterTaskDisplay>(x => x.ChapterTaskId);
        }
    }
}

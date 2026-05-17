using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Chapters.Design.Config
{
    public class ChapterTaskConfig : IEntityTypeConfiguration<ChapterTask>
    {
        public void Configure(EntityTypeBuilder<ChapterTask> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Chapter
            builder
                .HasOne(x => x.Chapter)
                .WithMany(x => x.ChapterTasks)
                .HasForeignKey(x => x.ChapterId);

            // Link @ to ChapterTaskDisplay
            builder
                .HasMany(x => x.ChapterTaskDisplays)
                .WithOne(x => x.ChapterTask)
                .HasForeignKey(x => x.ChapterTaskId);

            // Link @ to ChapterTaskGroup
            builder
                .HasMany(x => x.ChapterTaskGroups)
                .WithOne(x => x.ChapterTask)
                .HasForeignKey(x => x.ChapterTaskId);

            // Link @ to ChapterTaskMap
            builder
                .HasMany(x => x.ChapterTaskMaps)
                .WithOne(x => x.ChapterTask)
                .HasForeignKey(x => x.ChapterTaskId);

            // Link @ to ChapterRewards
            builder
                .HasMany(x => x.ChapterTaskRewards)
                .WithOne(x => x.Task)
                .HasForeignKey(x => x.ChapterTaskId);

            // Link @ to CharacterChapterTaskProgress
            builder
                .HasMany(x => x.CharacterChapterTaskProgressions)
                .WithOne(x => x.ChapterTask)
                .HasForeignKey(x => x.ChapterTaskId);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Chapters.Config
{
    public class ChapterTaskGroupConfig : IEntityTypeConfiguration<ChapterTaskGroup>
    {
        public void Configure(EntityTypeBuilder<ChapterTaskGroup> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => new { x.ChapterTaskId, x.GUID });

            // Link @ to ChapterTask
            builder
                .HasOne(x => x.ChapterTask)
                .WithOne(x => x.ChapterTaskGroup)
                .HasForeignKey<ChapterTaskGroup>(x => x.ChapterTaskId);
        }
    }
}

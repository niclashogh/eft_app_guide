using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Chapters.Config
{
    public class ChapterTaskDisplayConfig : IEntityTypeConfiguration<ChapterTaskDisplay>
    {
        public void Configure(EntityTypeBuilder<ChapterTaskDisplay> builder)
        {
            builder.HasKey(x => x.ChapterTaskId);

            // Link ChapterTaskDisplay to ChapterTask
            builder
                .HasOne(x => x.ChapterTask)
                .WithOne(x => x.Display)
                .HasForeignKey<ChapterTaskDisplay>(x => x.ChapterTaskId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

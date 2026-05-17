using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide._Persistence.Entities.Display.Config
{
    public class ChapterTaskDisplayConfig : IEntityTypeConfiguration<ChapterTaskDisplay>
    {
        public void Configure(EntityTypeBuilder<ChapterTaskDisplay> builder)
        {
            builder.HasKey(x => x.ChapterTaskId);

            // Link @ to ChapterTask
            builder
                .HasOne(x => x.ChapterTask)
                .WithMany(x => x.ChapterTaskDisplays)
                .HasForeignKey(x => x.ChapterTaskId);

            // Link @ to MapDisplay
            builder
                .HasOne(x => x.MapDisplay)
                .WithMany(x => x.ChapterTaskDisplays)
                .HasForeignKey(x => x.MapDisplayId);
        }
    }
}

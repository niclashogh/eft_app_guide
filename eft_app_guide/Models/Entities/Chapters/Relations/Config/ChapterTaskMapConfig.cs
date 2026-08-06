using eft_app_guide.Models.Entities.Chapters.Relations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Chapters.Relations.Config
{
    public class ChapterTaskMapConfig : IEntityTypeConfiguration<ChapterTaskMap>
    {
        public void Configure(EntityTypeBuilder<ChapterTaskMap> builder)
        {
            builder.HasKey(x => new { x.ChapterTaskId, x.MapId });

            // Link @ to ChapterTask
            builder
                .HasOne(x => x.ChapterTask)
                .WithMany(x => x.ChapterTaskMaps)
                .HasForeignKey(x => x.ChapterTaskId);

            // Link @ to Map
            builder
                .HasOne(x => x.Map)
                .WithMany(x => x.ChapterTaskMaps)
                .HasForeignKey(x => x.MapId);
        }
    }
}

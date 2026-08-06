using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Chapters.Relations.Config
{
    public class ChapterTaskGroupConfig : IEntityTypeConfiguration<ChapterTaskGroup>
    {
        public void Configure(EntityTypeBuilder<ChapterTaskGroup> builder)
        {
            builder.HasKey(x => x.ChapterTaskId);

            // Link @ to ChapterTask
            builder
                .HasOne(x => x.ChapterTask)
                .WithMany(x => x.ChapterTaskGroups)
                .HasForeignKey(x => x.ChapterTaskId);

            // Link @ to Group
            builder
                .HasOne(x => x.Group)
                .WithMany(/* NOT DECLATED TO DECLUTTER Group */)
                .HasForeignKey(x => x.GroupId);
        }
    }
}

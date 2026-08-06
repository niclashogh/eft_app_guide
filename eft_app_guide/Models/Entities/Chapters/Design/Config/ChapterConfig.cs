using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Chapters.Design.Config
{
    public class ChapterConfig : IEntityTypeConfiguration<Chapter>
    {
        public void Configure(EntityTypeBuilder<Chapter> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Name);

            // Link @ to ChapterTask
            builder
                .HasMany(x => x.ChapterTasks)
                .WithOne(x => x.Chapter)
                .HasForeignKey(x => x.Id);

            // Link @ to CharacterChapterProgress
            builder
                .HasMany(x => x.CharacterChapterProgressions)
                .WithOne(x => x.Chapter)
                .HasForeignKey(x => x.ChapterId);
        }
    }
}

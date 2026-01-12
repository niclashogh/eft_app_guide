using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Chapters.Config
{
    public class ChaperRequirementConfig : IEntityTypeConfiguration<ChapterRequirement>
    {
        public void Configure(EntityTypeBuilder<ChapterRequirement> builder)
        {
            builder.HasKey(x => x.Id);

            // link ChapterRequirement to Chapter
            builder
                .HasOne(x => x.Chapter)
                .WithMany(x => x.Requirements)
                .HasForeignKey(x => x.ChapterId);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Chapters.Config
{
    public class ChapterConfig : IEntityTypeConfiguration<Chapter>
    {
        public void Configure(EntityTypeBuilder<Chapter> builder)
        {
            builder.HasKey(x => x.Id);

            // Link Chapter to ChapterTask
            builder
                .HasMany(x => x.Tasks)
                .WithOne(x => x.Chapter)
                .HasForeignKey(x => x.Id);

            // Link Chapter to ChapterRequirement
            builder
                .HasMany(x => x.Requirements)
                .WithOne(x => x.Chapter)
                .HasForeignKey(x => x.Id);

            // Link Chapter to ChapterReward
            builder
                .HasMany(x => x.Rewards)
                .WithOne(x => x.Chapter)
                .HasForeignKey(x => x.Id);
        }
    }
}

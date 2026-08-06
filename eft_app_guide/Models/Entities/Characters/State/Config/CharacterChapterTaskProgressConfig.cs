using eft_app_guide.Models.Entities.Characters.State;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Characters.State.Config
{
    public class CharacterChapterTaskProgressConfig : IEntityTypeConfiguration<CharacterChapterTaskProgress>
    {
        public void Configure(EntityTypeBuilder<CharacterChapterTaskProgress> builder)
        {
            builder.HasKey(x => new { x.CharacterId, x.ChapterTaskId });

            // Link @ to Character
            builder
                .HasOne(x => x.Character)
                .WithMany(x => x.CharacterChapterTaskProgressions)
                .HasForeignKey(x => x.CharacterId);

            // Link @ to ChapterTask'
            builder
                .HasOne(x => x.ChapterTask)
                .WithMany(x => x.CharacterChapterTaskProgressions)
                .HasForeignKey(x => x.ChapterTaskId);
        }
    }
}

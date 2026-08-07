using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Characters.State.Objectives.Config
{
    public class CharacterChapterProgressConfig : IEntityTypeConfiguration<CharacterChapterProgress>
    {
        public void Configure(EntityTypeBuilder<CharacterChapterProgress> builder)
        {
            builder.HasKey(x => new { x.CharacterId, x.ChapterId });

            // Link @ to Character
            builder
                .HasOne(x => x.Character)
                .WithMany(x => x.CharacterChapterProgressions)
                .HasForeignKey(x => x.CharacterId);

            // Link @ to Chapter
            builder
                .HasOne(x => x.Chapter)
                .WithMany(x => x.CharacterChapterProgressions)
                .HasForeignKey(x => x.ChapterId);
        }
    }
}

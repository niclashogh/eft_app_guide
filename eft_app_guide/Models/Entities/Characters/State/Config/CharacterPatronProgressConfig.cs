using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Characters.State.Config
{
    public class CharacterPatronProgressConfig : IEntityTypeConfiguration<CharacterPatronProgress>
    {
        public void Configure(EntityTypeBuilder<CharacterPatronProgress> builder)
        {
            builder.HasKey(x => new { x.CharacterId, x.PatronId });

            // Link @ to Character
            builder
                .HasOne(x => x.Character)
                .WithMany(x => x.CharacterPatronProgressions)
                .HasForeignKey(x => x.CharacterId);

            // Link @ to Patron
            builder
                .HasOne(x => x.Patron)
                .WithMany(x => x.CharacterPatronProgressions)
                .HasForeignKey(x => x.PatronId);
        }
    }
}

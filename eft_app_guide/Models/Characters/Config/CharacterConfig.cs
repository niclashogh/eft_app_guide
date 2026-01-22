using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Characters.Config
{
    public class CharacterConfig : IEntityTypeConfiguration<Character>
    {
        public void Configure(EntityTypeBuilder<Character> builder)
        {
            builder.HasKey(x => x.Id);

            // Link Character to Faction
            builder
                .HasOne(x => x.Faction)
                .WithMany(x => x.Characters)
                .HasForeignKey(x => x.FactionId);

            // Link Character to CharacterSkill
            builder
                .HasMany(x => x.Skills)
                .WithOne(x => x.Character)
                .HasForeignKey(x => x.CharacterId);
        }
    }
}

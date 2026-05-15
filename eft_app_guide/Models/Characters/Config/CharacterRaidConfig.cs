using eft_app_guide.Models.Characters.State;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Characters.Config
{
    public class CharacterRaidConfig : IEntityTypeConfiguration<CharacterRaid>
    {
        public void Configure(EntityTypeBuilder<CharacterRaid> builder)
        {
            builder.HasKey(x => new { x.CharacterId, x.RaidId });

            // Link @ to Character
            builder
                .HasOne(x => x.Character)
                .WithMany(x => x.CharacterRaids)
                .HasForeignKey(x => x.CharacterId);

            // Link @ to Raid
            builder
                .HasOne(x => x.Raid)
                .WithMany(x => x.CharacterRaids)
                .HasForeignKey(x => x.RaidId);
        }
    }
}

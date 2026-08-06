using eft_app_guide.Models.Entities.Characters.State;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Characters.State.Config
{
    public class CharacterRaidStatisticConfig : IEntityTypeConfiguration<CharacterRaidStatistic>
    {
        public void Configure(EntityTypeBuilder<CharacterRaidStatistic> builder)
        {
            builder.HasKey(x => new { x.CharacterId, x.RaidId });

            // Link @ to Character
            builder
                .HasOne(x => x.Character)
                .WithMany(x => x.CharacterRaidStatistics)
                .HasForeignKey(x => x.CharacterId);

            // Link @ to Raid
            builder
                .HasOne(x => x.Raid)
                .WithMany(x => x.CharacterRaidStatistics)
                .HasForeignKey(x => x.RaidId);
        }
    }
}

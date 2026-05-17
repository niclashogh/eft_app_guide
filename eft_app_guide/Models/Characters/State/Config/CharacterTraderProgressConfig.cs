using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Characters.State.Config
{
    public class CharacterTraderProgressConfig : IEntityTypeConfiguration<CharacterTraderProgress>
    {
        public void Configure(EntityTypeBuilder<CharacterTraderProgress> builder)
        {
            builder.HasKey(x => new { x.CharacterId, x.TraderId });

            // Link @ to Character
            builder
                .HasOne(x => x.Character)
                .WithMany(x => x.CharacterTraderProgressions)
                .HasForeignKey(x => x.CharacterId);

            // Link @ to Trader
            builder
                .HasOne(x => x.Trader)
                .WithMany(x => x.CharacterTraderProgressions)
                .HasForeignKey(x => x.TraderId);
        }
    }
}

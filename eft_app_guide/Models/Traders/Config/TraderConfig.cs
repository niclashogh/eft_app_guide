using eft_app_guide.Models.Traders.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Traders.Config
{
    public class TraderConfig : IEntityTypeConfiguration<Trader>
    {
        public void Configure(EntityTypeBuilder<Trader> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to TraderLevel
            builder
                .HasMany(x => x.TraderLevels)
                .WithOne(x => x.Trader)
                .HasForeignKey(x => x.TraderId);

            // Link @ to Quest
            builder
                .HasMany(x => x.Quests)
                .WithOne(x => x.Trader)
                .HasForeignKey(x => x.TraderId);

            // Link @ to Trade
            builder
                .HasMany(x => x.Trades)
                .WithOne(x => x.Trader)
                .HasForeignKey(x => x.TraderId);

            // Link @ to CharacterTraderReputation
            builder
                .HasMany(x => x.CharacterTraderReputations)
                .WithOne(x => x.Trader)
                .HasForeignKey(x => x.TraderId);
        }
    }
}

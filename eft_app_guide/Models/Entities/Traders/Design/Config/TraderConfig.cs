using eft_app_guide.Models.Entities.Traders.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Traders.Design.Config
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

            // Link @ to CharacterTraderReputation
            builder
                .HasMany(x => x.CharacterTraderProgressions)
                .WithOne(x => x.Trader)
                .HasForeignKey(x => x.TraderId);

            // Link @ to TraderCurrency
            builder
                .HasMany(x => x.TraderCurrencies)
                .WithOne(x => x.Trader)
                .HasForeignKey(x => x.TraderId);
        }
    }
}

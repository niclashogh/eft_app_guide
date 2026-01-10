using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Traders.Config
{
    public class TraderConfig : IEntityTypeConfiguration<Trader>
    {
        public void Configure(EntityTypeBuilder<Trader> builder)
        {
            builder.HasKey(x => x.Id);

            // Link Trader to TraderLevel
            builder
                .HasMany(x => x.Levels)
                .WithOne(x => x.Trader)
                .HasForeignKey(x => x.TraderId);

            // Link Trader to Quest
            builder
                .HasMany(x => x.Quests)
                .WithOne(x => x.Trader)
                .HasForeignKey(x => x.TraderId);

            // Link Trader to TraderItems
            builder
                .HasMany(x => x.Items)
                .WithOne(x => x.Trader)
                .HasForeignKey(x => x.TraderId);
        }
    }
}

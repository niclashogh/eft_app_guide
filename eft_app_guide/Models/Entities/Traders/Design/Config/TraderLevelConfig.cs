using eft_app_guide.Models.Entities.Traders.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Traders.Design.Config
{
    public class TraderLevelConfig : IEntityTypeConfiguration<TraderLevel>
    {
        public void Configure(EntityTypeBuilder<TraderLevel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => new { x.TraderId, x.Level });

            // Link @ to Trader
            builder
                .HasOne(x => x.Trader)
                .WithMany(x => x.TraderLevels)
                .HasForeignKey(x => x.TraderId);

            // Link @ to Trade
            builder
                .HasMany(x => x.Trades)
                .WithOne(x => x.TraderLevel)
                .HasForeignKey(x => x.TraderLevelId);
        }
    }
}

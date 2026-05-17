using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Traders.Design.Config
{
    public class TraderLevelConfig : IEntityTypeConfiguration<TraderLevel>
    {
        public void Configure(EntityTypeBuilder<TraderLevel> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Trader
            builder
                .HasOne(x => x.Trader)
                .WithMany(x => x.TraderLevels)
                .HasForeignKey(x => x.TraderId);

            // Link @ to Currency
            builder
                .HasOne(x => x.Currency)
                .WithMany(x => x.TraderLevels)
                .HasForeignKey(x => x.CurrencyId);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Traders.Config
{
    public class TraderLevelConfig : IEntityTypeConfiguration<TraderLevel>
    {
        public void Configure(EntityTypeBuilder<TraderLevel> builder)
        {
            builder.HasKey(x => x.Id);

            // Link TraderLevel to Trader
            builder
                .HasOne(x => x.Trader)
                .WithMany(x => x.Levels)
                .HasForeignKey(x => x.TraderId);
        }
    }
}

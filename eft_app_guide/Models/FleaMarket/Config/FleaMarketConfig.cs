using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.FleaMarket.Config
{
    public class FleaMarketConfig : IEntityTypeConfiguration<FleaMarket> // MISSING
    {
        public void Configure(EntityTypeBuilder<FleaMarket> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to FleaMarketItem
            builder
                .HasMany(x => x.Items)
                .WithOne(x => x.FleaMarket)
                .HasForeignKey(x => x.FleaMarketId);
        }
    }
}

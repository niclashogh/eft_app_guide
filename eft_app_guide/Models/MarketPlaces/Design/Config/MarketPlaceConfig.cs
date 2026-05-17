using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.MarketPlaces.Design.Config
{
    public class MarketPlaceConfig : IEntityTypeConfiguration<MarketPlace>
    {
        public void Configure(EntityTypeBuilder<MarketPlace> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to MarketPlaceItem
            builder
                .HasMany(x => x.MarketPlaceItems)
                .WithOne(x => x.MarketPlace)
                .HasForeignKey(x => x.MarketPlaceId);
        }
    }
}

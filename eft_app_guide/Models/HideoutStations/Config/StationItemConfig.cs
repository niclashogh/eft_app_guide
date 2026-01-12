using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.HideoutStations.Config
{
    public class StationItemConfig : IEntityTypeConfiguration<StationItem>
    {
        public void Configure(EntityTypeBuilder<StationItem> builder)
        {
            builder.HasKey(x => x.Id);

            // link StationItem to Station
            builder
                .HasOne(x => x.Station)
                .WithMany(x => x.Items)
                .HasForeignKey(x => x.StationId);

            // Link StationItem to Item
            builder
                .HasOne(x => x.Item)
                .WithMany(x => x.StationItems)
                .HasForeignKey(x => x.ItemId);
                
        }
    }
}

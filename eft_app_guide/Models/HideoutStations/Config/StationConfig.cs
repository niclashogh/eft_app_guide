using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.HideoutStations.Config
{
    public class StationConfig : IEntityTypeConfiguration<Station>
    {
        public void Configure(EntityTypeBuilder<Station> builder)
        {
            builder.HasKey(x => x.Id);

            // Link Station to StationItem
            builder
                .HasMany(x => x.Items)
                .WithOne(x => x.Station)
                .HasForeignKey(x => x.StationId);

            // Link Station to StationLevel
            builder
                .HasMany(x => x.Levels)
                .WithOne(x => x.Station)
                .HasForeignKey(x => x.StationId);
        }
    }
}

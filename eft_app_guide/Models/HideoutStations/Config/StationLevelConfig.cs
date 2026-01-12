using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace eft_app_guide.Models.HideoutStations.Config
{
    public class StationLevelConfig : IEntityTypeConfiguration<StationLevel>
    {
        public void Configure(EntityTypeBuilder<StationLevel> builder)
        {
            builder.HasKey(x => x.Id);

            // Link StationLevel to Station
            builder
                .HasOne(x => x.Station)
                .WithMany(x => x.Levels)
                .HasForeignKey(x => x.StationId);
        }
    }
}

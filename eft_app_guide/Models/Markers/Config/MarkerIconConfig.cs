using eft_app_guide.Models.Markers.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Markers.Config
{
    public class MarkerIconConfig : IEntityTypeConfiguration<MarkerIcon>
    {
        public void Configure(EntityTypeBuilder<MarkerIcon> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to MarkerDisplay
            builder
                .HasMany(x => x.MarkerDisplays)
                .WithOne(x => x.MarkerIcon)
                .HasForeignKey(x => x.MarkerIconId);
        }
    }
}

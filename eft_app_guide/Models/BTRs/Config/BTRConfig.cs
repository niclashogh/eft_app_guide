using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.BTRs.Config
{
    public class BTRConfig : IEntityTypeConfiguration<BTR>
    {
        public void Configure(EntityTypeBuilder<BTR> builder)
        {
            builder.HasKey(x => x.Id);

            // Link BTR to Map
            builder
                .HasOne(x => x.Map)
                .WithMany(x => x.BTRs)
                .HasForeignKey(x => x.MapId);

            // Link BTR to BTRDisplay
            builder
                .HasOne(x => x.Display)
                .WithOne(x => x.BTR)
                .HasForeignKey<BTRDisplay>(x => x.BTRId);
        }
    }
}

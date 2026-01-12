using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.BTRs.Config
{
    public class BTRDisplayConfig : IEntityTypeConfiguration<BTRDisplay>
    {
        public void Configure(EntityTypeBuilder<BTRDisplay> builder)
        {
            builder.HasKey(x => x.BTRId);

            // Link BTRDisplay to BTR
            builder
                .HasOne(x => x.BTR)
                .WithOne(x => x.Display)
                .HasForeignKey<BTRDisplay>(x => x.BTRId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

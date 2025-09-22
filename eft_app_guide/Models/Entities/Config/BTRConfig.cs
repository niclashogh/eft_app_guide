using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Config
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
                .HasForeignKey(x => x.MapName);
        }
    }
}

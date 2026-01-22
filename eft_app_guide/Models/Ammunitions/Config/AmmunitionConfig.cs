using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Ammunitions.Config
{
    public class AmmunitionConfig : IEntityTypeConfiguration<Ammunition>
    {
        public void Configure(EntityTypeBuilder<Ammunition> builder)
        {
            builder.HasKey(x => x.Id);

            // Link Ammunition to AmmunitionPerformance
            builder
                .HasOne(x => x.Performance)
                .WithOne(x => x.Ammunition)
                .HasForeignKey<AmmunitionPerformance>(x => x.AmmunitionId);

            // Link Ammunition to AmmunitionCaliber
            builder
                .HasOne(x => x.Caliber)
                .WithMany(x => x.Ammunitions)
                .HasForeignKey(x => x.AmmunitionCaliberId);
        }
    }
}

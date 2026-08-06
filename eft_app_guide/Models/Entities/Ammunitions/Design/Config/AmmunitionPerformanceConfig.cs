using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Ammunitions.Design.Config
{
    public class AmmunitionPerformanceConfig : IEntityTypeConfiguration<AmmunitionPerformance>
    {
        public void Configure(EntityTypeBuilder<AmmunitionPerformance> builder)
        {
            builder.HasKey(x => x.AmmunitionId);

            // Link @ to Ammunition
            builder
                .HasOne(x => x.Ammunition)
                .WithOne(x => x.AmmunitionPerformance)
                .HasForeignKey<AmmunitionPerformance>(x => x.AmmunitionId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

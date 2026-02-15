using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Ammunitions.Config
{
    public class AmmunitionConfig : IEntityTypeConfiguration<Ammunition>
    {
        public void Configure(EntityTypeBuilder<Ammunition> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to AmmunitionPerformance
            builder
                .HasOne(x => x.AmmunitionPerformance)
                .WithOne(x => x.Ammunition)
                .HasForeignKey<AmmunitionPerformance>(x => x.AmmunitionId);

            // Link @ to AmmunitionCaliber
            builder
                .HasOne(x => x.AmmunitionCaliber)
                .WithMany(x => x.Ammunitions)
                .HasForeignKey(x => x.AmmunitionCaliberId);
        }
    }
}

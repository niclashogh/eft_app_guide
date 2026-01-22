using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Ammunitions.Config
{
    public class AmmunitionCaliberConfig : IEntityTypeConfiguration<AmmunitionCaliber>
    {
        public void Configure(EntityTypeBuilder<AmmunitionCaliber> builder)
        {
            builder.HasKey(x => x.Id);

            // Link AmmunitionCaliber to Ammunition
            builder
                .HasMany(x => x.Ammunitions)
                .WithOne(x => x.Caliber)
                .HasForeignKey(x => x.AmmunitionCaliberId);
        }
    }
}

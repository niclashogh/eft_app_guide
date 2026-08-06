using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Ammunitions.Design.Config
{
    public class AmmunitionCaliberConfig : IEntityTypeConfiguration<AmmunitionCaliber>
    {
        public void Configure(EntityTypeBuilder<AmmunitionCaliber> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.HasIndex(x => x.ShortendName);

            // Link @ to Ammunition
            builder
                .HasMany(x => x.Ammunitions)
                .WithOne(x => x.AmmunitionCaliber)
                .HasForeignKey(x => x.AmmunitionCaliberId);
        }
    }
}

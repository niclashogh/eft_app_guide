using eft_app_guide.DataTransferObjects.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Ammunitions.Design.Config
{
    public class AmmunitionPerformanceConfig : IEntityTypeConfiguration<AmmunitionPerformance>
    {
        public void Configure(EntityTypeBuilder<AmmunitionPerformance> builder)
        {
            builder.HasKey(x => x.AmmunitionId);

            builder
                .Property(x => x.ArmorDamage)
                .HasConversion(p => p.Value, v => new Percent(v));

            builder
                .Property(x => x.Accuracy)
                .HasConversion(p => p.Value, v => new Percent(v));

            builder
                .Property(x => x.LightBleed)
                .HasConversion(p => p.Value, v => new Percent(v));

            builder
                .Property(x => x.HeavyBleed)
                .HasConversion(p => p.Value, v => new Percent(v));

            builder
                .Property(x => x.Heat)
                .HasConversion(p => p.Value, v => new Percent(v));

            // Link @ to Ammunition
            builder
                .HasOne(x => x.Ammunition)
                .WithOne(x => x.AmmunitionPerformance)
                .HasForeignKey<AmmunitionPerformance>(x => x.AmmunitionId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

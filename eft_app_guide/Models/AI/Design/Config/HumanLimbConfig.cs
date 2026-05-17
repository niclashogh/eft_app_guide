using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.AI.Design.Config
{
    public class HumanLimbConfig : IEntityTypeConfiguration<HumanLimb>
    {
        public void Configure(EntityTypeBuilder<HumanLimb> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Human
            builder
                .HasOne(x => x.Human)
                .WithMany(x => x.HumanLimbs)
                .HasForeignKey(x => x.HumanId);

            // Link @ to HumanLimbType

            builder
                .HasOne(x => x.HumanLimbType)
                .WithMany(x => x.HumanLimbs)
                .HasForeignKey(x => x.HumanLimbTypeId);
        }
    }
}

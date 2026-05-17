using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.AI.Design.Config
{
    public class HumanLimbTypeConfig : IEntityTypeConfiguration<HumanLimbType>
    {
        public void Configure(EntityTypeBuilder<HumanLimbType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Type);

            // Link @ to HumanLimb
            builder
                .HasMany(x => x.HumanLimbs)
                .WithOne(x => x.HumanLimbType)
                .HasForeignKey(x => x.HumanLimbTypeId);
        }
    }
}

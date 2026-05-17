using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide._Persistence.Entities.Display.Config
{
    public class BtrDisplayConfig : IEntityTypeConfiguration<BtrDisplay>
    {
        public void Configure(EntityTypeBuilder<BtrDisplay> builder)
        {
            builder.HasKey(x => x.BtrId);

            // Link @ to Btr
            builder
                .HasOne(x => x.Btr)
                .WithMany(x => x.BtrDisplays)
                .HasForeignKey(x => x.BtrId);

            // Link @ to MapDisplay
            builder
                .HasOne(x => x.MapDisplay)
                .WithMany(x => x.BtrDisplays)
                .HasForeignKey(x => x.MapDisplayId);
        }
    }
}

using eft_app_guide.Models.Services.Design;
using eft_app_guide.Models.Services.State;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Services.Config
{
    public class BtrConfig : IEntityTypeConfiguration<Btr>
    {
        public void Configure(EntityTypeBuilder<Btr> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Map
            builder
                .HasOne(x => x.Map)
                .WithMany(x => x.Btrs)
                .HasForeignKey(x => x.MapId);

            // Link @ to BtrDisplay
            builder
                .HasOne(x => x.BtrDisplay)
                .WithOne(x => x.Btr)
                .HasForeignKey<BtrDisplay>(x => x.BtrId);
        }
    }
}

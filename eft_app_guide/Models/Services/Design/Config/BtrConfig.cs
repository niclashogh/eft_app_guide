using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Services.Design.Config
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
                .HasMany(x => x.BtrDisplays)
                .WithOne(x => x.Btr)
                .HasForeignKey(x => x.BtrId);
        }
    }
}

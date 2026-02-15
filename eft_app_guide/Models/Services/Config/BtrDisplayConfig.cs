using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Services.Config
{
    public class BtrDisplayConfig : IEntityTypeConfiguration<BtrDisplay>
    {
        public void Configure(EntityTypeBuilder<BtrDisplay> builder)
        {
            builder.HasKey(x => x.BtrId);

            // Link @ to Btr
            builder
                .HasOne(x => x.Btr)
                .WithOne(x => x.BtrDisplay)
                .HasForeignKey<BtrDisplay>(x => x.BtrId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

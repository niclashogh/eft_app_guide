using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.AccessKeys.Config
{
    public class AccessKeyConfig : IEntityTypeConfiguration<AccessKey>
    {
        public void Configure(EntityTypeBuilder<AccessKey> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to LocationAccess
            builder
                .HasMany(x => x.LocationAccess)
                .WithOne(x => x.AccessKey)
                .HasForeignKey(x => x.AccessKeyId);

            // Link @ to ContainerAccess
            builder
                .HasMany(x => x.ContainerAccess)
                .WithOne(x => x.AccessKey)
                .HasForeignKey(x => x.AccessKeyId);
        }
    }
}

using eft_app_guide.Models.Entities.Containers.Relations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.Containers.Relations.Config
{
    public class ContainerAccessConfig : IEntityTypeConfiguration<ContainerAccess>
    {
        public void Configure(EntityTypeBuilder<ContainerAccess> builder)
        {
            builder.HasKey(x => new { x.ContainerId, x.AccessKeyId });

            // Link @ to Container
            builder
                .HasOne(x => x.Container)
                .WithMany(x => x.ContainerAccesses)
                .HasForeignKey(x => x.ContainerId);

            // Link @ to AccessKey
            builder
                .HasOne(x => x.AccessKey)
                .WithMany(x => x.ContainerAccesses)
                .HasForeignKey(x => x.AccessKeyId);
        }
    }
}

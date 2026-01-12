using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Containers.Config
{
    public class ContainerAccessConfig : IEntityTypeConfiguration<ContainerAccess>
    {
        public void Configure(EntityTypeBuilder<ContainerAccess> builder)
        {
            builder.HasKey(x => x.ContainerId);

            // Link ContainerAccess to Container
            builder
                .HasOne(x => x.Container)
                .WithOne(x => x.Access)
                .HasForeignKey<ContainerAccess>(x => x.ContainerId)
                .OnDelete(DeleteBehavior.Cascade);

            // Link ContainerAccess to AccessKey
            builder
                .HasOne(x => x.AccessKey)
                .WithMany(x => x.ContainerAccess)
                .HasForeignKey(x => x.AccessKey);
        }
    }
}

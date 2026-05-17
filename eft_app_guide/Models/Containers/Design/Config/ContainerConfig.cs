using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Containers.Design.Config
{
    public class ContainerConfig : IEntityTypeConfiguration<Container>
    {
        public void Configure(EntityTypeBuilder<Container> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Location
            builder
                .HasOne(x => x.Location)
                .WithMany(x => x.Containers)
                .HasForeignKey(x => x.LocationId);

            // Link @ to ContainerAccess
            builder
                .HasMany(x => x.ContainerAccesses)
                .WithOne(x => x.Container)
                .HasForeignKey(x => x.ContainerId);

            // Link @ to ContainerType
            builder
                .HasOne(x => x.ContainerType)
                .WithMany(x => x.Containers)
                .HasForeignKey(x => x.ContainerTypeId);
        }
    }
}

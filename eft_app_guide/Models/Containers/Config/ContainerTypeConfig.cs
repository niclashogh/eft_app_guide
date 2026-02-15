using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Containers.Config
{
    public class ContainerTypeConfig : IEntityTypeConfiguration<ContainerType>
    {
        public void Configure(EntityTypeBuilder<ContainerType> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Container
            builder
                .HasMany(x => x.Containers)
                .WithOne(x => x.ContainerType)
                .HasForeignKey(x => x.ContainerTypeId);
        }
    }
}

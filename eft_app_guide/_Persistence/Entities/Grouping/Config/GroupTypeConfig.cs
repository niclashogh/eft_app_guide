using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide._Persistence.Entities.Grouping.Config
{
    public class GroupTypeConfig : IEntityTypeConfiguration<GroupType>
    {
        public void Configure(EntityTypeBuilder<GroupType> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Group
            builder
                .HasMany(x => x.Groups)
                .WithOne(x => x.GroupType)
                .HasForeignKey(x => x.GroupTypeId);
        }
    }
}

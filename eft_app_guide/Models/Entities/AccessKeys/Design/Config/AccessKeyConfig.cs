using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Entities.AccessKeys.Design.Config
{
    public class AccessKeyConfig : IEntityTypeConfiguration<AccessKey>
    {
        public void Configure(EntityTypeBuilder<AccessKey> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.HasIndex(x => x.ShortendName);
        }
    }
}

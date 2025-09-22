using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.AccessKeys.Config
{
    public class AccessKeyConfig : IEntityTypeConfiguration<AccessKey>
    {
        public void Configure(EntityTypeBuilder<AccessKey> builder)
        {
            builder.HasKey(x => x.Id);

            // Link AccessKey to Item
            builder
                .HasOne(x => x.Item)
                .WithMany(x => x.AccessKeys)
                .HasForeignKey(x => x.ItemId);

            // Link AccessKey to Map
            builder
                .HasOne(x => x.Map)
                .WithMany(x => x.AccessKeys)
                .HasForeignKey(x => x.MapName);

            // Link AccessKey to AccessKeyLoot
            builder
                .HasMany(x => x.AccessKeyLoot)
                .WithOne(x => x.AccessKey)
                .HasForeignKey(x => x.AccessKeyId);
        }
    }
}

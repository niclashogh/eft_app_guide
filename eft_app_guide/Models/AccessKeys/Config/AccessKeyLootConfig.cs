using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.AccessKeys.Config
{
    public class AccessKeyLootConfig : IEntityTypeConfiguration<AccessKeyLoot>
    {
        public void Configure(EntityTypeBuilder<AccessKeyLoot> builder)
        {
            builder.HasKey(x => x.Id);

            // Link AccessKeyLoot to AccessKey
            builder
                .HasOne(x => x.AccessKey)
                .WithMany(x => x.AccessKeyLoot)
                .HasForeignKey(x => x.AccessKeyId);

            // Link AccessKeyLoot to Item
            builder
                .HasOne(x => x.Item)
                .WithMany(x => x.AccessKeyLoot)
                .HasForeignKey(x => x.ItemId);
        }
    }
}

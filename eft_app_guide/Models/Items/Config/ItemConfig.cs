using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Items.Config
{
    public class ItemConfig : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(x => x.Id);

            // Link Item to ItemCategory
            builder
                .HasOne(x => x.Category)
                .WithMany(x => x.Items)
                .HasForeignKey(x => x.ItemCategoryId);

            // Link Item to LocationLoot
            builder
                .HasMany(x => x.LocationItems)
                .WithOne(x => x.Item)
                .HasForeignKey(x => x.ItemId);

            // Link Item to TraderItem
            builder
                .HasMany(x => x.TraderItems)
                .WithOne(x => x.Item)
                .HasForeignKey(x => x.ItemId);
        }
    }
}

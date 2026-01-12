using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Items.Config
{
    public class ItemCategoryConfig : IEntityTypeConfiguration<ItemCategory>
    {
        public void Configure(EntityTypeBuilder<ItemCategory> builder)
        {
            builder.HasKey(x => x.Id);

            // Link ItemCategory to Item
            builder
                .HasMany(x => x.Items)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.ItemCategoryId);
        }
    }
}

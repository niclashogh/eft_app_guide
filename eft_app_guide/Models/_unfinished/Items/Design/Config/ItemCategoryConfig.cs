using eft_app_guide.Models._unfinished.Items.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models._unfinished.Items.Design.Config
{
    public class ItemCategoryConfig : IEntityTypeConfiguration<ItemCategory>
    {
        public void Configure(EntityTypeBuilder<ItemCategory> builder)
        {
            builder.HasKey(x => x.Id);

            // Link @ to Item
            builder
                .HasMany(x => x.Items)
                .WithOne(x => x.ItemCategory)
                .HasForeignKey(x => x.ItemCategoryId);
        }
    }
}

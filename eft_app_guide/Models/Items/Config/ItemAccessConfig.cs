using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eft_app_guide.Models.Items.Config
{
    public class ItemAccessConfig : IEntityTypeConfiguration<ItemAccess>
    {
        public void Configure(EntityTypeBuilder<ItemAccess> builder)
        {
            builder.HasKey(x => x.Id);

            // Link ItemAcess to Item
            builder
                .HasOne(x => x.Item)
                .WithMany(x => x.Access)
                .HasForeignKey(x => x.ItemId);
        }
    }
}

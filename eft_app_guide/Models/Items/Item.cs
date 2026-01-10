using eft_app_guide.Models.Items.Config;
using eft_app_guide.Models.Locations;
using eft_app_guide.Models.Traders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Items
{
    [EntityTypeConfiguration(typeof(ItemConfig))]
    public class Item
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int CategoryId { get; set; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public string ShortendName { get; set; }

        #region Relations
        public ItemCategory? Category { get; set; }

        public List<LocationLoot> LocationLoot { get; set; } = new();
        public List<ItemAccess> Access { get; set; } = new();
        public List<TraderItem> TraderItems { get; set; } = new();
        #endregion
    }
}

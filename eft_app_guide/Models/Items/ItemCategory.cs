using eft_app_guide.Models.Items.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Items
{
    /// <summary> DifinitionTable (Medical, Food, Weapon, etc.) </summary>
    [EntityTypeConfiguration(typeof(ItemCategoryConfig))]
    public class ItemCategory
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations
        public List<Item> Items { get; set; } = [];
        #endregion
    }
}

using eft_app_guide.Models._unfinished.Items.Design.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models._unfinished.Items.Design
{
    /// <summary><b>DifinitionEntity</b></summary>
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

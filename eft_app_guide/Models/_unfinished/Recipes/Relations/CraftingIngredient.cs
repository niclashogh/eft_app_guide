using eft_app_guide.Models._unfinished.Items.Design;
using eft_app_guide.Models._unfinished.Recipes.Design;
using eft_app_guide.Models._unfinished.Recipes.Relations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models._unfinished.Recipes.Relations
{
    /// <summary><b>AssociationEntity</b>
    /// Between:<code>
    /// CraftingId
    /// ItemId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(CraftingIngredientConfig))]
    public class CraftingIngredient
    {
        #region Keys (CompositeKeys)
        [Required] public int CraftingId { get; set; }
        [Required] public int ItemId { get; set; }
        #endregion

        [Required] public int Quantity { get; set; }

        #region Relations (Parents)
        public Recipe? Crafting { get; set; }
        public Item? Item { get; set; }
        #endregion
    }
}

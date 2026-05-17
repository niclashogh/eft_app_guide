using eft_app_guide.Models.CraftingRecipes.Design;
using eft_app_guide.Models.CraftingRecipes.Relations.Config;
using eft_app_guide.Models.Items.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.CraftingRecipes.Relations
{
    /// <summary><b>AssociationEntity</b>
    /// Between:<code>
    /// CraftingId
    /// ItemId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(CraftingResultConfig))]
    public class CraftingResult
    {
        #region Keys (CompositeKey)
        [Required] public int CraftingId { get; set; }
        [Required] public int ItemId { get; set; }
        #endregion

        [Required] public int Quantity { get; set; }

        #region Relations (Parents)
        public Crafting? Crafting { get; set; }
        public Item? Item { get; set; }
        #endregion
    }
}

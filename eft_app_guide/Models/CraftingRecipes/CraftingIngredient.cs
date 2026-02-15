using eft_app_guide.Models.CraftingRecipes.Config;
using eft_app_guide.Models.Items;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.CraftingRecipes
{
    /// <summary> AssociationEntity (CraftingId + ItemId) </summary>
    [EntityTypeConfiguration(typeof(CraftingIngredientConfig))]
    public class CraftingIngredient
    {
        #region Keys (CompositeKeys)
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

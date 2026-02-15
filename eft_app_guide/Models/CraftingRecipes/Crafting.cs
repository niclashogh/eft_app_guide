using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.CraftingRecipes.Config;
using eft_app_guide.Models.HideoutStations;
using eft_app_guide.Models.Items;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.CraftingRecipes
{
    /// <summary> AggregativeEntity (Item + CraftingItem) </summary>
    [EntityTypeConfiguration(typeof(CraftingConfig))]
    public class Crafting
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int ItemId { get; set; }
        #endregion

        [Required] public int Quantity { get; set; }

        #region Relations
        public Item? Item { get; set; }

        public AssociationList<CraftingItem> CraftingItems { get; set; } = [];
        public JunctionList<StationLevelCrafting> StationLevelCraftings { get; set; } = [];
        #endregion
    }
}

using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.CraftingRecipes.Config;
using eft_app_guide.Models.HideoutStations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.CraftingRecipes
{
    /// <summary> AggregativeEntity (CraftingResult + CraftingIngredient) </summary>
    [EntityTypeConfiguration(typeof(CraftingConfig))]
    public class Crafting
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        #region Relations (Children)
        public AssociationList<CraftingResult> CraftingResults { get; set; } = [];
        public AssociationList<CraftingIngredient> CraftingIngredients { get; set; } = [];
        public JunctionList<StationLevelCrafting> StationLevelCraftings { get; set; } = [];
        #endregion
    }
}

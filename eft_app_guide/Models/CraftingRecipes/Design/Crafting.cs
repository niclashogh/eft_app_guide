using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.CraftingRecipes.Design.Config;
using eft_app_guide.Models.CraftingRecipes.Relations;
using eft_app_guide.Models.HideoutStations.Relations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.CraftingRecipes.Design
{
    /// <summary><b>AggregativeEntity</b>
    /// Relations:<code>
    /// JUNCTIONS:
    /// StationLevelCrafting
    /// 
    /// ASSOCIATIONS:
    /// CraftingResult
    /// CraftingIngredient
    /// </code></summary>
    [EntityTypeConfiguration(typeof(CraftingConfig))]
    public class Crafting
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        #region Relations (Children)
        public JunctionList<StationLevelCrafting> StationLevelCraftings { get; set; } = [];

        public AssociationList<CraftingResult> CraftingResults { get; set; } = [];
        public AssociationList<CraftingIngredient> CraftingIngredients { get; set; } = [];
        #endregion
    }
}

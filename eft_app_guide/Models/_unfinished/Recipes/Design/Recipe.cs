using eft_app_guide._Objects.Types;
using eft_app_guide.Models._unfinished.HideoutStations.Relations;
using eft_app_guide.Models._unfinished.Recipes.Design.Config;
using eft_app_guide.Models._unfinished.Recipes.Relations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models._unfinished.Recipes.Design
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
    public class Recipe // TODO - Move to _Graph?
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

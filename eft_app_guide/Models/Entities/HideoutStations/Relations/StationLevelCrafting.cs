using eft_app_guide.Models.Entities.HideoutStations.Relations.Config;
using eft_app_guide.Models.Entities.Recipes.Design;
using eft_app_guide.Models.HideoutStations.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.HideoutStations.Relations
{
    /// <summary><b>JunctionEntity</b>
    /// Between:<code>
    /// StationLevelId
    /// CraftingId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(StationLevelCraftingConfig))]
    public class StationLevelCrafting
    {
        #region Keys (CompositeKeys)
        [Required] public int StationLevelId { get; set; }
        [Required] public int CraftingId { get; set; }
        #endregion

        #region Relations (Parents)
        public StationLevel? StationLevel {  get; set; }
        public Recipe? Crafting { get; set; }
        #endregion
    }
}

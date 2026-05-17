using eft_app_guide.Models.CraftingRecipes.Design;
using eft_app_guide.Models.HideoutStations.Design;
using eft_app_guide.Models.HideoutStations.Relations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.HideoutStations.Relations
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
        public Crafting? Crafting { get; set; }
        #endregion
    }
}

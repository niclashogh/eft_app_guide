using eft_app_guide.Models.CraftingRecipes;
using eft_app_guide.Models.HideoutStations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.HideoutStations
{
    /// <summary> JunctionEntity (StationLevelId + CraftingId) </summary>
    [EntityTypeConfiguration(typeof(StationLevelCraftingConfig))]
    public class StationLevelCrafting
    {
        #region Keys (CompositeKeys)
        [Required] public int StationLevelId { get; set; }
        [Required] public int CraftingId { get; set; }
        #endregion

        #region Relations
        public StationLevel? StationLevel {  get; set; }
        public Crafting? Crafting { get; set; }
        #endregion
    }
}

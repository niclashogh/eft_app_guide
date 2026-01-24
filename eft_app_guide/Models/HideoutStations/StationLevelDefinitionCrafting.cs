using eft_app_guide.Models.CraftingRecipes;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.HideoutStations
{
    public class StationLevelDefinitionCrafting // JunctionTable
    {
        #region Keys (CompositeKeys)
        [Required] public int StationLevelDefinitionId { get; set; }
        [Required] public int CraftingId { get; set; }
        #endregion

        #region Relations
        public StationLevelDefinition? StationLevel {  get; set; }
        public Crafting? Crafting { get; set; }
        #endregion
    }
}

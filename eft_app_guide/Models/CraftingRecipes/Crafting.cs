using eft_app_guide.Models.HideoutStations;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.CraftingRecipes
{
    public class Crafting // MISSING
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        // ...

        #region Relations
        public List<StationLevelCrafting> StationLevelCraftings { get; set; } = [];
        #endregion
    }
}

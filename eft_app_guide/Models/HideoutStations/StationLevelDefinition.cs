using eft_app_guide.Models.HideoutStations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.HideoutStations
{
    [EntityTypeConfiguration(typeof(StationLevelDefinitionConfig))]
    public class StationLevelDefinition // LookupTable
    {
        #region Keys
        [Key] public int Id { get; set; }
        [Required] public int StationId { get; set; }
        #endregion

        [Required] public int Level {  get; set; }
        [Required] public bool IsBuild { get; set; } // move to CharacterStaionProgress junctiontable

        #region Relations
        public Station? Station { get; set; }

        public List<StationLevelDefinitionCrafting> CraftingRelations { get; set; } = [];
        #endregion
    }
}

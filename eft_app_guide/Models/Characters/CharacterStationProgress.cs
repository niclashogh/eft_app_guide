using eft_app_guide.Models.HideoutStations;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Characters
{
    public class CharacterStationProgress
    {
        #region Keys
        [Required] public int CharacterId { get; set; }
        [Required] public int StationLevelDefinitionId { get; set; }
        #endregion

        [Required] public bool IsBuild {  get; set; }

        #region Relations
        public Character? Character { get; set; }
        public StationLevelDefinition? StationLevelDefinition { get; set; }
        #endregion
    }
}

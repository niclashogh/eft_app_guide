using eft_app_guide.Models.Characters.Config;
using eft_app_guide.Models.HideoutStations.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Characters.State
{
    /// <summary> AssociationEntity (CharacterId + StationLevelId) </summary>
    [EntityTypeConfiguration(typeof(CharacterStationLevelProgressConfig))]
    public class CharacterStationLevelProgress
    {
        #region Keys (CompositeKeys)
        [Required] public int CharacterId { get; set; }
        [Required] public int StationLevelId { get; set; }
        #endregion

        [Required] public bool IsBuild {  get; set; }

        #region Relations (Parents)
        public Character? Character { get; set; }
        public StationLevel? StationLevel { get; set; }
        #endregion
    }
}

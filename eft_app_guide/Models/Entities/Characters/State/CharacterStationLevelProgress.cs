using eft_app_guide.Models.Entities.Characters.State.Config;
using eft_app_guide.Models.HideoutStations.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Characters.State
{
    /// <summary><b>AssociationEntity</b>
    /// Between:<code>
    /// CharacterId
    /// StationLevelId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(CharacterStationLevelProgressConfig))]
    public class CharacterStationLevelProgress // TODO
    {
        #region Keys (CompositeKeys)
        [Required] public int CharacterId { get; set; }
        [Required] public int StationLevelId { get; set; }
        #endregion

        [Required] public bool IsBuild {  get; set; }

        #region Relations
        public Character? Character { get; set; }
        public StationLevel? StationLevel { get; set; }
        #endregion
    }
}

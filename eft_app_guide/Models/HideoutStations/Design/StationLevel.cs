using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Characters.State;
using eft_app_guide.Models.HideoutStations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.HideoutStations.Design
{
    /// <summary> AggregativeEntity (StationLevelCrafting + StationLevelEffect + CharacterStationProgress) </summary>
    [EntityTypeConfiguration(typeof(StationLevelConfig))]
    public class StationLevel
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int StationId { get; set; }
        #endregion

        [Required] public int Level {  get; set; }

        #region Relations (Parents)
        public Station? Station { get; set; }
        #endregion

        #region Relations (Children)
        public JunctionList<StationLevelCrafting> StationLevelCraftings { get; set; } = [];
        public JunctionList<StationLevelEffect> StationLevelEffects { get; set; } = [];
        public AssociationList<CharacterStationLevelProgress> CharacterStationLevelProgressions { get; set; } = [];
        #endregion
    }
}

using eft_app_guide.Models.HideoutStations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.HideoutStations
{
    /// <summary> JunctionEntity (StationLevelId + EffectId) </summary>
    [EntityTypeConfiguration(typeof(StationLevelEffectConfig))]
    public class StationLevelEffect // TODO - ADD Effect AND FINISH
    {
        #region Keys (CompositeKeys)
        [Required] public int StationLevelId { get; set; }
        [Required] public int EffectId { get; set; }
        #endregion

        #region Relations (Parents)
        public StationLevel? StationLevel { get; set; }
        // public Effect? Effect { get; set; }
        #endregion
    }
}

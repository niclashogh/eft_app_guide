using eft_app_guide.Models.HideoutStations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.HideoutStations.Design
{
    /// <summary> AssociationEntity (StationLevelId + StationEffectId) </summary>
    [EntityTypeConfiguration(typeof(StationLevelEffectConfig))]
    public class StationLevelEffect
    {
        #region Keys (CompositeKeys)
        [Required] public int StationLevelId { get; set; }
        [Required] public int StationEffectId { get; set; }
        #endregion

        [Required] public double EffectValue { get; set; }

        #region Relations (Parents)
        public StationLevel? StationLevel { get; set; }
        public StationEffect? StationEffect { get; set; }
        #endregion
    }
}

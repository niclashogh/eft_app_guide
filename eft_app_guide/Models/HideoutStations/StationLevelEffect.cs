using eft_app_guide.Models.HideoutStations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.HideoutStations
{
    /// <summary> ChildEntity (StationLevel) </summary>
    [EntityTypeConfiguration(typeof(StationLevelEffectConfig))]
    public class StationLevelEffect // MISSING
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int StationLevelId { get; set; }
        #endregion

        // ...
    }
}

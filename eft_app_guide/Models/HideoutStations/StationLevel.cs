using eft_app_guide.Models.HideoutStations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.HideoutStations
{
    [EntityTypeConfiguration(typeof(StationLevelConfig))]
    public class StationLevel
    {
        #region Keys
        [Key] public int Id { get; set; }
        [Required] public int StationId { get; set; }
        #endregion

        [Required] public int Level {  get; set; }
        [Required] public bool IsBuild { get; set; } // move to CharacterStationLevel junctiontable

        #region Relations
        public Station? Station { get; set; }
        #endregion
    }
}

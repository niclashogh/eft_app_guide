using eft_app_guide.Models.HideoutStations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.HideoutStations
{
    /// <summary> AggregativeEntity (StationLevel) </summary>
    [EntityTypeConfiguration(typeof(StationConfig))]
    public class Station
    {
        #region Keys
        [Key] public int Id { get; set; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations
        public List<StationLevel> StationLevels { get; set; } = [];
        #endregion
    }
}

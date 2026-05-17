using eft_app_guide.Models.HideoutStations.Design.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.HideoutStations.Design
{
    /// <summary><b>AggregativeEntity</b>
    /// Relations:<code>
    /// StationLevel
    /// </code></summary>
    [EntityTypeConfiguration(typeof(StationConfig))]
    public class Station
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations (Children)
        public List<StationLevel> StationLevels { get; set; } = [];
        #endregion
    }
}

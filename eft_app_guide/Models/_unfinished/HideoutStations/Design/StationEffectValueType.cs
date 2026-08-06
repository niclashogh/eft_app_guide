using eft_app_guide.Models._unfinished.HideoutStations.Design.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models._unfinished.HideoutStations.Design
{
    /// <summary><b>DefinitionEntity</b>
    /// Containing:<code>
    /// Percent
    /// FlatPerHour
    /// ...
    /// </code></summary>
    [EntityTypeConfiguration(typeof(StationEffectValueTypeConfig))]
    public class StationEffectValueType // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string ValueType { get; set; }

        #region Relations
        public List<StationEffect> StationEffects { get; set; } = [];
        #endregion
    }
}

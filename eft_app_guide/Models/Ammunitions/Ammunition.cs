using eft_app_guide.Models.Ammunitions.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Ammunitions
{
    /// <summary> AggregativeEntity (AmmunitionPerformance + AmmunitionCaliber) </summary>
    [EntityTypeConfiguration(typeof(AmmunitionConfig))]
    public class Ammunition
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int AmmunitionCaliberId { get; set; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public string ShortendName { get; set; }

        #region Relations
        public AmmunitionPerformance? AmmunitionPerformance { get; set; }
        public AmmunitionCaliber? AmmunitionCaliber { get; set; }
        #endregion
    }
}

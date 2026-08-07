using eft_app_guide.Models.Entities.Ammunitions.Design.Config;
using eft_app_guide.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Ammunitions.Design
{
    [EntityTypeConfiguration(typeof(AmmunitionConfig))]
    public class Ammunition : IGraphSource
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int AmmunitionCaliberId { get; set; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public string ShortendName { get; set; }

        #region Relations
        public AmmunitionCaliber? AmmunitionCaliber { get; set; }
        public AmmunitionPerformance? AmmunitionPerformance { get; set; }
        #endregion
    }
}

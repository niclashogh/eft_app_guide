using eft_app_guide.Models.Entities.Ammunitions.Design.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Ammunitions.Design
{
    /// <summary><b>DefintionEntity</b></summary>
    [EntityTypeConfiguration(typeof(AmmunitionCaliberConfig))]
    public class AmmunitionCaliber
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public string ShortendName { get; set; }

        #region Relations (Children)
        public List<Ammunition> Ammunitions { get; set; } = [];
        #endregion
    }
}

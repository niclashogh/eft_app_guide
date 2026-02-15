using eft_app_guide.Models.Ammunitions.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Ammunitions
{
    /// <summary> DefinitionEntity </summary>
    [EntityTypeConfiguration(typeof(AmmunitionCaliberConfig))]
    public class AmmunitionCaliber
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public string ShortendName { get; set; }

        #region Relations
        public List<Ammunition> Ammunitions { get; set; } = [];
        #endregion
    }
}

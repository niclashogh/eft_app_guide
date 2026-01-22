using eft_app_guide.DataTransferObjects.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Ammunitions
{
    public class AmmunitionPerformance
    {
        #region Keys
        [Key] public int AmmunitionId { get; init; }
        #endregion

        [Required] public double Damage { get; set; }

        [Required] public Percent ArmorDamage { get; set; }
        [Required] public double Penetration { get; set; }

        [Required] public Percent Accuracy { get; set; }
        [Required] public double Recoil { get; set; }
        [Required] public double Speed { get; set; }

        [Required] public Percent LightBleed { get; set; }
        [Required] public Percent HeavyBleed { get; set; }

        [Required] public Percent Heat { get; set; }

        #region Relations
        public Ammunition? Ammunition { get; set; }
        #endregion
    }
}

using eft_app_guide.Models.Entities.Actors.Design.Config;
using eft_app_guide.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Actors.Design
{
    [EntityTypeConfiguration(typeof(HumanLimbConfig))]
    public class HumanLimb
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int HumanId { get; set; }
        #endregion

        [Required] public HumanLimbPart LimbPart { get; set; }

        [Required] public int MaxHealthPoints { get; set; }

        [Required] public bool PermanentlyBlacked { get; set; }
        [Required] public bool IsVital { get; set; }
        [Required] public bool PropagatesDamageWhenBlacked { get; set; }

        [Required] public bool CanFracture { get; set; }
        [Required] public bool CanLightBleed { get; set; }
        [Required] public bool CanHeavyBleed { get; set; }

        #region Relations
        public Human? Human { get; set; }
        #endregion
    }
}

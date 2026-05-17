using eft_app_guide.Models.AI.Design.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.AI.Design
{
    /// <summary><b>ChildEntity of Human + HumanLimbType</b></summary>
    [EntityTypeConfiguration(typeof(HumanLimbConfig))]
    public class HumanLimb
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int HumanId { get; set; }
        [Required] public int HumanLimbTypeId { get; set; }
        #endregion

        [Required] public int MaxHealthPoints { get; set; }

        /// <summary> If true: the limb cannot be restored after it has lost all its HP. </summary>
        [Required] public bool PermanentlyBlacked { get; set; }
        [Required] public bool IsVital { get; set; }
        [Required] public bool PropagatesDamageWhenBlacked { get; set; }

        [Required] public bool CanFracture { get; set; }
        [Required] public bool CanLightBleed { get; set; }
        [Required] public bool CanHeavyBleed { get; set; }

        #region Relations (Parents)
        public Human? Human { get; set; }
        public HumanLimbType? HumanLimbType { get; set; }
        #endregion
    }
}

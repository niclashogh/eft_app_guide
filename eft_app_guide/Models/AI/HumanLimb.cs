using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eft_app_guide.Models.AI
{
    public class HumanLimb // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public int MaxHealthPoints { get; set; }

        /// <summary> If true: the limb cannot be restored after it has lost all its HP. </summary>
        [Required] public bool PermanentlyBlacked { get; set; }
        [Required] public bool IsVital { get; set; }
        [Required] public bool PropagatesDamageWhenBlacked { get; set; }

        [Required] public bool CanFracture { get; set; }
        [Required] public bool CanLightBleed { get; set; }
        [Required] public bool CanHeavyBleed { get; set; }

        #region Relations
        #endregion
    }
}

using eft_app_guide.Models.AI.Design.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.AI.Design
{
    /// <summary><b>DefinitionEntity</b>
    /// Containing:<code>
    /// Left Arm
    /// Left Leg
    /// Head
    /// ...
    /// </code></summary>
    [EntityTypeConfiguration(typeof(HumanLimbTypeConfig))]
    public class HumanLimbType
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Type { get; set; }

        #region Relations (Children)
        public List<HumanLimb> HumanLimbs { get; set; } = [];
        #endregion
    }
}

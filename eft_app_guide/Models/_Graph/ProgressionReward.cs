using eft_app_guide.Models._Enums;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models._Graph
{
    /// <summary><b>GraphEntity</b></summary>
    public class ProgressionReward
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public ProgressionTargetType ProgressionTargetType { get; set; }
        [Required] public int ProgressionTargetKey { get; set; }

        [Required] public TargetType TargetType { get; set; }
        [Required] public int TargetKey { get; set; }
    }
}

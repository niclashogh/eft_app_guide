using eft_app_guide.Models.Enums.ReferenceTypes;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Graphs
{
    /// <summary><b>GraphEntity</b></summary>
    public class ProgressionRequirement
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

using eft_app_guide.Models.Enums.ReferenceTypes;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Payloads
{
    /// <summary><b>PayloadEntity</b></summary>
    public class TargetDescription
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public TargetType TargetType { get; set; }
        [Required] public int TargetKey { get; set; }

        [Required] public string Description { get; set; }
    }
}

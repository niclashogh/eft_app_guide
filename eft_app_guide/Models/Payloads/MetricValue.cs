using eft_app_guide.Models.Enums.ReferenceTypes;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Payloads
{
    /// <summary><b>PayloadEntity</b></summary>
    public class MetricValue
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public ValueTargetType ValueTargetType { get; set; }
        [Required] public double Value { get; set; }
    }
}

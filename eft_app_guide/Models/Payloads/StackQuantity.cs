using eft_app_guide.Models.Enums.ReferenceTypes;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Payloads
{
    /// <summary><b>PayloadEntity</b></summary>
    public class StackQuantity
    {
        #region Keys
        [Key] public int Id {  get; init; }
        #endregion

        [Required] public StackTargetType StackTargetType { get; set; }
        [Required] public int StackTargetKey { get; set; }

        [Required] public int Quantity { get; set; }
    }
}

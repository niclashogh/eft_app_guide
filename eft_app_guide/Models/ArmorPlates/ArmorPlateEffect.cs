using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.ArmorPlates
{
    public class ArmorPlateEffect // TODO - FINISH
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int ArmorPlateId { get; set; }
        #endregion

        [Required] public string Description { get; set; }
    }
}

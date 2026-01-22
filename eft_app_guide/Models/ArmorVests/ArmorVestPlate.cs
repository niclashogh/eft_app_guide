using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.ArmorVests
{
    public class ArmorVestPlate
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int ArmorVestId { get; set; }
        #endregion

        [Required] public byte Class { get; set; }
        [Required] public byte Durability { get; set; }
    }
}

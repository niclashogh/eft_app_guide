using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models._unfinished.ArmorVests
{
    public class ArmorVestEffect // TODO - FINISH
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int ArmorVestId { get; set; }
        #endregion

        [Required] public string Description { get; set; }
    }
}

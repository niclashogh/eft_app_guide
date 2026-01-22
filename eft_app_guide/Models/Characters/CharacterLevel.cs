using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Characters
{
    public class CharacterLevel
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public byte Level {  get; set; }
        [Required] public int MinExperiancePoint { get; set; }
        [Required] public int MaxExperiancePoint { get; set; }
    }
}

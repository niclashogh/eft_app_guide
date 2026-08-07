using eft_app_guide.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Characters.Design
{
    public class CharacterLevel : IGraphSource
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public int Level { get; set; }
        [Required] public int MinimumEXP { get; set; }
    }
}

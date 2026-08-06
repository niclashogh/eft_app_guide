using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Characters.Design
{
    /// <summary><b>DefinitionEntity</b></summary>
    public class CharacterLevel // TODO - FactionCharacterLevelDisplay
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public int Level { get; set; }
        [Required] public int MinimumEXP { get; set; }

        #region Relations

        #endregion
    }
}

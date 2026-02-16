using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Characters.Design
{
    /// <summary> DefinitionEntity </summary>
    public class CharacterLevel
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public int Level { get; set; }
        [Required] public int MinExperincePoint { get; set; }
        [Required] public int MaxExperiencePoint { get; set; }
        [Required] public string Icon { get; set; }
    }
}

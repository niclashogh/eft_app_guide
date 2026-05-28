using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Characters.Design
{
    /// <summary><b>ChildEntity</b> and <b>DefinitionEntity</b></summary>
    public class CharacterLevel // TODO - Add CharacterLevelProgress
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int FactionId {  get; set; }
        #endregion

        [Required] public int Level { get; set; }
        [Required] public int MinExperincePoint { get; set; }
        [Required] public int MaxExperiencePoint { get; set; }
        [Required] public string Badge { get; set; }

        #region Relations

        #endregion
    }
}

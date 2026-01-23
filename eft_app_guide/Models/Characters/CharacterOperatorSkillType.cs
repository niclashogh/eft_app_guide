using eft_app_guide.Models.Operator;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Characters
{
    public class CharacterOperatorSkillType // JunctionTable to save skill-progression per character
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int CharacterId { get; set; }
        [Required] public int OperatorSkillTypeId { get; set; }
        #endregion

        [Required] public int ExperiencePoint {  get; set; }

        #region Relations
        public Character? Character { get; set; }
        public OperatorSkillType? OperatorSkillType { get; set; }
        #endregion
    }
}

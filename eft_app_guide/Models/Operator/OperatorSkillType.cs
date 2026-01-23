using eft_app_guide.Models.Characters;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Operator
{
    public class OperatorSkillType
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations
        public List<OperatorSkillLevel> OperatorSkillLevels { get; set; } = [];
        public List<CharacterOperatorSkillType> CharacterOperatorSkillTypes { get; set; } = [];
        #endregion
    }
}

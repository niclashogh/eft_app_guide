using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Characters
{
    public class CharacterSkillType
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public int EXPTillNextLevel { get; set; }

        #region Relations
        public List<CharacterSkill> Skills { get; set; } = [];
        #endregion
    }
}

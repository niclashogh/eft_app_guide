using eft_app_guide.Models.Characters;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Leveling
{
    public class SkillType
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations
        public List<SkillLevelDefinition> LevelDifinitions { get; set; } = [];
        public List<CharacterSkillProgress> CharacterSkillProgressions { get; set; } = [];
        #endregion
    }
}

using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Characters
{
    public class CharacterSkill
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int CharacterSkillTypeId { get; set; }
        [Required] public int CharacterId { get; set; }
        #endregion

        [Required] public int Level { get; set; }

        #region Relations
        public CharacterSkillType? Type { get; set; }
        public Character? Character { get; set; }
        #endregion
    }
}

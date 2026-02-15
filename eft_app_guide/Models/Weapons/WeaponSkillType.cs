using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Weapons
{
    public class WeaponSkillType // MISSING
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public int EXPTillNextLevel { get; set; }

        #region Relations
        public List<WeaponSkill> Skills { get; set; } = [];
        #endregion
    }
}

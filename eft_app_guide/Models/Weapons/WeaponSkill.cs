using eft_app_guide.Models.Characters;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Weapons
{
    public class WeaponSkill
    {
        #region Keys
        [Key] public int WeaponId { get; set; }
        [Required] public int WeaponSkillTypeId { get; set; }
        [Required] public int CharacterId { get; set; }
        #endregion

        [Required] public int Level { get; set; }

        #region Relations
        public WeaponSkillType? Type { get; set; }
        public Character? Character { get; set; }
        #endregion
    }
}

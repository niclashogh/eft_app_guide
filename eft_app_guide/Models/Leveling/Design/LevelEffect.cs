using eft_app_guide._Persistence.Entities.TargetTypes;
using eft_app_guide.Models._Interfaces;
using eft_app_guide.Models.Skills;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Leveling.Design
{
    public class LevelEffect : ILevelProvider // TODO - Add WeaponMastery class and to LevelTargetType
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int SkillId { get; set; }
        [Required] public int LevelTargetTypeId { get; set; }
        #endregion
        
        [Required] public int TargetKey { get; set; }

        #region Relations (Parents)
        public Skill? Skill { get; set; }
        public LevelTargetType? LevelTargetType { get; set; }
        #endregion
    }
}

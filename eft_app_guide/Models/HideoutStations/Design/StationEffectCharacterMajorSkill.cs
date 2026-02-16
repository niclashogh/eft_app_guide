using eft_app_guide.Models.Characters.Design;
using eft_app_guide.Models.HideoutStations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.HideoutStations.Design
{
    /// <summary> Extends StationEffect </summary>
    [EntityTypeConfiguration(typeof(StationEffectCharacterMajorSkillConfig))]
    public class StationEffectCharacterMajorSkill
    {
        #region Keys
        [Key] public int StationEffectId { get; set; }
        [Required] public int CharacterMajorSkillId { get; set; }
        #endregion

        #region Relations (Parents)
        public StationEffect? StationEffect { get; set; }
        public CharacterMajorSkill? CharacterMajorSkill { get; set; }
        #endregion
    }
}

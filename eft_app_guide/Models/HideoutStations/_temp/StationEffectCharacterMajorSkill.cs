using eft_app_guide.Models.HideoutStations.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.HideoutStations._temp
{
    /// <summary><b>ExtentionEntity of StationEffect</b></summary>
    [EntityTypeConfiguration(typeof(StationEffectCharacterMajorSkillConfig))]
    public class StationEffectCharacterMajorSkill // TODO: Incorp. into StationEffect?
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

using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Skills
{
    public class SkillLevelingProfile // TODO - Add InGame Leveling (129%, 100% < 100%) in SkillLevelRate(Percent Rate, int Cooldown, int UsesBeforeCooldown) to associate Workstation bonuses (Also rename classes to Workstation).
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations (Children)
        public List<SkillLevel> SkillLevels { get; set; } = [];
        #endregion
    }
}

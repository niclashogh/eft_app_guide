using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Skills
{
    public class SkillLevel // TODO
    {
        #region Keys
        [Key] public int Id {  get; init; }
        [Required] public int SkillLevelingProfileId { get; set; }
        #endregion

        [Required] public int Level { get; set; }
        [Required] public int RequiredPoints { get; set; }

        #region Relations (Parents)
        public SkillLevelingProfile? SkillLevelingProfile { get; set; }
        #endregion
    }
}

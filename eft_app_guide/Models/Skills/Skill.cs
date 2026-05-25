using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Skills
{
    public class Skill // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int SkillGroupId { get; set; }
        [Required] public int SkillLevelingProfileId { get; set; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public string Description { get; set; }

        #region Relations (Parents)
        public SkillGroup? SkillGroup { get; set; }
        public SkillLevelingProfile? SkillLevelingProfile { get; set; }
        #endregion
    }
}

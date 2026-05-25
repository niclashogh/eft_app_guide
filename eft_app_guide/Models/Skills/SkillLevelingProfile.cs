using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Skills
{
    public class SkillLevelingProfile // TODO
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

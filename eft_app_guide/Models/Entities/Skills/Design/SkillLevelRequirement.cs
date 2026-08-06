using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Skills.Design
{
    public class SkillLevelRequirement // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public int Level { get; set; }
        [Required] public int RequiredPoints { get; set; }
    }
}

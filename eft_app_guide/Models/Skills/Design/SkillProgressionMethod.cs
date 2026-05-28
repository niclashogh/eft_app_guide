using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Skills.Design
{
    public class SkillProgressionMethod // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int SkillId { get; set; }
        #endregion

        [Required] public string Description { get; set; }
    }
}

using eft_app_guide._Objects.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Skills.Design
{
    public class SkillProgressionModifier // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public int PointThreshold { get; set; }
        [Required] public Percent Rate { get; set; }
    }
}

using eft_app_guide.Models.Skills.Design.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Skills.Design
{
    /// <summary><b>ChildEntity</b> and <b>DefinitionEntity</b>
    /// Containing:<code>
    /// Increase stamina
    /// Reduce jump stamina
    /// Increase breath holding
    /// Reduce breath recovery time
    /// ...
    /// </code></summary>
    [EntityTypeConfiguration(typeof(SkillEffectConfig))]
    public class SkillEffect
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int SkillId { get; set; }
        #endregion

        [Required] public string Effect { get; set; }

        #region Relations (Parents)
        public Skill? Skill { get; set; }
        #endregion
    }
}

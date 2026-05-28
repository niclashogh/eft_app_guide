using eft_app_guide.Models.Skills.Design.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Skills.Design
{
    /// <summary><b>DefinitionEntity</b>
    /// Containing:<code>
    /// Physical
    /// Combat
    /// Practical
    /// Mental
    /// ...
    /// </code></summary>
    [EntityTypeConfiguration(typeof(SkillGroupConfig))]
    public class SkillGroup
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations (Children)
        public List<Skill> Skills { get; set; } = [];
        #endregion
    }
}

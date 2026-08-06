using eft_app_guide.Models._Systems.Leveling;
using eft_app_guide.Models.Entities.Skills.Design.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Skills.Design
{
    /// <summary><b>ChildEntity</b> and <b>DefinitionEntity</b>
    /// Containing:<code>
    /// Endurance
    /// Health
    /// Immunity
    /// Metabolism
    /// Strenght
    /// ...
    /// </code></summary>
    [EntityTypeConfiguration(typeof(SkillConfig))]
    public class Skill
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int SkillGroupId { get; set; }
        [Required] public int LevelingProfileId { get; set; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public string Description { get; set; }

        #region Relations (Parents)
        public SkillGroup? SkillGroup { get; set; }
        public LevelingProfile? LevelingProfile { get; set; }
        #endregion

        #region Relations (Children)
        public List<SkillEffect> SkillEffects { get; set; } = [];
        #endregion
    }
}

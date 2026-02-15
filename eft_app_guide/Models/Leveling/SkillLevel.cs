using eft_app_guide.Models.Leveling.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Leveling
{
    /// <summary> ChildEntity (Skill) </summary>
    [EntityTypeConfiguration(typeof(SkillLevelConfig))]
    public class SkillLevel
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int SkillId { get; set; }
        #endregion

        [Required] public int Level { get; set; }
        [Required] public int MinExperincePoint { get; set; }
        [Required] public int MaxExperiencePoint { get; set; }

        #region Relations
        public Skill? Skill { get; set; }
        #endregion
    }
}

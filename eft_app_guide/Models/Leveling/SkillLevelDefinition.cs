using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Leveling
{
    public class SkillLevelDefinition // LookupTable
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int SkillTypeId { get; set; }
        #endregion

        [Required] public int Level { get; set; }
        [Required] public int MinExperincePoint { get; set; }
        [Required] public int MaxExperiencePoint { get; set; }

        #region Relations
        public SkillType? SkillType { get; set; }
        #endregion
    }
}

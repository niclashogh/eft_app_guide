using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Operator
{
    public class OperatorSkillLevel // Standalone table to determine a characters skill-level
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int OperatorSkillTypeId { get; set; }
        #endregion

        [Required] public int Level { get; set; }
        [Required] public int MinExperincePoint { get; set; }
        [Required] public int MaxExperiencePoint { get; set; }

        #region Relations
        public OperatorSkillType? OperatorSkillType { get; set; }
        #endregion
    }
}

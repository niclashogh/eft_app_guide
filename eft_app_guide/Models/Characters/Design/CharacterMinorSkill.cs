using eft_app_guide.DataTransferObjects.ValueObjects;
using eft_app_guide.Models.Characters.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Characters.Design
{
    /// <summary> ChildEntity (CharacterMajorSkill) - DifintionEntity (Stamia, Jump Stamia Drain, Breath Holding, Breath Recovery, etc.) </summary>
    [EntityTypeConfiguration(typeof(CharacterMinorSkillConfig))]
    public class CharacterMinorSkill
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int CharacterMajorSkillId { get; set; }
        #endregion

        [Required] public string Name { get; set; }

        [Required] public Percent? LevelStepImprovement { get; set; }
        [Required] public Percent? ImprovementCap { get; set; }
        [Required] public string? PeakImprovementDescription { get; set; }

        #region Relations (Parents)
        public CharacterMajorSkill? CharacterMajorSkill { get; set; }
        #endregion
    }
}

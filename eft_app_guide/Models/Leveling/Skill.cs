using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Characters;
using eft_app_guide.Models.Leveling.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Leveling
{
    /// <summary> AggregativeEntity (SkillLevel) </summary>
    [EntityTypeConfiguration(typeof(SkillConfig))]
    public class Skill
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations
        public List<SkillLevel> SkillLevels { get; set; } = [];
        public AssociationList<CharacterSkillProgress> CharacterSkillProgressions { get; set; } = [];
        #endregion
    }
}

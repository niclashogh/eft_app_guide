using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Characters.State;
using eft_app_guide.Models.Leveling.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Leveling
{
    /// <summary> AggregativeEntity (SkillLevel) </summary>
    [EntityTypeConfiguration(typeof(SkillConfig))]
    public class Skill // TODO - DEL?
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations (Children)
        public List<SkillLevel> SkillLevels { get; set; } = [];
        public AssociationList<CharacterMajorSkillProgress> CharacterSkillProgressions { get; set; } = [];
        #endregion
    }
}

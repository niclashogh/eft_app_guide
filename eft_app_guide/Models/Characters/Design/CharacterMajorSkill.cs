using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Characters.Config;
using eft_app_guide.Models.Characters.State;
using eft_app_guide.Models.HideoutStations.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Characters.Design
{
    /// <summary><b>DefinitionEntity</b>
    /// Containing:<code>
    /// Endurance
    /// Health
    /// Immunity
    /// Metabolism
    /// Strenght
    /// ...
    /// </code></summary>
    [EntityTypeConfiguration(typeof(CharacterMajorSkillConfig))]
    public class CharacterMajorSkill
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public int MaxLevel { get; set; }

        #region Relations (Children)
        public List<CharacterMinorSkill> CharacterMinorSkills { get; set; } = [];
        public AssociationList<CharacterMajorSkillProgress> CharacterMajorSkillProgressions { get; set; } = [];
        public List<StationEffectCharacterMajorSkill> StationEffectCharacterMajorSkills { get; set; } = [];
        #endregion
    }
}

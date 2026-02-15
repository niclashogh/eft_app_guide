using eft_app_guide.Models.Characters.Config;
using eft_app_guide.Models.Leveling;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Characters
{
    /// <summary> AssociationEntity (CharacterId + SkillId) </summary>
    [EntityTypeConfiguration(typeof(CharacterSkillProgressConfig))]
    public class CharacterSkillProgress
    {
        #region Keys (CompositeKeys)
        [Required] public int CharacterId { get; set; }
        [Required] public int SkillId { get; set; }
        #endregion

        [Required] public int ExperiencePoint {  get; set; }

        #region Relations (Parents)
        public Character? Character { get; set; }
        public Skill? Skill { get; set; }
        #endregion
    }
}

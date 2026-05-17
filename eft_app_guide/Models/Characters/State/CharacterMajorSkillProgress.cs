using eft_app_guide.Models.Characters.Design;
using eft_app_guide.Models.Characters.State.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Characters.State
{
    /// <summary><b>AssociationEntity</b>
    /// Between:<code>
    /// CharacterId
    /// CharacterMajorSkillId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(CharacterMajorSkillProgressConfig))]
    public class CharacterMajorSkillProgress
    {
        #region Keys (CompositeKeys)
        [Required] public int CharacterId { get; set; }
        [Required] public int CharacterMajorSkillId { get; set; }
        #endregion

        [Required] public int Level {  get; set; }

        #region Relations (Parents)
        public Character? Character { get; set; }
        public CharacterMajorSkill? CharacterMajorSkill { get; set; }
        #endregion
    }
}

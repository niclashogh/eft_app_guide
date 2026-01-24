using eft_app_guide.Models.Leveling;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Characters
{
    public class CharacterSkillProgress // JunctionTable, AssociationEntity
    {
        #region Keys (CompositeKeys)
        [Required] public int CharacterId { get; set; }
        [Required] public int CharacterSkillTypeId { get; set; }
        #endregion

        [Required] public int ExperiencePoint {  get; set; }

        #region Relations
        public Character? Character { get; set; }
        public SkillType? SkillType { get; set; }
        #endregion
    }
}

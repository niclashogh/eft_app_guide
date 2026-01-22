using eft_app_guide.Models.Factions;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Characters
{
    public class Character
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int FactionId { get; set; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public int ExperiencePoint {  get; set; }

        #region Relations
        public Faction? Faction { get; set; }
        
        public List<CharacterSkill> Skills { get; set; } = [];
        #endregion
    }
}

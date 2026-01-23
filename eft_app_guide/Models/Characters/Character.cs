using eft_app_guide.Models.Accounts;
using eft_app_guide.Models.Factions;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Characters
{
    public class Character
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int AccountId { get; set; }
        [Required] public int FactionId { get; set; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public int ExperiencePoint { get; set; }

        #region Relations
        public Account? Account { get; set; }
        public Faction? Faction { get; set; }

        public List<CharacterOperatorSkillType> CharacterOperatorSkillTypes { get; set; } = [];
        public List<CharacterQuest> CharacterQuests { get; set; } = [];
        #endregion
    }
}

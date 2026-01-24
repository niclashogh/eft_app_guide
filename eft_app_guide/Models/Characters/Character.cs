using eft_app_guide.Models.Accounts;
using eft_app_guide.Models.Factions;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Characters
{
    public class Character
    {
        #region Keys (CompositeKeys)
        [Required] public int AccountId { get; set; }
        [Required] public int FactionId { get; set; }
        #endregion

        [Required] public int ExperiencePoint { get; set; }

        #region Relations
        public Account? Account { get; set; }
        public Faction? Faction { get; set; }

        public List<CharacterSkillProgress> SkillProgressions { get; set; } = [];
        public List<CharacterQuestProgress> QuestProgressions { get; set; } = [];
        #endregion
    }
}

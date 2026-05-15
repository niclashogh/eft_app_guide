using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Accounts.State;
using eft_app_guide.Models.Characters.Config;
using eft_app_guide.Models.Factions.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Characters.State
{
    /// <summary><b>AggregativeEntity</b>
    /// Relations:<code>
    /// Account
    /// Faction
    /// CharacterMapAccess
    /// CharacterQuestProgress
    /// CharacterMajorSkillProgress
    /// CharacterStationLevelProgress
    /// CharacterTraderReputation
    /// CharacterAchievementProgress
    /// CharacterRaid
    /// </code></summary>
    [EntityTypeConfiguration(typeof(CharacterConfig))]
    public class Character
    {
        #region Keys (CompositeKeys)
        [Required] public int AccountId { get; set; }
        [Required] public int FactionId { get; set; }
        #endregion

        [Required] public int ExperiencePoint { get; set; }

        #region Relations (Parents)
        public Account? Account { get; set; }
        public Faction? Faction { get; set; }
        #endregion

        #region Relations (Children)
        public AssociationList<CharacterMapAccess> CharacterMapAccesses { get; set; } = [];
        public AssociationList<CharacterQuestProgress> CharacterQuestProgressions { get; set; } = [];
        public AssociationList<CharacterMajorSkillProgress> CharacterMajorSkillProgressions { get; set; } = [];
        public AssociationList<CharacterStationLevelProgress> CharacterStationLevelProgressions { get; set; } = [];
        public AssociationList<CharacterTraderReputation> CharacterTraderReputations { get; set; } = [];
        public AssociationList<CharacterAchievementProgress> CharacterAchievementProgressions { get; set; } = [];
        public AssociationList<CharacterRaid> CharacterRaids { get; set; } = [];
        #endregion
    }
}

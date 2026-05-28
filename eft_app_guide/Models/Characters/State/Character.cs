using eft_app_guide._Objects.Types;
using eft_app_guide.Models.Accounts.State;
using eft_app_guide.Models.Characters.State.Config;
using eft_app_guide.Models.Factions.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Characters.State
{
    /// <summary><b>AggregativeEntity</b>
    /// Relations:<code>
    /// PARENTS:
    /// Account
    /// Faction
    /// 
    /// ASSOCIATIONS:
    /// CharacterMapAccess
    /// CharacterQuestProgress
    /// CharacterStationLevelProgress
    /// CharacterTraderProgress
    /// CharacterAchievementProgress
    /// CharacterRaidStatistic
    /// CharacterChapterProgress
    /// CharacterChapterTaskProgress
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
        public AssociationList<CharacterStationLevelProgress> CharacterStationLevelProgressions { get; set; } = [];
        public AssociationList<CharacterTraderProgress> CharacterTraderProgressions { get; set; } = [];
        public AssociationList<CharacterAchievementProgress> CharacterAchievementProgressions { get; set; } = [];
        public AssociationList<CharacterRaidStatistic> CharacterRaidStatistics { get; set; } = [];
        public AssociationList<CharacterChapterProgress> CharacterChapterProgressions { get; set; } = [];
        public AssociationList<CharacterChapterTaskProgress> CharacterChapterTaskProgressions { get; set; } = [];
        #endregion
    }
}

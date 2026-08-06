using eft_app_guide._Objects.Types;
using eft_app_guide.Models.Entities.Accounts.State;
using eft_app_guide.Models.Entities.Characters.State.Config;
using eft_app_guide.Models.Entities.Factions.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Characters.State
{
    [EntityTypeConfiguration(typeof(CharacterConfig))]
    public class Character // TODO - Prestige + PrestigeDisplay
    {
        #region Keys (CompositeKeys)
        [Required] public int AccountId { get; set; }
        [Required] public int FactionId { get; set; }
        #endregion

        [Required] public int Prestige {  get; set; }
        [Required] public int Level { get; set; }
        [Required] public int AccumulatedEXP { get; set; }

        #region Relations (Parents)
        public Account? Account { get; set; }
        public Faction? Faction { get; set; }
        #endregion

        #region Relations (Children)
        public AssociationList<CharacterMapAccess> CharacterMapAccesses { get; set; } = [];
        public AssociationList<CharacterQuestProgress> CharacterQuestProgressions { get; set; } = [];
        public AssociationList<CharacterStationLevelProgress> CharacterStationLevelProgressions { get; set; } = [];
        public AssociationList<CharacterPatronProgress> CharacterPatronProgressions { get; set; } = [];
        public AssociationList<CharacterAchievementProgress> CharacterAchievementProgressions { get; set; } = [];
        public AssociationList<CharacterRaidStatistic> CharacterRaidStatistics { get; set; } = [];
        public AssociationList<CharacterChapterProgress> CharacterChapterProgressions { get; set; } = [];
        public AssociationList<CharacterChapterTaskProgress> CharacterChapterTaskProgressions { get; set; } = [];
        #endregion
    }
}

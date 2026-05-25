using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Achievements.Design.Config;
using eft_app_guide.Models.Achievements.Relations;
using eft_app_guide.Models.Characters.State;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Achievements.Design
{
    /// <summary><b>ChildEntity</b> and <b>AggregativeEntity</b>
    /// Relations:<code>
    /// PARENTS:
    /// AchievementRarity
    /// 
    /// ASSOCIATIONS:
    /// AchievementReward
    /// CharacterAchievementProgress
    /// </code></summary>
    [EntityTypeConfiguration(typeof(AchievementConfig))]
    public class Achievement
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int AchivementRarityId { get; set; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public string Description { get; set; }

        #region Relations (Parents)
        public AchievementRarity? AchievementRarity { get; set; }
        #endregion

        #region Relations (Children)
        public AssociationList<AchievementReward> AchievementRewards { get; set; } = [];
        public AssociationList<CharacterAchievementProgress> CharacterAchievementProgressions { get; set; } = [];
        #endregion
    }
}

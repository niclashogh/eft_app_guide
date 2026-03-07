using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Accounts.State;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Achievements.Design
{
    /// <summary> AggregativeEntity (AchievementRarity + AccountAchievementProgress) </summary>
    [EntityTypeConfiguration(typeof())]
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
        public AssociationList<AccountAchievementProgress> AccountAchievementProgressions { get; set; } = [];
        #endregion
    }
}

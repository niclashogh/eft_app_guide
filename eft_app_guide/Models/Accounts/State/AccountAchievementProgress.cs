using eft_app_guide.Models.Achievements.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Accounts.State
{
    /// <summary> AssociationEntity (AccountId + AchievementId) </summary>
    [EntityTypeConfiguration(typeof())]
    public class AccountAchievementProgress
    {
        #region Keys (CompositeKeys)
        [Required] public int AccountId { get; set; }
        [Required] public int AchievementId { get; set; }
        #endregion

        [Required] public DateTime CompletionDate { get; set; }

        #region Relations (Parents)
        public Account? Account { get; set; }
        public Achievement? Achievement { get; set; }
        #endregion
    }
}

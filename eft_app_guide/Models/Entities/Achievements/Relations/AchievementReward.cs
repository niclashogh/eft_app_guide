using eft_app_guide.Models.Entities.Achievements.Design;
using eft_app_guide.Models.Entities.Achievements.Relations.Config;
using eft_app_guide.Models.Graphs;
using eft_app_guide.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Achievements.Relations
{
    /// <summary><b>JunctionEntity</b></summary>
    [EntityTypeConfiguration(typeof(AchievementRewardConfig))]
    public class AchievementReward : IProgressionReward
    {
        #region Keys
        [Required] public int AchievementId { get; set; }
        [Required] public int ProgressionRewardId { get; set; }
        #endregion

        #region Relations (Parents)
        public Achievement? Achievement { get; set; }
        public ProgressionReward? ProgressionReward { get; set; }
        #endregion
    }
}

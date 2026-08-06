using eft_app_guide.Models.Entities.Achievements.Design.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Achievements.Design
{
    /// <summary><b>DefintionEntity</b></summary>
    [EntityTypeConfiguration(typeof(AchievementRarityConfig))]
    public class AchievementRarity
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations (Children)
        public List<Achievement> Achievements { get; set; } = [];
        #endregion
    }
}

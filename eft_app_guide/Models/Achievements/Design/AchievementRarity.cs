using eft_app_guide.Models.Achievements.Design.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Achievements.Design
{
    /// <summary><b>DefinitionEntity</b>
    /// Containing:<code>
    /// Common
    /// Rare
    /// Legendary
    /// ...
    /// </code></summary>
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

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Achievements.Design
{
    /// <summary> DefinitionEntity (Common, Rare, Legendary) </summary>
    [EntityTypeConfiguration(typeof())]
    public class AchievementRarity
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations ()
        // List<Achievement>
        #endregion
    }
}

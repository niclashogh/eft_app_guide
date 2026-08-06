using eft_app_guide.Models.Entities.Achievements.Design;
using eft_app_guide.Models.Entities.Characters.State.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Characters.State
{
    /// <summary><b>AssociationEntity</b>
    /// Between:<code>
    /// CharacterId
    /// AchievementId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(CharacterAchievementProgressConfig))]
    public class CharacterAchievementProgress
    {
        #region Keys (CompositeKeys)
        [Required] public int CharacterId { get; set; }
        [Required] public int AchievementId { get; set; }
        #endregion

        [Required] public DateTime CompletionDate { get; set; }

        #region Relations (Parents)
        public Character? Character { get; set; }
        public Achievement? Achievement { get; set; }
        #endregion
    }
}

using eft_app_guide.Models.Entities.Achievements.Design;
using eft_app_guide.Models.Entities.Characters.State.Objectives.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Characters.State.Objectives
{
    /// <summary><b>AssociationEntity</b></summary>
    [EntityTypeConfiguration(typeof(CharacterAchievementProgressConfig))]
    public class CharacterAchievementProgress
    {
        #region Keys (CompositeKeys)
        [Required] public int CharacterId { get; set; }
        [Required] public int AchievementId { get; set; }
        #endregion

        [Required] public bool IsCompleted { get; set; }
        [Required] public DateTime CompletionDate { get; set; }

        #region Relations
        public Character? Character { get; set; }
        public Achievement? Achievement { get; set; }
        #endregion
    }
}

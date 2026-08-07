using eft_app_guide._Objects.Types;
using eft_app_guide.Models.Entities.Achievements.Design.Config;
using eft_app_guide.Models.Entities.Characters.State.Objectives;
using eft_app_guide.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Achievements.Design
{
    [EntityTypeConfiguration(typeof(AchievementConfig))]
    public class Achievement : IGraphTarget, IGraphSource
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int AchivementRarityId { get; set; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public string Description { get; set; }

        #region Relations
        public AchievementRarity? AchievementRarity { get; set; }
        public AssociationList<CharacterAchievementProgress> CharacterAchievementProgressions { get; set; } = [];
        #endregion
    }
}

using eft_app_guide.Models._Enums;
using eft_app_guide.Models._Interfaces;
using eft_app_guide.Models.Chapters.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters
{
    [EntityTypeConfiguration(typeof(ChapterRewardConfig))]
    public class ChapterReward : IReward
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int ChapterId { get; set; }
        #endregion

        [Required] public string Description { get; set; }
        [Required] public RewardTypes Type { get; set; }
        [Required] public int TypeKey { get; set; }
        [Required] public int Quantity { get; set; }

        #region Relatations
        public Chapter? Chapter { get; set; }
        #endregion
    }
}

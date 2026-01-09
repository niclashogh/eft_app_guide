using eft_app_guide.Models.Quests.Enums;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters
{
    public class ChapterReward
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int ChapterId { get; set; }
        #endregion

        public string Reward { get; set; }

        #region Relatations
        public Chapter? Chapter { get; set; }
        #endregion
    }
}

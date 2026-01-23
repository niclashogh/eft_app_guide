using eft_app_guide.Models.Chapters.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters
{
    [EntityTypeConfiguration(typeof(ChapterConfig))]
    public class Chapter
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relatations
        public List<ChapterTask> Tasks { get; set; } = [];
        public List<ChapterRequirement> Requirements { get; set; } = [];
        public List<ChapterReward> Rewards { get; set; } = [];
        #endregion
    }
}

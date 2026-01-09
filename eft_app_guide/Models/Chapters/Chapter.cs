using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters
{
    public class Chapter
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relatations
        public List<ChapterTasks> Tasks { get; set; } = new();
        public List<ChapterRequirement> Requirements { get; set; } = new();
        public List<ChapterReward> Rewards { get; set; } = new();
        #endregion
    }
}

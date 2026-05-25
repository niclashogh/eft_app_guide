using eft_app_guide._Persistence.Entities.Grouping.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide._Persistence.Entities.Grouping
{
    /// <summary><b>DefintionEntity</b>
    /// Containing:<code>
    /// Quests
    /// Chapters
    /// ChapterTasks
    /// OperatorTeams
    /// ...
    /// </code></summary>
    [EntityTypeConfiguration(typeof(GroupTypeConfig))]
    public class GroupType
    {
        #region Keys
        [Key] public int Id {  get; init; }
        #endregion

        [Required] public string Name {  get; set; }

        #region Relations (Children)
        public List<Group> Groups { get; set; } = [];
        #endregion
    }
}

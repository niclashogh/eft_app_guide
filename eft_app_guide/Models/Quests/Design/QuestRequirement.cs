using eft_app_guide.Models.Quests.Design.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Quests.Design
{
    /// <summary><b>ChildEntity of Quest</b></summary>
    [EntityTypeConfiguration(typeof(QuestRequirementConfig))]
    public class QuestRequirement
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int QuestId { get; set; }
        #endregion

        [Required] public string Description { get; set; }

        #region Relations (Parents)
        public Quest? Quest { get; set; }
        #endregion
    }
}

using eft_app_guide.Models.Quests.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Quests
{
    [EntityTypeConfiguration(typeof(QuestRequirementConfig))]
    public class QuestRequirement
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int QuestId { get; set; }
        #endregion

        [Required] public string Requirement { get; set; }

        #region Relations
        public Quest? Quest { get; set; }
        #endregion
    }
}

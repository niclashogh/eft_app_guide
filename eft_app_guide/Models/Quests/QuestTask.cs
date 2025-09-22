using eft_app_guide.Models.Entities;
using eft_app_guide.Models.Interfaces;
using eft_app_guide.Models.Quests.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Quests
{
    [EntityTypeConfiguration(typeof(QuestTaskConfig))]
    public class QuestTask : BasePosition, IPosition
    {
        #region Keys
        [Key] public int Id { get; set; }
        [Required] public int QuestId { get; set; }
        [Required] public string MapName { get; set; }
        #endregion

        [Required] public string Description { get; set; }
        [Required] public int Sequence { get; set; }

        #region Relations
        public Quest? Quest { get; set; }
        public Map? Map { get; set; }
        #endregion
    }
}

using eft_app_guide.Models.Quests.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Quests.Design
{
    /// <summary> AggregativeEntity (Quest) </summary>
    [EntityTypeConfiguration(typeof(QuestLineConfig))]
    public class QuestLine
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations (Children)
        public List<Quest> Quests { get; set; } = [];
        #endregion
    }
}

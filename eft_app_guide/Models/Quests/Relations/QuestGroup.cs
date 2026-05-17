using eft_app_guide._Persistence.Entities.Grouping;
using eft_app_guide.Models._Interfaces;
using eft_app_guide.Models.Quests.Design;
using eft_app_guide.Models.Quests.Relations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Quests.Relations
{
    /// <summary><b>JunctionTable</b>
    /// Between:<code>
    /// QuestId
    /// GroupId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(QuestGroupConfig))]
    public class QuestGroup : IGroup
    {
        #region Keys (CompositeKeys)
        [Required] public int QuestId { get; set; }
        [Required] public int GroupId { get; set; }
        #endregion

        #region Relations (Parents)
        public Quest? Quest { get; set; }
        public Group? Group { get; set; }
        #endregion
    }
}

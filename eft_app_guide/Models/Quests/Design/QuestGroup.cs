using eft_app_guide.Models._Interfaces;
using eft_app_guide.Models.Quests.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Quests.Design
{
    /// <summary> Extends Quest </summary>
    [EntityTypeConfiguration(typeof(QuestGroupConfig))]
    public class QuestGroup : IGroup
    {
        #region Keys
        [Key] public int QuestId { get; set; }
        [Required] public string GUID { get; set; }
        #endregion

        #region Relations (Parents)
        public Quest? Quest { get; set; }
        #endregion
    }
}

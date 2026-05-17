using eft_app_guide._Persistence.Entities.Grouping.Config;
using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.AI.Relations;
using eft_app_guide.Models.Chapters.Relations;
using eft_app_guide.Models.Quests.Relations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide._Persistence.Entities.Grouping
{
    /// <summary><b>AggregativeEntity</b>
    /// Relations:<code>
    /// PARENTS:
    /// GroupType
    /// 
    /// ASSOCIATIONS:
    /// QuestGroup
    /// QuestTaskGroup
    /// ChapterTaskGroup
    /// HumanGroup
    /// </code></summary>
    [EntityTypeConfiguration(typeof(GroupConfig))]
    public class Group
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int GroupTypeId { get; set; }
        #endregion

        public string? Name { get; set; }
        public string? Description { get; set; }

        #region Relations (Parents)
        public GroupType? GroupType { get; set; }
        #endregion

        #region Relations (Children)
        public AssociationList<QuestGroup> QuestGroups { get; set; } = [];
        public AssociationList<QuestTaskGroup> QuestTaskGroups {  get; set; } = [];
        public AssociationList<ChapterTaskGroup> ChapterTaskGroups { get; set; } = [];
        public AssociationList<HumanGroup> HumanGroups {  get; set; } = [];
        #endregion
    }
}

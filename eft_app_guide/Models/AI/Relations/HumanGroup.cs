using eft_app_guide._Persistence.Entities.Grouping;
using eft_app_guide.Models._Interfaces;
using eft_app_guide.Models.AI.Design;
using eft_app_guide.Models.AI.Relations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.AI.Relations
{
    /// <summary><b>JunctionTable</b>
    /// Between:<code>
    /// HumanId
    /// GroupId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(HumanGroupConfig))]
    public class HumanGroup : IGroup
    {
        #region Keys (CompositeKeys)
        [Required] public int HumanId { get; set; }
        [Required] public int GroupId { get; set; }
        #endregion

        #region Relations (Parents)
        public Human? Human { get; set; }
        public Group? Group { get; set; }
        #endregion
    }
}

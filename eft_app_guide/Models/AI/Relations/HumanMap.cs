using eft_app_guide.Models.AI.Design;
using eft_app_guide.Models.AI.Relations.Config;
using eft_app_guide.Models.Maps.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.AI.Relations
{
    /// <summary><b>JunctionTable</b>
    /// Between:<code>
    /// HumanId
    /// MapId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(HumanMapConfig))]
    public class HumanMap
    {
        #region Keys (CompositeKeys)
        [Required] public int HumanId { get; set; }
        [Required] public int MapId { get; set; }
        #endregion

        #region Relations (Parents)
        public Human? Human { get; set; }
        public Map? Map { get; set; }
        #endregion
    }
}

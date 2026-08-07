using eft_app_guide.Models.Graphs;
using eft_app_guide.Models.Interfaces;
using eft_app_guide.Models.Entities.Actors.Relations.Config;
using eft_app_guide.Models.Entities.Actors.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Actors.Relations
{
    /// <summary><b>JunctionTable</b></summary>
    [EntityTypeConfiguration(typeof(HumanGroupConfig))]
    public class HumanGroup : IGroup
    {
        #region Keys (CompositeKeys)
        [Required] public int HumanId { get; set; }
        [Required] public int GroupId { get; set; }
        #endregion

        #region Relations
        public Human? Human { get; set; }
        public Group? Group { get; set; }
        #endregion
    }
}

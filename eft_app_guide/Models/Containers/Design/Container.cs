using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Containers.Design.Config;
using eft_app_guide.Models.Containers.Relations;
using eft_app_guide.Models.Locations.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Containers.Design
{
    /// <summary><b>AggregativeEntity</b>
    /// Relations:<code>
    /// PARENTS:
    /// Location
    /// ContainerType
    /// 
    /// JUNCTIONS:
    /// ContainerAccess
    /// </code></summary>
    [EntityTypeConfiguration(typeof(ContainerConfig))]
    public class Container
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int LocationId { get; set; }
        [Required] public int ContainerTypeId { get; set; }
        #endregion

        [Required] public bool IsLocked { get; set; }

        #region Relations (Parents)
        public Location? Location { get; set; }
        public ContainerType? ContainerType { get; set; }
        #endregion

        #region Relations (Children)
        public JunctionList<ContainerAccess> ContainerAccesses { get; set; } = [];
        #endregion
    }
}

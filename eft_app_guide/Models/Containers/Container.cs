using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Containers.Config;
using eft_app_guide.Models.Locations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Containers
{
    /// <summary> AggregativeEntity (ContainerType + ContainerAccess) </summary>
    [EntityTypeConfiguration(typeof(ContainerConfig))]
    public class Container
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int LocationId { get; set; }
        [Required] public int ContainerTypeId { get; set; }
        #endregion

        [Required] public bool IsLocked { get; set; }

        #region Relations
        public Location? Location { get; set; }
        public ContainerType? ContainerType { get; set; }

        public JunctionList<ContainerAccess> ContainerAccesses { get; set; } = [];
        #endregion
    }
}

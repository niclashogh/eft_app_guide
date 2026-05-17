using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.AccessKeys.Design.Config;
using eft_app_guide.Models.Containers.Relations;
using eft_app_guide.Models.Locations.Relations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.AccessKeys.Design
{
    /// <summary><b>DefintionEntity</b>
    /// Containing:<code>
    /// Keys
    /// Keycards
    /// ...
    /// </code></summary>
    [EntityTypeConfiguration(typeof(AccessKeyConfig))]
    public class AccessKey
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public string ShortendName { get; set; }

        [Required] public bool LimitedUses { get; set; }
        [Required] public int MaxUses { get; set; }

        #region relations (Children)
        public AssociationList<LocationAccess> LocationAccesses { get; set; } = [];
        public JunctionList<ContainerAccess> ContainerAccesses { get; set; } = [];
        #endregion
    }
}

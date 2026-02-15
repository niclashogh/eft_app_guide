using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.AccessKeys.Config;
using eft_app_guide.Models.Containers;
using eft_app_guide.Models.Locations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.AccessKeys
{
    /// <summary> DefintionEntity (Keys, Keycards, etc.) </summary>
    [EntityTypeConfiguration(typeof(AccessKeyConfig))]
    public class AccessKey
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region relations
        public AssociationList<LocationAccess> LocationAccesses { get; set; } = [];
        public JunctionList<ContainerAccess> ContainerAccesses { get; set; } = [];
        #endregion
    }
}

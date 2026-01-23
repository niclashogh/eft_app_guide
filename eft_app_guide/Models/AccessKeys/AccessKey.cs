using eft_app_guide.Models.AccessKeys.Config;
using eft_app_guide.Models.Containers;
using eft_app_guide.Models.Locations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.AccessKeys
{
    [EntityTypeConfiguration(typeof(AccessKeyConfig))]
    public class AccessKey
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region relations
        public List<LocationAccess> LocationAccess { get; set; } = [];
        public List<ContainerAccess> ContainerAccess { get; set; } = [];
        #endregion
    }
}

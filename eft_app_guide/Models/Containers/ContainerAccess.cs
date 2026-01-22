using eft_app_guide.Models.AccessKeys;
using eft_app_guide.Models.Containers.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Containers
{
    [EntityTypeConfiguration(typeof(ContainerAccessConfig))]
    public class ContainerAccess
    {
        #region Keys
        [Key] public int ContainerId { get; init; }
        [Required] public int AccessKeyId { get; set; }
        #endregion

        [Required] public bool IsLocked { get; set; }

        #region Relations
        public Container? Container { get; set; }
        public AccessKey? AccessKey { get; set; }
        #endregion
    }
}

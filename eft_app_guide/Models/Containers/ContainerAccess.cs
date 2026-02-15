using eft_app_guide.Models.AccessKeys;
using eft_app_guide.Models.Containers.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Containers
{
    /// <summary> JunctionEntity (ContainerId + AccessKeyId) </summary>
    [EntityTypeConfiguration(typeof(ContainerAccessConfig))]
    public class ContainerAccess
    {
        #region Keys (CompositeKeys)
        [Required] public int ContainerId { get; set; }
        [Required] public int AccessKeyId { get; set; }
        #endregion

        #region Relations
        public Container? Container { get; set; }
        public AccessKey? AccessKey { get; set; }
        #endregion
    }
}

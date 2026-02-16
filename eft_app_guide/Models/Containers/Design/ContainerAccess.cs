using eft_app_guide.Models.AccessKeys.Design;
using eft_app_guide.Models.Containers.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Containers.Design
{
    /// <summary> JunctionEntity (ContainerId + AccessKeyId) </summary>
    [EntityTypeConfiguration(typeof(ContainerAccessConfig))]
    public class ContainerAccess
    {
        #region Keys (CompositeKeys)
        [Required] public int ContainerId { get; set; }
        [Required] public int AccessKeyId { get; set; }
        #endregion

        #region Relations (Parents)
        public Container? Container { get; set; }
        public AccessKey? AccessKey { get; set; }
        #endregion
    }
}

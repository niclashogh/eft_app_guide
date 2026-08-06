using eft_app_guide.Models.Entities.AccessKeys.Design;
using eft_app_guide.Models.Entities.Containers.Design;
using eft_app_guide.Models.Entities.Containers.Relations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Containers.Relations
{
    /// <summary><b>JunctionEntity</b>
    /// Between:<code>
    /// ContainerId
    /// AccessKeyId
    /// </code></summary>
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

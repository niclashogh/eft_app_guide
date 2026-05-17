using eft_app_guide.Models.AccessKeys.Design;
using eft_app_guide.Models.Locations.Design;
using eft_app_guide.Models.Locations.Relations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Locations.Relations
{
    /// <summary><b>AssociationEntity</b>
    /// Between:<code>
    /// LocationId
    /// AccessKeyId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(LocationAccessConfig))]
    public class LocationAccess
    {
        #region Keys (CompositeKeys)
        [Required] public int LocationId { get; set; }
        [Required] public int AccessKeyId { get; set; }
        #endregion

        [Required] public bool IsLocked { get; set; }

        #region Relations (Parents)
        public Location? Location { get; set; }
        public AccessKey? AccessKey { get; set; }
        #endregion
    }
}

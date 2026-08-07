using eft_app_guide._Objects.ValueObjects;
using eft_app_guide.Models.Entities.Containers.Design.Config;
using eft_app_guide.Models.Entities.Locations.Design;
using eft_app_guide.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Containers.Design
{
    [EntityTypeConfiguration(typeof(ContainerConfig))]
    public class Container : IGraphTarget, IGraphSource
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int ContainerTypeId { get; set; }
        #endregion

        [Required] public bool IsLocked { get; set; }
        /// <summary> Sealed with a keyless lock </summary>
        [Required] public bool IsSealed { get; set; }
        [Required] public Percent SealedProbability { get; set; }

        #region Relations
        public Location? Location { get; set; }
        public ContainerType? ContainerType { get; set; }
        #endregion
    }
}

using eft_app_guide._Objects.ValueObjects;
using eft_app_guide.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Locations.Design
{
    public class GeoAccessPoint : IGraphTarget // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        public int? GeoBuildingId { get; set; }
        public int? GeoConfinedSpaceId { get; set; }
        #endregion

        [Required] public string Name { get; set; }

        [Required] public bool IsLocked { get; set; }
        /// <summary> Sealed with a keyless lock </summary>
        [Required] public bool IsSealed { get; set; }
        [Required] public Percent SealedProbability { get; set; }
    }
}

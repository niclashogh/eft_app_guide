using eft_app_guide.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Locations.Design
{
    public class GeoConfinedSpace : IGraphSource // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        public int? GeoProximityId { get; set; }
        public int? GeoBuildingId { get; set; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations
        public GeoProximity? Proximity { get; set; }
        public GeoBuilding? Building { get; set; }
        public List<GeoAccessPoint> AccessPoints { get; set; } = [];
        public List<GeoConfinedSpace> ConfinedSpaces { get; set; } = [];
        #endregion
    }
}

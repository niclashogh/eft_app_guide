using eft_app_guide.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Locations.Design
{
    public class GeoBuilding : IGraphSource // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        public int? GeoProximityId { get; set; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations
        public GeoProximity? Proximity { get; set; }
        public List<GeoAccessPoint> AccessPoints { get; set; } = [];
        public List<GeoConfinedSpace> ConfinedSpaces { get; set; } = [];
        #endregion
    }
}

using eft_app_guide.Models.Entities.Maps.Design;
using eft_app_guide.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Locations.Design
{
    public class GeoProximity : IGraphTarget, IGraphSource // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int MapId { get; set; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations
        public Map? Map { get; set; }
        public List<GeoBuilding> Buildings { get; set; } = [];
        public List<GeoConfinedSpace> ConfinedSpaces { get; set; } = [];
        #endregion
    }
}

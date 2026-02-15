using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Containers;
using eft_app_guide.Models.Locations.Config;
using eft_app_guide.Models.Maps;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Locations
{
    /// <summary> AggregativeEntity (LocationDisplay + LocationItem + LocationAccess + Container) </summary>
    [EntityTypeConfiguration(typeof(LocationConfig))]
    public class Location
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int MapId { get; set; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations (Parents)
        public Map? Map { get; set; }
        #endregion

        #region Relations (Children)
        public AssociationList<LocationItem> LocationItems { get; set; } = [];
        public AssociationList<LocationAccess> LocationAccesses { get; set; } = [];
        public List<Container> Containers { get; set; } = [];
        #endregion

        #region Relations (Extensions)
        public LocationDisplay? LocationDisplay { get; set; }
        #endregion
    }
}

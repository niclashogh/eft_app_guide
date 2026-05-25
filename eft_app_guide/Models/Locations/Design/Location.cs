using eft_app_guide._Persistence.Entities.Display;
using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Containers.Design;
using eft_app_guide.Models.Locations.Design.Config;
using eft_app_guide.Models.Locations.Relations;
using eft_app_guide.Models.Maps.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Locations.Design
{
    /// <summary><b>ChildEntity</b> and <b>AggregativeEntity</b>
    /// Relations:<code>
    /// PARENTS:
    /// Map
    /// 
    /// CHILDREN:
    /// Container
    /// 
    /// ASSOCIATIONS:
    /// LocationItem
    /// LocationAccess
    /// LocationDisplay
    /// </code></summary>
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
        public List<Container> Containers { get; set; } = [];

        public AssociationList<LocationItem> LocationItems { get; set; } = [];
        public AssociationList<LocationAccess> LocationAccesses { get; set; } = [];
        public AssociationList<LocationDisplay> LocationDisplays { get; set; } = [];
        #endregion
    }
}

using eft_app_guide.Models.Containers;
using eft_app_guide.Models.Locations.Config;
using eft_app_guide.Models.Maps;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Locations
{
    [EntityTypeConfiguration(typeof(LocationConfig))]
    public class Location
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int MapId { get; set; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations
        public Map? Map { get; set; }

        public List<LocationLoot> Loot { get; set; } = new();
        public List<LocationAccess> Access { get; set; } = new();
        public List<Container> Containers { get; set; } = new();
        #endregion
    }
}

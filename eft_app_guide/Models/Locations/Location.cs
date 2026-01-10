using eft_app_guide.Models.AccessKeys;
using eft_app_guide.Models.Locations.Config;
using eft_app_guide.Models.LootableContainers;
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
        public int? AccessKeyId { get; set; }
        #endregion

        [Required] public bool Locked { get; set; }

        #region Relations
        public Map? Map { get; set; }
        public AccessKey? AccessKey { get; set; }

        public List<LocationLoot> Loot { get; set; } = new();
        public List<LootableContainer> LootableContainers { get; set; } = new();
        #endregion
    }
}

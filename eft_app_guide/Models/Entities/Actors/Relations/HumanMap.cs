using eft_app_guide._Objects.ValueObjects;
using eft_app_guide.Models.Entities.Actors.Design;
using eft_app_guide.Models.Entities.Actors.Relations.Config;
using eft_app_guide.Models.Entities.Maps.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Actors.Relations
{
    /// <summary><b>AssociationEnitity</b></summary>
    [EntityTypeConfiguration(typeof(HumanMapConfig))]
    public class HumanMap
    {
        #region Keys (CompositeKeys)
        [Required] public int HumanId { get; set; }
        [Required] public int MapId { get; set; }
        #endregion

        [Required] public Percent SpawnChance { get; set; }
        public GameTime? SpawningStartTime { get; set; }
        public GameTime? SpawningEndTime { get; set; }

        #region Relations
        public Human? Human { get; set; }
        public Map? Map { get; set; }
        #endregion
    }
}

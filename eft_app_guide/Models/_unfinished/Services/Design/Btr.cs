using eft_app_guide._Objects.ValueObjects;
using eft_app_guide.Models._unfinished.Services.Design.Config;
using eft_app_guide.Models.Entities.Maps.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models._unfinished.Services.Design
{
    [EntityTypeConfiguration(typeof(BtrConfig))]
    public class Btr // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int MapId { get; set; }
        #endregion

        [Required] public Percent SpawnChance { get; set; }

        #region Relations
        public Map? Map { get; set; }
        #endregion
    }
}

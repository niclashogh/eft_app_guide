using eft_app_guide.Models.Maps;
using eft_app_guide.Models.Services.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Services
{
    /// <summary> DefintionEntity </summary>
    [EntityTypeConfiguration(typeof(BtrConfig))]
    public class Btr
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int MapId { get; set; }
        #endregion

        [Required] public string Location { get; set; }

        #region Relations
        public Map? Map { get; set; }
        public BtrDisplay? BtrDisplay { get; set; }
        #endregion
    }
}

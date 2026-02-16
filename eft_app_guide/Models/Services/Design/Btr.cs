using eft_app_guide.Models.Maps.Design;
using eft_app_guide.Models.Services.Config;
using eft_app_guide.Models.Services.State;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Services.Design
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

        #region Relations (Parents)
        public Map? Map { get; set; }
        #endregion

        #region Relations (Extensions)
        public BtrDisplay? BtrDisplay { get; set; }
        #endregion
    }
}

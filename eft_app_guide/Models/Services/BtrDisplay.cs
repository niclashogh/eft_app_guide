using eft_app_guide.Models.Interfaces;
using eft_app_guide.Models.Services.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Services
{
    /// <summary> Extends Btr </summary>
    [EntityTypeConfiguration(typeof(BtrDisplayConfig))]
    public class BtrDisplay : IPosition
    {
        #region Keys
        [Key] public int BtrId { get; init; }
        #endregion

        [Required] public double X { get; set; }
        [Required] public double Y { get; set; }

        #region Relations
        public Btr? Btr { get; set; }
        #endregion
    }
}

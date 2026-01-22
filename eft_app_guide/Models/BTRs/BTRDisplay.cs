using eft_app_guide.Models.BTRs.Config;
using eft_app_guide.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.BTRs
{
    [EntityTypeConfiguration(typeof(BTRDisplayConfig))]
    public class BTRDisplay : IPosition
    {
        #region Keys
        [Key] public int BTRId { get; init; }
        #endregion

        [Required] public double X { get; set; }
        [Required] public double Y { get; set; }

        #region Relations
        public BTR? BTR { get; set; }
        #endregion
    }
}

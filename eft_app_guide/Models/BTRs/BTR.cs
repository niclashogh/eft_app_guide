using eft_app_guide.Models.BTRs.Config;
using eft_app_guide.Models.Maps;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.BTRs
{
    [EntityTypeConfiguration(typeof(BTRConfig))]
    public class BTR
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int MapId { get; set; }
        #endregion

        [Required] public string Location { get; set; }

        #region Relations
        public Map? Map { get; set; }
        public BTRDisplay? Display { get; set; }
        #endregion
    }
}

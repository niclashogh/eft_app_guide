using eft_app_guide.Models.Maps.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eft_app_guide._Persistence.Entities.Display.Maps
{
    public class MapDisplay
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int MapId { get; set; }
        #endregion

        [Required] public int Versoin { get; set; }

        #region Relations
        public Map? Map { get; set; }
        #endregion
    }
}

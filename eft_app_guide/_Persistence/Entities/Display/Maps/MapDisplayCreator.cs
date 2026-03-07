using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eft_app_guide._Persistence.Entities.Display.Maps
{
    public class MapDisplayCreator
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int MapDisplayId { get; set; }
        #endregion

        [Required] public string Name { get; set; }
        public string? Link { get; set; }

        #region Relations
        // List<MapDisplay>
        #endregion
    }
}

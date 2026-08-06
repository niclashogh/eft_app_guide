using eft_app_guide._Objects.Enums;
using eft_app_guide._Persistence.Interface;
using eft_app_guide._Persistence.Entities.Display.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide._Persistence.Entities.Display
{
    [EntityTypeConfiguration(typeof(MarkerDisplayConfig))]
    public class MarkerDisplay : IPosition, ISize // TODO: Make a Marker class w/ Name & Desc with a MarkerDisplay. This current options is good for admin-placed but when a player wants to mark somthing they have to create everything per mapdisplay.
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public string MapDisplayId { get; set; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public string Description { get; set; }

        [Required] public double X { get; set; }
        [Required] public double Y { get; set; }
        [Required] public double Width { get; set; }
        [Required] public double Height { get; set; }
        [Required] public OutlineVariants Outline { get; set; }
        [Required] public string Icon { get; set; }

        #region Relations
        public MapDisplay? MapDisplay { get; set; }
        #endregion
    }
}

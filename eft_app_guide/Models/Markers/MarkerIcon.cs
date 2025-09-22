using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Markers
{
    public class MarkerIcon
    {
        #region Keys
        [Key] public int Id { get; set; }
        #endregion

        [Required] public string Icon { get; set; }

        #region Relations
        public List<Marker> Markers { get; set; } = new();
        #endregion
    }
}

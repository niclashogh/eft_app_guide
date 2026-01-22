using eft_app_guide.Models.ArmorPlates;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.ArmorVests
{
    public class ArmorVest
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public string ShortendName { get; set; }

        [Required] public double Weight { get; set; }
        [Required] public string GridSize { get; set; }

        #region Relations
        public List<ArmorVestEffect> Effects { get; set; } = [];
        public List<ArmorPlate> Plates { get; set; } = [];
        #endregion
    }
}

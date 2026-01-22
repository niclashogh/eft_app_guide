using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.ArmorPlates
{
    public class ArmorPlate
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        [Required] public byte Class { get; set; }
        [Required] public byte Durability { get; set; }

        #region Relations
        public List<ArmorPlateEffect> Effects { get; set; } = new();
        #endregion
    }
}

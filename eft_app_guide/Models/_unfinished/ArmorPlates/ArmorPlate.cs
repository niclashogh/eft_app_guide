using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models._unfinished.ArmorPlates
{
    public class ArmorPlate // TODO - FINISH
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        [Required] public byte Class { get; set; }
        [Required] public byte Durability { get; set; }

        #region Relations
        public List<ArmorPlateEffect> ArmorPlateEffects { get; set; } = [];
        #endregion
    }
}

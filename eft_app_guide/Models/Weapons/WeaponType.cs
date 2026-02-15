using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Weapons
{
    public class WeaponType // TODO - FINISH
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Type { get; set; }

        #region Relations
        public List<Weapon> Weapon { get; set; } = [];
        #endregion
    }
}

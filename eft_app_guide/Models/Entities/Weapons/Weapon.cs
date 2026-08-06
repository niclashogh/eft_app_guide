using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Weapons
{
    public class Weapon // TODO - FINISH
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int WeaponTypeId { get; set; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations
        public WeaponType? Type { get; set; }
        #endregion
    }
}

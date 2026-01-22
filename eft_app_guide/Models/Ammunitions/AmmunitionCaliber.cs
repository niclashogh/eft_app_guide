using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Ammunitions
{
    public class AmmunitionCaliber
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public string ShortendName { get; set; }

        #region Relations
        public List<Ammunition> Ammunitions { get; set; } = new();
        #endregion
    }
}

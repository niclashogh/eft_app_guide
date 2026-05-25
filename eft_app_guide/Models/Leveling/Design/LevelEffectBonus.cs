using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Leveling.Design
{
    public class LevelEffectBonus // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int LevelEffectId {  get; set; }
        #endregion

        [Required] public int Level { get; set; }
        [Required] public string Description { get; set; }

        #region Relations (Parents)
        public LevelEffect? LevelEffect { get; set; }
        #endregion
    }
}

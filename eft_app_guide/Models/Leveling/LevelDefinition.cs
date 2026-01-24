using eft_app_guide.Models.Characters;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Leveling
{
    public class LevelDefinition // LookupTable
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public byte Level { get; set; }
        [Required] public int MinExperiancePoint { get; set; }
        [Required] public int MaxExperiancePoint { get; set; }

        #region Relations
        public Character? Character { get; set; }
        #endregion
    }
}

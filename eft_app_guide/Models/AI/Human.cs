using eft_app_guide.Models.Factions.Design;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.AI
{
    public class Human
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public Faction Faction { get; set; }

        [Required] public int HeadHP { get; set; }
        [Required] public int ThoraxHP { get; set; }
        [Required] public int StomachHP { get; set; }
        [Required] public int LeftArmHP { get; set; }
        [Required] public int RightArmHP { get; set; }
        [Required] public int LeftLegHP { get; set; }
        [Required] public int RightLegHP { get; set; }

        #region Relations
        // Maps (many to many + TimeCondition, etc.) + Companions (many to many) + Equipement?
        #endregion
    }
}

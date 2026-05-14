using eft_app_guide.Models.Factions.Design;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.AI
{
    public class Human // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public Faction Faction { get; set; }

        [Required] public HumanLimb Head { get; set; }
        [Required] public HumanLimb Thorax { get; set; }
        [Required] public HumanLimb Stomach { get; set; }
        [Required] public HumanLimb LeftArm { get; set; }
        [Required] public HumanLimb RightArm { get; set; }
        [Required] public HumanLimb LeftLeg { get; set; }
        [Required] public HumanLimb RightLeg { get; set; }

        #region Relations
        // Maps (many to many + TimeCondition, etc.) + Companions (many to many) + Equipement?
        #endregion
    }
}

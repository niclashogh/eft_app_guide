using eft_app_guide._Persistence.Objects;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Workstations.Design
{
    /// <summary><b>ChildEntity</b> and <b>AggregativeEntity</b>
    /// Relations:<code>
    /// PARENTS:
    /// Workstation
    /// 
    /// JUNCTIONS:
    /// WorkstationLevelCrafting
    /// WorkstationLevelEffect
    /// 
    /// ASSOCIATIONS:
    /// CharacterWorkstationProgress
    /// </code></summary>

    public class WorkstationLevel // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int WorkstationId { get; set; }
        #endregion

        [Required] public int Level { get; set; }

        #region Relations (Parents)
        public Workstation? Workstation { get; set; }
        #endregion

        #region Relations (Children)
        //public JunctionList<StationLevelCrafting> StationLevelCraftings { get; set; } = [];
        //public JunctionList<StationLevelEffect> StationLevelEffects { get; set; } = [];

        //public AssociationList<CharacterStationLevelProgress> CharacterStationLevelProgressions { get; set; } = [];
        #endregion
    }
}

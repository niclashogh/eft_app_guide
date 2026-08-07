using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Workstations.Design
{
    public class WorkstationLevel // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int WorkstationId { get; set; }
        #endregion

        [Required] public int Level { get; set; }

        #region Relations
        public Workstation? Workstation { get; set; }
        //public JunctionList<StationLevelCrafting> StationLevelCraftings { get; set; } = [];
        //public JunctionList<StationLevelEffect> StationLevelEffects { get; set; } = [];

        //public AssociationList<CharacterStationLevelProgress> CharacterStationLevelProgressions { get; set; } = [];
        #endregion
    }
}

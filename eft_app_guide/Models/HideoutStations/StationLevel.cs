using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.HideoutStations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.HideoutStations
{
    /// <summary> DefinitionEntity </summary>
    [EntityTypeConfiguration(typeof(StationLevelConfig))]
    public class StationLevel
    {
        #region Keys
        [Key] public int Id { get; set; }
        [Required] public int StationId { get; set; }
        #endregion

        [Required] public int Level {  get; set; }

        #region Relations
        public Station? Station { get; set; }

        public JunctionList<StationLevelCrafting> StationLevelCraftings { get; set; } = [];
        #endregion
    }
}

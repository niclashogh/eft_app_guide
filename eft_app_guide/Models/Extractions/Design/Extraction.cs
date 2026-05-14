using eft_app_guide._Persistence.Entities.Display.State;
using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Extractions.Config;
using eft_app_guide.Models.Maps.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Extractions.Design
{
    /// <summary> AggregativeEntity (ExtractionRequirement + ExtractionFaction + ExtractionDisplay) </summary>
    [EntityTypeConfiguration(typeof(ExtractionConfig))]
    public class Extraction
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int MapId { get; set; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public bool IsSingleUse { get; set; }
        [Required] public bool IsRandom { get; set; }

        #region Relations (Parents)
        public Map? Map { get; set; }
        #endregion

        #region Relations (Children)
        public List<ExtractionRequirement> ExtractionRequirements { get; set; } = [];
        public JunctionList<ExtractionFaction> ExtractionFactions { get; set; } = [];
        public AssociationList<ExtractionDisplay> ExtractionDisplays { get; set; } = [];
        #endregion
    }
}

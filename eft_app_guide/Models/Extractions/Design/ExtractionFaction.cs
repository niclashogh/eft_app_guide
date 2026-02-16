using eft_app_guide.Models.Extractions.Config;
using eft_app_guide.Models.Factions.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Extractions.Design
{
    /// <summary> JunctionEntity (ExtractonId + FactionId) </summary>
    [EntityTypeConfiguration(typeof(ExtractionFactionConfig))]
    public class ExtractionFaction
    {
        #region Keys (CompositeKeys)
        [Required] public int ExtractionId { get; set; }
        [Required] public int FactionId { get; set; }
        #endregion

        #region Relations (Parents)
        public Extraction? Extraction { get; set; }
        public Faction? Faction { get; set; }
        #endregion
    }
}

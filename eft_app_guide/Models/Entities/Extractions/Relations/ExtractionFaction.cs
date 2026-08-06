using eft_app_guide.Models.Entities.Extractions.Design;
using eft_app_guide.Models.Entities.Extractions.Relations.Config;
using eft_app_guide.Models.Entities.Factions.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Extractions.Relations
{
    /// <summary><b>JunctionEntity</b>
    /// Between:<code>
    /// ExtractonId
    /// FactionId
    /// </code></summary>
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

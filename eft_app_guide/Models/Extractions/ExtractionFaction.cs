using eft_app_guide.Models.Factions;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Extractions
{
    public class ExtractionFaction // JunctionTable
    {
        #region Keys (CompositeKeys)
        [Required] public int ExtractionId { get; set; }
        [Required] public int FactionId { get; set; }
        #endregion

        #region Relations
        public Extraction? Extraction { get; set; }
        public Faction? Faction { get; set; }
        #endregion
    }
}

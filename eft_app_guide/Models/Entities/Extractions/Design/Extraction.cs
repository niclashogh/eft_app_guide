using eft_app_guide.Models.Entities.Extractions.Design.Config;
using eft_app_guide.Models.Entities.Maps.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Extractions.Design
{
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

        #region Relations
        public Map? Map { get; set; }
        #endregion
    }
}

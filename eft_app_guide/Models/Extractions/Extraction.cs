using eft_app_guide.Models.Extractions.Config;
using eft_app_guide.Models.Interfaces;
using eft_app_guide.Models.Maps;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Extractions
{
    [EntityTypeConfiguration(typeof(ExtractionConfig))]
    public class Extraction : BasePosition, IPosition
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int MapId { get; set; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public bool IsRandom { get; set; }

        #region Relations
        public Map? Map { get; set; }

        public List<ExtractionRequirement> Requirements { get; set; } = new(); 
        #endregion
    }
}

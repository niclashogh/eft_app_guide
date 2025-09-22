using eft_app_guide.Models.Entities;
using eft_app_guide.Models.Extractions.Config;
using eft_app_guide.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Extractions
{
    [EntityTypeConfiguration(typeof(ExtractionConfig))]
    public class Extraction : BasePosition, IPosition
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public string MapName { get; set; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations
        public Map? Map { get; set; }

        public List<ExtractionRequirement> ExtractionRequirements { get; set; } = new(); 
        #endregion
    }
}

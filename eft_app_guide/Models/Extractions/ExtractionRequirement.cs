using eft_app_guide.Models.Extractions.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Extractions
{
    /// <summary> DefinitionEntity </summary>
    [EntityTypeConfiguration(typeof(ExtractionRequirementConfig))]
    public class ExtractionRequirement
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int ExtractionId { get; set; }
        #endregion

        [Required] public string Description { get; set; }

        #region Relations
        public Extraction? Extraction { get; set; }
        #endregion
    }
}

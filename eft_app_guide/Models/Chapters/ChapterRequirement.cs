using eft_app_guide.Models._Interfaces;
using eft_app_guide.Models.Chapters.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Chapters
{
    [EntityTypeConfiguration(typeof(ChaperRequirementConfig))]
    public class ChapterRequirement : IRequirement
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int ChapterId { get; set; }
        #endregion

        [Required] public string Description { get; set; }

        #region Relatations
        public Chapter? Chapter { get; set; }
        #endregion
    }
}

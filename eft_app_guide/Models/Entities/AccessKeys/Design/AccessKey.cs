using eft_app_guide.Models.Entities.AccessKeys.Design.Config;
using eft_app_guide.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.AccessKeys.Design
{
    /// <summary><b>DefintionEntity</b></summary>
    [EntityTypeConfiguration(typeof(AccessKeyConfig))]
    public class AccessKey : IGraphTarget
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public string ShortendName { get; set; }

        [Required] public bool LimitedUse { get; set; }
        [Required] public int MaxUses { get; set; }
    }
}

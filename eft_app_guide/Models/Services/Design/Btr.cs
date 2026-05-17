using eft_app_guide._Persistence.Entities.Display;
using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Maps.Design;
using eft_app_guide.Models.Services.Design.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Services.Design
{
    /// <summary><b>DefintionEntity</b></summary>
    [EntityTypeConfiguration(typeof(BtrConfig))]
    public class Btr
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int MapId { get; set; }
        #endregion

        #region Relations (Parents)
        public Map? Map { get; set; }
        #endregion

        #region Relations (Children)
        public AssociationList<BtrDisplay> BtrDisplays { get; set; } = [];
        #endregion
    }
}

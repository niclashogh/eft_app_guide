using eft_app_guide._Persistence.Interface;
using eft_app_guide._Persistence.Entities.Display.Config;
using eft_app_guide.Models.Entities.Services.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide._Persistence.Entities.Display
{
    /// <summary><b>AssociationEntity</b></summary>
    [EntityTypeConfiguration(typeof(BtrDisplayConfig))]
    public class BtrDisplay : IPosition
    {
        #region Keys (CompositeKeys)
        [Required] public int BtrId { get; set; }
        [Required] public int MapDisplayId { get; set; }
        #endregion

        [Required] public double X { get; set; }
        [Required] public double Y { get; set; }

        #region Relations (Parents)
        public Btr? Btr { get; set; }
        public MapDisplay? MapDisplay { get; set; }
        #endregion
    }
}

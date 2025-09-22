using eft_app_guide.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities
{
    public class BTR : BasePosition, IPosition
    {
        #region Keys
        [Key] public int Id { get; set; }
        [Required] public string MapName { get; set; }
        #endregion

        [Required] public string Location { get; set; }

        #region Relations
        public Map? Map { get; set; }
        #endregion
    }
}

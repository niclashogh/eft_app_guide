using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Hideout
{
    public class StationLevel
    {
        #region Keys
        [Key] public int Id { get; set; }
        [Required] public int StationId { get; set; }
        #endregion

        [Required] public int Level {  get; set; }

        #region Relations
        public Station? Station { get; set; }
        #endregion
    }
}

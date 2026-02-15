using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.HideoutStations
{
    public class StationLevelEffect // MISSING
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int StationLevelDifinitionId { get; set; }
        #endregion

        // ...
    }
}

using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Hideout
{
    public class Station
    {
        #region Keys
        [Key] public int Id { get; set; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations
        public List<StationLevel> Levels { get; set; } = new();
        public List<StationItem> Items { get; set; } = new();
        #endregion
    }
}

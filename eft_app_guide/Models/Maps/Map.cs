using eft_app_guide.Models.AccessKeys;
using eft_app_guide.Models.Extractions;
using eft_app_guide.Models.Maps.Enums;
using eft_app_guide.Models.Markers;
using eft_app_guide.Models.Quests;
using eft_app_guide.Models.BTRs;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Maps
{
    public class Map
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public MapAccess Access { get; set; }

        #region Relatations
        public List<AccessKey> AccessKeys { get; set; } = new();
        public List<Extraction> Extractions { get; set; } = new();
        public List<QuestTask> QuestTasks { get; set; } = new();
        public List<Marker> Markers { get; set; } = new();
        public List<BTR> BTRs { get; set; } = new();
        #endregion
    }
}

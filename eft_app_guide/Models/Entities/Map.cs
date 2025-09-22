using eft_app_guide.Models.AccessKeys;
using eft_app_guide.Models.Extractions;
using eft_app_guide.Models.Markers;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities
{
    public class Map
    {
        [Key] public string Name { get; set; }

        #region Relatations
        public List<AccessKey> AccessKeys { get; set; } = new();
        public List<Extraction> Extractions { get; set; } = new();
        public List<Marker> Markers { get; set; } = new();
        public List<BTR> BTRs { get; set; } = new();
        #endregion
    }
}

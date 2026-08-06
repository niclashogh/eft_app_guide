using eft_app_guide._Objects.Types;
using eft_app_guide._Persistence.Entities.Display.Config;
using eft_app_guide.Models.Entities.Maps.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide._Persistence.Entities.Display
{
    [EntityTypeConfiguration(typeof(MapDisplayConfig))]
    public class MapDisplay // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int MapId { get; set; }
        #endregion

        [Required] public int Version { get; set; }
        public object? Credits { get; set; }

        #region Relations (Parents)
        public Map? Map { get; set; }
        #endregion

        #region Relations (Children)
        public AssociationList<BtrDisplay> BtrDisplays { get; set; } = [];
        public AssociationList<ChapterTaskDisplay> ChapterTaskDisplays { get; set; } = [];
        public AssociationList<ExtractionDisplay> ExtractionDisplays { get; set; } = [];
        public AssociationList<LocationDisplay> LocationDisplays { get; set; } = [];
        public AssociationList<MarkerDisplay> MarkerDisplays { get; set; } = [];
        public AssociationList<QuestTaskDisplay> QuestTaskDisplays { get; set; } = [];
        #endregion
    }
}

using eft_app_guide.Models.Extractions;
using eft_app_guide.Models.Markers;
using eft_app_guide.Models.Quests;
using System.ComponentModel.DataAnnotations;
using eft_app_guide.Models.Locations;
using Microsoft.EntityFrameworkCore;
using eft_app_guide.Models.Maps.Config;
using eft_app_guide.Models.Chapters;
using eft_app_guide.Models.Characters;
using eft_app_guide.Models.Services;
using eft_app_guide._Persistence.Objects;

namespace eft_app_guide.Models.Maps
{
    /// <summary> AggregativeEntity (Location + Extraction + Btr + Marker + ChapterTaskMap + QuestTaskMap + CharacterMapAccess) </summary>
    [EntityTypeConfiguration(typeof(MapConfig))]
    public class Map
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relatations (Children)
        public List<Location> Locations { get; set; } = [];
        public List<Extraction> Extractions { get; set; } = [];
        public List<Btr> Btrs { get; set; } = [];
        public List<Marker> Markers { get; set; } = [];

        public JunctionList<ChapterTaskMap> ChapterTaskMaps { get; set; } = [];
        public JunctionList<QuestTaskMap> QuestTasksMaps { get; set; } = [];
        public AssociationList<CharacterMapAccess> CharacterMapAccesses { get; set; } = [];
        #endregion
    }
}

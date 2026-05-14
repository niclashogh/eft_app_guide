using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using eft_app_guide.Models.Maps.Config;
using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Characters.State;
using eft_app_guide.Models.Chapters.Design;
using eft_app_guide.Models.Extractions.Design;
using eft_app_guide.Models.Locations.Design;
using eft_app_guide.Models.Quests.Design;
using eft_app_guide.Models.Services.Design;
using eft_app_guide._Persistence.Entities.Display.State;

namespace eft_app_guide.Models.Maps.Design
{
    /// <summary> AggregativeEntity (MapDisplay + Location + Extraction + Btr + ChapterTaskMap + QuestTaskMap + CharacterMapAccess) </summary>
    [EntityTypeConfiguration(typeof(MapConfig))]
    public class Map
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relatations (Children)
        public List<MapDisplay> MapDisplays { get; set; } = [];
        public List<Location> Locations { get; set; } = [];
        public List<Extraction> Extractions { get; set; } = [];
        public List<Btr> Btrs { get; set; } = [];

        public JunctionList<ChapterTaskMap> ChapterTaskMaps { get; set; } = [];
        public JunctionList<QuestTaskMap> QuestTasksMaps { get; set; } = [];

        public AssociationList<CharacterMapAccess> CharacterMapAccesses { get; set; } = [];
        #endregion
    }
}

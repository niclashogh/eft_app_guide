using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using eft_app_guide._Objects.Types;
using eft_app_guide.Models.Entities.Extractions.Design;
using eft_app_guide.Models.Entities.Characters.State;
using eft_app_guide.Models.Entities.Quests.Relations;
using eft_app_guide.Models.Entities.Chapters.Relations;
using eft_app_guide.Models.Entities.Locations.Design;
using eft_app_guide.Models.Entities.Services.Design;
using eft_app_guide.Models.Entities.Raids.Design;
using eft_app_guide.Models.Entities.Maps.Design.Config;
using eft_app_guide.Models.Enums;
using eft_app_guide.Models.Entities.Actors.Relations;
using eft_app_guide._Persistence.Entities.Display;

namespace eft_app_guide.Models.Entities.Maps.Design
{
    /// <summary><b>AggregativeEntity</b></summary>
    [EntityTypeConfiguration(typeof(MapConfig))]
    public class Map
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public MapAccessType MapAccessType { get; set; }
        [Required] public bool IsVirtual { get; set; }

        #region Relatations (Children)
        public List<Raid> Raids { get; set; } = [];
        public List<MapPackage> MapDisplays { get; set; } = [];
        public List<Location> Locations { get; set; } = [];
        public List<Extraction> Extractions { get; set; } = [];
        public List<Btr> Btrs { get; set; } = [];

        public JunctionList<ChapterTaskMap> ChapterTaskMaps { get; set; } = [];
        public JunctionList<QuestTaskMap> QuestTasksMaps { get; set; } = [];
        public JunctionList<HumanMap> HumanMaps {  get; set; } = [];

        public AssociationList<CharacterMapAccess> CharacterMapAccesses { get; set; } = [];
        #endregion
    }
}

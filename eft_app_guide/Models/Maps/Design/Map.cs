using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using eft_app_guide.Models.Characters.State;
using eft_app_guide.Models.Extractions.Design;
using eft_app_guide.Models.Locations.Design;
using eft_app_guide.Models.Services.Design;
using eft_app_guide.Models.Raids.Design;
using eft_app_guide.Models.Chapters.Relations;
using eft_app_guide.Models.Quests.Relations;
using eft_app_guide.Models.AI.Relations;
using eft_app_guide._Persistence.Entities.Display;
using eft_app_guide.Models.Maps.Design.Config;
using eft_app_guide._Objects.Types;

namespace eft_app_guide.Models.Maps.Design
{
    /// <summary><b>DefinitionEntity</b> and <b>AggregativeEntity</b>
    /// Relations:<code>
    /// CHILDREN:
    /// Raid
    /// MapDisplay
    /// Location
    /// Extraction
    /// Btr
    /// 
    /// JUNCTION:
    /// ChapterTaskMap
    /// QuestTaskMap
    /// 
    /// ASSOCIATIONS:
    /// CharacterMapAccess
    /// </code></summary>
    [EntityTypeConfiguration(typeof(MapConfig))]
    public class Map
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relatations (Children)
        public List<Raid> Raids { get; set; } = [];
        public List<MapDisplay> MapDisplays { get; set; } = [];
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

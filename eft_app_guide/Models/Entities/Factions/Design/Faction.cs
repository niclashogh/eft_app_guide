using eft_app_guide._Objects.Types;
using eft_app_guide.Models.Entities.Actors.Design;
using eft_app_guide.Models.Entities.Characters.State;
using eft_app_guide.Models.Entities.Extractions.Relations;
using eft_app_guide.Models.Entities.Factions.Design.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Factions.Design
{
    /// <summary><b>DefinitionEntity</b>
    /// Containing:<code>
    /// USEC - United Security
    /// BEAR - Battle Encounter Assault Regiment
    /// SCAV - Scavengers
    /// SCAV Raiders
    /// Rouges - Former USEC
    /// RUAF - The Russian Armed Forces
    /// Black Division
    /// Cultists
    /// ...
    /// </code></summary>
    [EntityTypeConfiguration(typeof(FactionConfig))]
    public class Faction
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public string Description { get; set; }

        #region Relations (Children)
        public List<Character> Characters { get; set; } = [];
        public List<Human> Humans { get; set; } = [];

        public JunctionList<ExtractionFaction> ExtractionFactions { get; set; } = [];
        #endregion
    }
}

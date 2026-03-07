using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Characters.State;
using eft_app_guide.Models.Extractions.Design;
using eft_app_guide.Models.Factions.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Factions.Design
{
    /// <summary> DefinitionEntity (
    /// USEC - United Security,
    /// BEAR - Battle Encounter Assault Regiment,
    /// SCAV - Scavengers,
    /// SCAV Raiders,
    /// Rouges - Former USEC,
    /// RUAF - The Russian Armed Forces,
    /// Black Division
    /// Cultists
    /// ) </summary>
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
        public JunctionList<ExtractionFaction> ExtractionFactions { get; set; } = [];
        #endregion
    }
}

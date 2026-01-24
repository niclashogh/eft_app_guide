using eft_app_guide.Models.Characters;
using eft_app_guide.Models.Extractions;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Factions
{
    public class Faction
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations
        public List<Character> Characters { get; set; } = [];
        public List<ExtractionFaction> ExtractionRelations { get; set; } = [];
        #endregion
    }
}

using eft_app_guide.Models.Entities.Actors.Design;
using eft_app_guide.Models.Entities.Characters.State;
using eft_app_guide.Models.Entities.Factions.Design.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Factions.Design
{
    [EntityTypeConfiguration(typeof(FactionConfig))]
    public class Faction
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public string Description { get; set; }

        #region Relations
        public List<Character> Characters { get; set; } = [];
        public List<Human> Humans { get; set; } = [];
        #endregion
    }
}

using eft_app_guide._Objects.Types;
using eft_app_guide.Models.Entities.Actors.Design.Config;
using eft_app_guide.Models.Entities.Factions.Design;
using eft_app_guide.Models.Entities.Actors.Relations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Actors.Design
{
    [EntityTypeConfiguration(typeof(HumanConfig))]
    public class Human // TODO - Add Equipment?
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int FactionId { get; set; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations
        public Faction? Faction { get; set; }
        public List<HumanLimb> HumanLimbs { get; set; } = [];
        public JunctionList<HumanGroup> HumanGroups { get; set; } = [];
        public AssociationList<HumanMap> HumanMaps { get; set; } = [];
        #endregion
    }
}

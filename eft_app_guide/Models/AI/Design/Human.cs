using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.AI.Design.Config;
using eft_app_guide.Models.AI.Relations;
using eft_app_guide.Models.Factions.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.AI.Design
{
    /// <summary><b>AggregativeEntity</b>
    /// Relations:<code>
    /// PARENTS:
    /// Faction
    /// 
    /// CHILDREN:
    /// HumanLimb
    /// 
    /// JUNCTIONS:
    /// HumanGroup
    /// 
    /// ASSOCIATIONS:
    /// HumanMap
    /// </code></summary>
    [EntityTypeConfiguration(typeof(HumanConfig))]
    public class Human
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int FactionId { get; set; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations (Parents)
        public Faction? Faction { get; set; }
        #endregion

        #region Relations (Children)
        public List<HumanLimb> HumanLimbs { get; set; } = [];

        public JunctionList<HumanGroup> HumanGroups { get; set; } = [];

        public AssociationList<HumanMap> HumanMaps { get; set; } = [];
        #endregion

        // Maps (many to many + TimeCondition, etc.) + Companions (many to many) + Equipement?
    }
}

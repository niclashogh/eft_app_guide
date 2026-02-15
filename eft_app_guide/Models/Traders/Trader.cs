using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Quests;
using eft_app_guide.Models.Traders.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Traders
{
    /// <summary> AggregativeEntity (TraderLevel + TraderItem) </summary>
    [EntityTypeConfiguration(typeof(TraderConfig))]
    public class Trader // MISSING
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public double Reputation { get; set; } // Move to CharacterTraderReputation w/ bool HasAchieved

        #region Relations
        public List<Quest> Quests { get; set; } = [];
        public List<TraderLevel> TraderLevels { get; set; } = [];
        public AssociationList<TraderItem> TraderItems { get; set; } = [];
        #endregion
    }
}

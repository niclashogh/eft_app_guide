using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Characters.State;
using eft_app_guide.Models.Maps.Design;
using eft_app_guide.Models.Raids.Design.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Raids.Design
{
    /// <summary><b>ChildEntity of Map</b></summary>
    [EntityTypeConfiguration(typeof(RaidConfig))]
    public class Raid
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int MapId { get; set; }
        #endregion

        [Required] public int DurationInMinutes { get; set; }
        [Required] public byte MinimumPlayerCount { get; set; }
        [Required] public byte MaximumPlayerCount { get; set; }


        #region Relations (Parents)
        public Map? Map { get; set; }
        #endregion

        #region Relations (Children)
        public AssociationList<CharacterRaidStatistic> CharacterRaidStatistics { get; set; } = [];
        #endregion
    }
}

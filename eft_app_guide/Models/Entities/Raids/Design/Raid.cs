using eft_app_guide._Objects.Types;
using eft_app_guide.Models.Entities.Characters.State;
using eft_app_guide.Models.Entities.Maps.Design;
using eft_app_guide.Models.Entities.Raids.Design.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Raids.Design
{
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


        #region Relations
        public Map? Map { get; set; }
        public AssociationList<CharacterRaidStatistic> CharacterRaidStatistics { get; set; } = [];
        #endregion
    }
}

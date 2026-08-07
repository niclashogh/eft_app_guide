using eft_app_guide.Models.Entities.Characters.State.Config;
using eft_app_guide.Models.Entities.Raids.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.Characters.State
{
    /// <summary><b>AssociationEntity</b></summary>
    [EntityTypeConfiguration(typeof(CharacterRaidStatisticConfig))]
    public class CharacterRaidStatistic
    {
        #region Keys (CompositeKeys)
        [Required] public int CharacterId { get; set; }
        [Required] public int RaidId { get; set; }
        #endregion

        [Required] public int TotalRuns { get; set; }
        [Required] public int Survived { get; set; }

        /// <summary> Left or lost connection to raid </summary>
        [Required] public int Disconnected { get; set; }
        /// <summary> Extracted to early </summary>
        [Required] public int RunThroughs { get; set; }
        /// <summary> Killed in action </summary>
        [Required] public int KIA { get; set; }
        /// <summary> Missing in aciton </summary>
        [Required] public int MIA { get; set; }

        #region Relations
        public Character? Character { get; set; }
        public Raid? Raid { get; set; }
        #endregion
    }
}

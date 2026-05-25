using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.HideoutStations._temp;
using eft_app_guide.Models.HideoutStations.Design.Config;
using eft_app_guide.Models.HideoutStations.Relations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.HideoutStations.Design
{
    /// <summary><b>DefinitionEntity</b>
    /// Containing:<code>
    /// Fuel Consumption
    /// Energy Regeneration Rate
    /// Additional Raid EXP
    /// Major/Minor Skill EXP Boost
    /// ...
    /// </code></summary>
    [EntityTypeConfiguration(typeof(StationEffectConfig))]
    public class StationEffect // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int StationEffectValueTypeId { get; set; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations (Parents)
        public StationEffectValueType? StationEffectValueType { get; set; }
        #endregion

        #region Relations (Children)
        public StationEffectCharacterMajorSkill? StationEffectCharacterMajorSkill { get; set; }
        public AssociationList<StationLevelEffect> StationLevelEffects { get; set; } = [];
        #endregion
    }
}

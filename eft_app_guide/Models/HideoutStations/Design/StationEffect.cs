using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models._Enums;
using eft_app_guide.Models.HideoutStations.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.HideoutStations.Design
{
    /// <summary> DefinitionEntity (Fuel Consumption, Energy Regeneration Rate, Additional Raid EXP, Major/Minor Skill EXP Boost, etc.) </summary>
    [EntityTypeConfiguration(typeof(StationEffectConfig))]
    public class StationEffect
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public StationEffectValueTypes ValueType { get; set; }

        #region Relations (Children)
        public StationEffectCharacterMajorSkill? StationEffectCharacterMajorSkill { get; set; }

        public AssociationList<StationLevelEffect> StationLevelEffects { get; set; } = [];
        #endregion
    }
}

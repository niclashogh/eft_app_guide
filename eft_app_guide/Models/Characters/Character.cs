using eft_app_guide._Persistence.Objects;
using eft_app_guide.Models.Accounts;
using eft_app_guide.Models.Characters.Config;
using eft_app_guide.Models.Factions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Characters
{
    /// <summary> AggregativeEntity (Faction + CharacterMapAccess + CharacterQuestProgress + CharacterSkillProgress + CharacterStationProgress) </summary>
    [EntityTypeConfiguration(typeof(CharacterConfig))]
    public class Character
    {
        #region Keys (CompositeKeys)
        [Required] public int AccountId { get; set; }
        [Required] public int FactionId { get; set; }
        #endregion

        [Required] public int ExperiencePoint { get; set; }

        #region Relations
        public Account? Account { get; set; }
        public Faction? Faction { get; set; }

        public AssociationList<CharacterMapAccess> CharacterMapAccesses { get; set; } = [];
        public AssociationList<CharacterQuestProgress> CharacterQuestProgressions { get; set; } = [];
        public AssociationList<CharacterSkillProgress> CharacterSkillProgressions { get; set; } = [];
        public AssociationList<CharacterStationProgress> CharacterStationProgressions { get; set; } = [];
        #endregion
    }
}

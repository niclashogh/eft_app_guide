using eft_app_guide._Objects.Types;
using eft_app_guide.Models._Enums;
using eft_app_guide.Models._unfinished.HIdeouts.Design.Config;
using eft_app_guide.Models.Entities.Workstations.Design;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models._unfinished.HIdeouts.Design
{

    [EntityTypeConfiguration(typeof(HideoutConfig))]
    public class Hideout // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        #region Relations (Children)
        public List<Workstation> Workstations { get; set; } = [];
        public JunctionList<HideoutCharacter> HideoutCharacters { get; set; } = [];
        #endregion
    }
}

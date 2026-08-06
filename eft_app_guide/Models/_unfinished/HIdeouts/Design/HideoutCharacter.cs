using eft_app_guide.Models.Entities.Characters.State;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models._unfinished.HIdeouts.Design
{
    public class HideoutCharacter // TODO
    {
        #region Keys (CompositeKeys)
        [Required] public int HideoutId {  get; set; }
        [Required] public int CharacterId { get; set; }
        #endregion

        #region Relations (Parents)
        public Hideout? Hideout { get; set; }
        public Character? Character { get; set; }
        #endregion
    }
}

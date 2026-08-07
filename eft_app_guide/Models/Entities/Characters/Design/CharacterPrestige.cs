using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eft_app_guide.Models.Entities.Characters.Design
{
    public class CharacterPrestige // TODO
    {
        // https://escapefromtarkov.fandom.com/wiki/Prestige

        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public int Level { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eft_app_guide.Models.Entities.Workstations.Design
{
    public class Workstation // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }

        #region Relations
        public List<WorkstationLevel> WorkstationLevels { get; set; } = [];
        #endregion
    }
}

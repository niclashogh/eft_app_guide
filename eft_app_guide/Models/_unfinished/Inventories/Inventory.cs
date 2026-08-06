using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eft_app_guide.Models._unfinished.Inventories
{
    public class Inventory // TODO
    {
        #region Keys
        [Key] public int Id {  get; init; }
        #endregion

        // Box/Object Name
        // Object Size
        // InventorySize

        // Containers as Item w/ unbox and items within
        // Containers as Item w/ inventory size x,y
    }
}

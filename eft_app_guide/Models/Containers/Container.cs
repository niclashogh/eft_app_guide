using eft_app_guide.Models.Containers.Enums;
using eft_app_guide.Models.Locations;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Containers
{
    public class Container
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int LocationId { get; set; }
        #endregion

        [Required] public ContainerTypes Type { get; set; }

        #region Relations
        public Location? Location { get; set; }
        #endregion
    }
}

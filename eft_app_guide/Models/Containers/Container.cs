using eft_app_guide.Models.Containers.Config;
using eft_app_guide.Models.Containers.Enums;
using eft_app_guide.Models.Locations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Containers
{
    [EntityTypeConfiguration(typeof(ContainerConfig))]
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

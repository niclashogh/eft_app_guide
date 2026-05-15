using eft_app_guide.Models.Containers.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Containers.Design
{
    /// <summary><b>DefintionEntity</b>
    /// Containing:<code>
    /// Jackets
    /// Bags
    /// Drawers
    /// ...
    /// </code></summary>
    [EntityTypeConfiguration(typeof(ContainerTypeConfig))]
    public class ContainerType
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public string ShortendName { get; set; }

        #region Relations (Children)
        public List<Container> Containers { get; set; } = [];
        #endregion
    }
}

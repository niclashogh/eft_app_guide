using System.ComponentModel.DataAnnotations;
using eft_app_guide.Models.Enums.ReferenceTypes;

namespace eft_app_guide.Models.Graphs
{
    /// <summary><b>GraphEntity</b></summary>
    public class Group
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public GroupType GroupType { get; set; }
        #endregion

        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}

using eft_app_guide.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Graphs
{
    /// <summary><b>GraphEntity</b></summary>
    public abstract class BaseGraph
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string SourceType { get; set; }
        [Required] public int SourceKey { get; set; }

        [Required] public string TargetType { get; set; }
        [Required] public int TargetKey { get; set; }

        #region Relations
        public IGraphSource? Source { get; set; }
        public IGraphTarget? Target { get; set; }
        #endregion
    }
}

using eft_app_guide.Models.Entities.Traders.Design;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.PatronEntities.Design
{
    /// <summary><b>ChildEntity</b> and <b>AggregativeEntity</b>
    /// Relations:<code>
    /// PARENTS:
    /// Patron
    /// 
    /// CHILDREN:
    /// Trade
    /// 
    /// </code></summary>
    public class PatronLevel
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int PatronId { get; set; }
        #endregion

        [Required] public int Level { get; set; }

        #region Relations (Parents)
        public Patron? Patron { get; set; }
        #endregion

        #region Relations (Children)
        public List<Trade> Trades { get; set; } = [];
        #endregion
    }
}

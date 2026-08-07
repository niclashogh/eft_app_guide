using eft_app_guide.Models._unfinished.Traders.Design;
using eft_app_guide.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Entities.PatronEntities.Design
{
    public class PatronLevel : IGraphSource // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int PatronId { get; set; }
        #endregion

        [Required] public int Level { get; set; }

        #region Relations
        public Patron? Patron { get; set; }
        public List<Trade> Trades { get; set; } = [];
        #endregion
    }
}

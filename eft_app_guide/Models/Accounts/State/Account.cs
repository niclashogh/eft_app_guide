using eft_app_guide.Models.Accounts.Design;
using eft_app_guide.Models.Accounts.State.Config;
using eft_app_guide.Models.Characters.State;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Accounts.State
{
    /// <summary><b>AggregativeEntity</b>
    /// Relations:<code>
    /// PARENTS:
    /// AccountEdition
    /// 
    /// CHILDREN:
    /// Character
    /// </code></summary>
    [EntityTypeConfiguration(typeof(AccountConfig))]
    public class Account
    {
        #region Keys
        [Key] public int Id { get; init; }
        [Required] public int AccountEditionId { get; set; }
        #endregion

        [Required] public string Name { get; set; }
        [Required] public DateTime WipeDate { get; set; }

        #region Relations (Parents)
        public AccountEdition? AccountEdition { get; set; }
        #endregion

        #region Relations (Children)
        public List<Character> Characters { get; set; } = [];
        #endregion
    }
}

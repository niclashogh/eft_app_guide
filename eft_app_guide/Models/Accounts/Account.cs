using eft_app_guide.Models.Accounts.Config;
using eft_app_guide.Models.Characters;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Accounts
{
    /// <summary> AggregativeEntity (AccountEdition + Character) </summary>
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
        public Character? Character { get; set; }
        #endregion
    }
}

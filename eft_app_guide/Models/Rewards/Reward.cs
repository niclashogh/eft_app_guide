using eft_app_guide.Models.Rewards.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eft_app_guide.Models.Rewards
{
    public class Reward
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public RewardTypes Type { get; set; }
        [Required] public 
    }
}

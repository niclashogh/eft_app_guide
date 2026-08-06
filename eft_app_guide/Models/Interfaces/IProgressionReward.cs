using eft_app_guide.Models.Graphs;

namespace eft_app_guide.Models.Interfaces
{
    public interface IProgressionReward
    {
        public int ProgressionRewardId { get; set; }

        public ProgressionReward? ProgressionReward { get; set; }
    }
}

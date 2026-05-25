using eft_app_guide._Persistence.Entities.TargetTypes;

namespace eft_app_guide.Models._Interfaces
{
    public interface ILevelProvider
    {
        public int LevelTargetTypeId { get; set; }

        public int TargetKey { get; set; }

        public LevelTargetType? LevelTargetType { get; set; }
    }
}

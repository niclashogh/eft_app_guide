using eft_app_guide._Persistence.Entities.Grouping;

namespace eft_app_guide.Models._Interfaces
{
    public interface IGroup
    {
        public int GroupId { get; set; }

        public Group? Group { get; set; }
    }
}

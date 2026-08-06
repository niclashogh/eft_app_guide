using eft_app_guide.Models.Graphs;

namespace eft_app_guide.Models.Interfaces
{
    public interface IGroup
    {
        public int GroupId { get; set; }

        public Group? Group { get; set; }
    }
}

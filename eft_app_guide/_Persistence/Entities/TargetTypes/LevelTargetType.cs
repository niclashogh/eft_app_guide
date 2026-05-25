using System.ComponentModel.DataAnnotations;

namespace eft_app_guide._Persistence.Entities.TargetTypes
{
    public class LevelTargetType // TODO
    {
        #region Keys
        [Key] public int Id { get; init; }
        #endregion

        [Required] public string Type {  get; set; }

        #region Relations (Children)

        #endregion
    }
}

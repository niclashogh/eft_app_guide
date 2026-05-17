using eft_app_guide.Models.Chapters.Design;
using eft_app_guide.Models.Characters.State.Config;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace eft_app_guide.Models.Characters.State
{
    /// <summary><b>AssociationEntity</b>
    /// Between:<code>
    /// CharacterId
    /// ChapterTaskId
    /// </code></summary>
    [EntityTypeConfiguration(typeof(CharacterChapterTaskProgressConfig))]
    public class CharacterChapterTaskProgress
    {
        #region Keys (CompositeKeys)
        [Required] public int CharacterId {  get; set; }
        [Required] public int ChapterTaskId {  get; set; }
        #endregion

        [Required] public bool IsCompleted {  get; set; }

        #region Relations (Parents)
        public Character? Character { get; set; }
        public ChapterTask? ChapterTask { get; set; }
        #endregion
    }
}

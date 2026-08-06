using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace eft_app_guide._Objects.ValueObjects.Converters
{
    public sealed class GameTimeConverter : ValueConverter<GameTime, int>
    {
        public GameTimeConverter() : base(gt => gt.TotalMinutes, i => new GameTime(i))
        {
        }
    }
}

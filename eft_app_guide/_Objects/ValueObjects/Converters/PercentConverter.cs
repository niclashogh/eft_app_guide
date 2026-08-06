using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace eft_app_guide._Objects.ValueObjects.Converters
{
    public sealed class PercentConverter : ValueConverter<Percent, double>
    {
        public PercentConverter() : base(p => p.Value, d => new Percent(d))
        {
        }
    }
}


namespace eft_app_guide.DataTransferObjects.ValueObjects
{
    public readonly struct Percent
    {
        public double Value { get; }
        public bool IsNegative { get; }

        public Percent(double value)
        {
            if (value < -100 || value > 100) throw new ArgumentOutOfRangeException(nameof(value), "Percent must be between -100 and 100.");
            if (value < 0) IsNegative = true;

            Value = value;
        }

        // Tells C# to automatically convert the struct to a double when needed & vice versa.
        // "double d = new Percent(0);"
        // "Percent p = 20;"

        public static implicit operator double(Percent percent) => percent.Value;
        public static implicit operator Percent(double value) => new(value);

        public override string ToString() => $"{Value}";
    }
}

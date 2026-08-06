namespace eft_app_guide._Objects.ValueObjects
{
    public readonly struct Percent
    {
        public double Value { get; }
        public bool IsNegative => Value < 0;

        public Percent(double value) => Value = value;

        // Tells C# to automatically convert the struct to a double when needed & vice versa.
        // "double d = new Percent(x);"
        // "Percent p = x;"

        public static implicit operator double(Percent percent) => percent.Value;
        public static implicit operator Percent(double value) => new(value);

        public override string ToString() => $"{Value:0.##}%";
    }
}

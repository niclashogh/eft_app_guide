namespace eft_app_guide._Objects.ValueObjects
{
    public readonly struct GameTime
    {
        public int TotalMinutes { get; }

        public int Hour => TotalMinutes / 60;
        public int Minute => TotalMinutes % 60;

        public GameTime(int totalMinutes)
        {
            if (totalMinutes < 0 || totalMinutes >= 24 * 60) throw new ArgumentOutOfRangeException(nameof(totalMinutes));
            TotalMinutes = totalMinutes;
        }

        public GameTime(int hour, int minute) : this(hour * 60 + minute)
        {
            if (hour is < 0 or > 23) throw new ArgumentOutOfRangeException(nameof(hour));
            if (minute is < 0 or > 59) throw new ArgumentOutOfRangeException(nameof(minute));
        }

        // Tells C# to automatically convert the struct to a double when needed & vice versa.
        // "int i = new GameTime(x);"
        // "GameTime t = x;"

        public static implicit operator int(GameTime time) => time.TotalMinutes;
        public static implicit operator GameTime(int totalMinutes) => new(totalMinutes);

        public override string ToString() => $"{Hour:00}:{Minute:00}";
    }
}

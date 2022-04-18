namespace CurrencyDotNet.Common
{
    public abstract class TimeProvider
    {
        private static TimeProvider _current = new DefaultTimeProvider();
        public static TimeProvider Current
        {
            get => _current;
            set => _current = value ?? 
                throw new ArgumentNullException(nameof(value));

        }
        public abstract DateTimeOffset UtcNow { get; }
        public static void ResetToDefault()
        {
            _current = new DefaultTimeProvider();
        }
    }
}

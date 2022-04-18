namespace CurrencyDotNet.Common
{
    public class DefaultTimeProvider : TimeProvider
    {
        public override DateTimeOffset UtcNow => DateTimeOffset.UtcNow;
    }
}

namespace CurrencyDotNet.Common.Services
{
    public class DefaultTimeProvider : TimeProvider
    {
        public override DateTimeOffset UtcNow => DateTimeOffset.UtcNow;
    }
}

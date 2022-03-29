using CurrencyDotNet.Common.Services;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    public class GetTradingLimitsRequest : IBaseRequest
    {
        /// <summary>
        /// Get all system limits.
        /// </summary>
        public string Symbol { get; set; }

        public override string ToString()
            => new UriQueryBuilder()
            .AddValue($"symbol={Symbol}")
            .GetQuery();
    }
}

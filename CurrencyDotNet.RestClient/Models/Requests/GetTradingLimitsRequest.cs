using CurrencyDotNet.Common.Services;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    public class GetTradingLimitsRequest : IRequestModel
    {
        /// <summary>
        /// Get all system limits.
        /// </summary>
        public string Symbol { get; set; }

        public string GetQueryString()
            => new UriQueryBuilder()
            .AddValue($"symbol={Symbol}")
            .GetQuery();
    }
}

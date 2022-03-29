using CurrencyDotNet.Common.Services;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    public class GetTicker24hrRequest : IRequestModel
    {
        /// <summary>
        /// 24 hour rolling window price change statistics. Careful when accessing this with no symbol.
        /// </summary>
        public string Symbol { get; set; }

        public string GetQueryString()
            => new UriQueryBuilder()
            .AddValue($"symbol={Symbol}")
            .GetQuery();
    }
}

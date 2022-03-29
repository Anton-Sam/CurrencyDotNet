using CurrencyDotNet.Common.Services;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    public class GetTicker24hrRequest : IBaseRequest
    {
        /// <summary>
        /// 24 hour rolling window price change statistics. Careful when accessing this with no symbol.
        /// </summary>
        public string Symbol { get; set; }

        public override string ToString()
            => new UriQueryBuilder()
            .AddValue($"symbol={Symbol}")
            .GetQuery();
    }
}

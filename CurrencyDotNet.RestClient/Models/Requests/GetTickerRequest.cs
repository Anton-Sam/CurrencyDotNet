using CurrencyDotNet.Common.Services;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// 24 hour rolling window price change statistics. Careful when accessing this with no symbol.
    /// </summary>
    public class GetTickerRequest : RequestModel
    {
        public string? Symbol { get; set; }

        public GetTickerRequest(string? symbol = null)
        {
            Symbol = symbol;
        }

        public string GetQueryString()
            => new UriQueryBuilder()
            .AddValue($"symbol={Symbol}")
            .GetQuery();
    }
}

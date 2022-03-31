using CurrencyDotNet.Common.Services;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// 24 hour rolling window price change statistics. Careful when accessing this with no symbol.
    /// </summary>
    public class GetTickerRequest : IRequestModel
    {
        public string? Symbol { get; set; }

        public GetTickerRequest(string symbol)
        {
            Symbol = symbol;
        }

        public string GetQueryString()
            => new UriQueryBuilder()
            .AddValue($"symbol={Symbol}")
            .GetQuery();
    }
}

using CurrencyDotNet.Common.Services;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Order book.
    /// </summary>
    public class GetOrderBookRequest : IRequestModel
    {
        public int Limit { get; set; }
        public string Symbol { get; set; }

        public string GetQueryString()
            => new UriQueryBuilder()
            .AddValue($"limit={Limit}")
            .AddValue($"symbol={Symbol}")
            .GetQuery();
    }
}

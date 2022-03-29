using CurrencyDotNet.Common.Services;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    public class GetOrderBookRequest : IRequestModel
    {
        /// <summary>
        /// Order book.
        /// </summary>
        public int Limit { get; set; }
        public string Symbol { get; set; }

        public string GetQueryString()
            => new UriQueryBuilder()
            .AddValue($"limit={Limit}")
            .AddValue($"symbol={Symbol}")
            .GetQuery();
    }
}

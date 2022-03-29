using CurrencyDotNet.Common.Services;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Get all closes postions within the account.
    /// </summary>
    public class GetTradingPositionsHistoryRequest : IRequestModel
    {
        public int RecvWindow { get; set; }
        public string Symbol { get; set; }
        public int Timestamp { get; set; }
        public string ApiKey { get; set; }
        public int Limit { get; set; }
        public string Signature { get; set; }

        public string GetQueryString()
            => new UriQueryBuilder()
            .AddValue($"recvWindow={RecvWindow}")
            .AddValue($"symbol={Symbol}")
            .AddValue($"timestamp={Timestamp}")
            .AddValue($"X-MBX-APIKEY={ApiKey}")
            .AddValue($"limit={Limit}")
            .AddValue($"signature={Signature}")
            .GetQuery();
    }
}

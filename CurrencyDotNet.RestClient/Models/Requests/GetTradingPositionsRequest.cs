using CurrencyDotNet.Common.Services;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Get all open trades within the account.
    /// </summary>
    public class GetTradingPositionsRequest : IRequestModel
    {
        public int RecvWindow { get; set; }
        public int Timestamp { get; set; }
        public string ApiKey { get; set; }
        public string Signature { get; set; }

        public string GetQueryString()
            => new UriQueryBuilder()
            .AddValue($"recvWindow={RecvWindow}")
            .AddValue($"timestamp={Timestamp}")
            .AddValue($"X-MBX-APIKEY={ApiKey}")
            .AddValue($"signature={Signature}")
            .GetQuery();
    }
}

using CurrencyDotNet.Common.Services;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Get current account information.
    /// </summary>
    public class GetAccountInfoRequest : IRequestModel
    {
        public int RecvWindow { get; set; }
        public int Timestamp { get; set; }
        public string ApiKey { get; set; }
        public bool ShowZeroBalance { get; set; }
        public string Signature { get; set; }

        public string GetQueryString()
            => new UriQueryBuilder()
            .AddValue($"recvWindow={RecvWindow}")
            .AddValue($"timestamp={Timestamp}")
            .AddValue($"X-MBX-APIKEY={ApiKey}")
            .AddValue($"showZeroBalance={ShowZeroBalance}")
            .AddValue($"signature={Signature}")
            .GetQuery();
    }
}

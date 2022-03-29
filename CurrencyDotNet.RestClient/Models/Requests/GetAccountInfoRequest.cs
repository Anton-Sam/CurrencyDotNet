using CurrencyDotNet.Common.Services;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Get current account information.
    /// </summary>
    public class GetAccountInfoRequest : IBaseRequest
    {
        public int RecvWindow { get; set; }
        public int Timestamp { get; set; }
        public string X_MBX_APIKEY { get; set; }
        public bool ShowZeroBalance { get; set; }
        public string Signature { get; set; }

        public override string ToString()
            => new UriQueryBuilder()
            .AddValue($"recvWindow={RecvWindow}")
            .AddValue($"timestamp={Timestamp}")
            .AddValue($"X-MBX-APIKEY={X_MBX_APIKEY}")
            .AddValue($"showZeroBalance={ShowZeroBalance}")
            .AddValue($"signature={Signature}")
            .GetQuery();
    }
}

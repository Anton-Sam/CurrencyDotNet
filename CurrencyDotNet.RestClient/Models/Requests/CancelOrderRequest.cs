using CurrencyDotNet.Common.Services;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Cancel an active order within exchange and leverage trading modes.
    /// </summary>
    public class CancelOrderRequest : IBaseRequest
    {
        public string OrderId { get; set; }
        public int RecvWindow { get; set; }
        public int Timestamp { get; set; }
        public string X_MBX_APIKEY { get; set; }
        public string Signature { get; set; }
        public string Symbol { get; set; }

        public override string ToString()
            => new UriQueryBuilder()
            .AddValue($"orderId={OrderId}")
            .AddValue($"recvWindow={RecvWindow}")
            .AddValue($"timestamp={Timestamp}")
            .AddValue($"X-MBX-APIKEY={X_MBX_APIKEY}")
            .AddValue($"signature={Signature}")
            .AddValue($"symbol={Symbol}")
            .GetQuery();
    }
}

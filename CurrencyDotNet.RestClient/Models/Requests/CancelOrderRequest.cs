using CurrencyDotNet.Common.Services;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Cancel an active order within exchange and leverage trading modes.
    /// </summary>
    public class CancelOrderRequest : IRequestModel
    {
        public string OrderId { get; set; }
        public int RecvWindow { get; set; }
        public int Timestamp { get; set; }
        public string ApiKey { get; set; }
        public string Signature { get; set; }
        public string Symbol { get; set; }

        public string GetQueryString()
            => new UriQueryBuilder()
            .AddValue($"orderId={OrderId}")
            .AddValue($"recvWindow={RecvWindow}")
            .AddValue($"timestamp={Timestamp}")
            .AddValue($"X-MBX-APIKEY={ApiKey}")
            .AddValue($"signature={Signature}")
            .AddValue($"symbol={Symbol}")
            .GetQuery();
    }
}

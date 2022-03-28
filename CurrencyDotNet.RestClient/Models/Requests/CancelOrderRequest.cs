using System.Text;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    public class CancelOrderRequest
    {
        public string OrderId { get; set; }
        public int RecvWindow { get; set; }
        public int Timestamp { get; set; }
        public string X_MBX_APIKEY { get; set; }
        public string Signature { get; set; }
        public string Symbol { get; set; }

        public override string ToString()
            => new StringBuilder()
            .Append($"orderId={OrderId}")
            .Append('&')
            .Append($"recvWindow={RecvWindow}")
            .Append('&')
            .Append($"timestamp={Timestamp}")
            .Append('&')
            .Append($"X-MBX-APIKEY={X_MBX_APIKEY}")
            .Append('&')
            .Append($"signature={Signature}")
            .Append('&')
            .Append($"symbol={Symbol}")
            .ToString();
    }
}

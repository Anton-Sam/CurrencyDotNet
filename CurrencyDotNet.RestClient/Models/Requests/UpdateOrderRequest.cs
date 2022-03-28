using System.Text;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    public class UpdateOrderRequest
    {
        public int ExpireTimestamp { get; set; }
        public bool GuaranteedStopLoss { get; set; }
        public decimal NewPrice { get; set; }
        public string OrderId { get; set; }
        public int RecvWindow { get; set; }
        public decimal StopLoss { get; set; }
        public decimal TakeProfit { get; set; }
        public int Timestamp { get; set; }
        public string X_MBX_APIKEY { get; set; }
        public string Signature { get; set; }

        public override string ToString()
            => new StringBuilder()
            .Append($"expireTimestamp={ExpireTimestamp}")
            .Append("&")
            .Append($"guaranteedStopLoss={GuaranteedStopLoss}")
            .Append("&")
            .Append($"newPrice={NewPrice}")
            .Append("&")
            .Append($"orderId={OrderId}")
            .Append("&")
            .Append($"recvWindow={RecvWindow}")
            .Append("&")
            .Append($"stopLoss={StopLoss}")
            .Append("&")
            .Append($"takeProfit={TakeProfit}")
            .Append("&")
            .Append($"timestamp={Timestamp}")
            .Append("&")
            .Append($"X-MBX-APIKEY={X_MBX_APIKEY}")
            .Append("&")
            .Append($"signature={Signature}")
            .ToString();
    }
}

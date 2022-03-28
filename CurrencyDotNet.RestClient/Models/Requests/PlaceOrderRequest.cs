using System.Text;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    public class PlaceOrderRequest
    {
        public string AccontId { get; set; }
        public int ExpireTimestamp { get; set; }
        public bool GuaranteedStopLoss { get; set; }
        public int Leverage { get; set; }
        public string NewOrderRespType { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public int RecvWindow { get; set; }
        public string Side { get; set; }
        public decimal StopLoss { get; set; }
        public string Symbol { get; set; }
        public decimal TakeProfit { get; set; }
        public int Timestamp { get; set; }
        public string Type { get; set; }
        public string X_MBX_APIKEY { get; set; }
        public string Signature { get; set; }

        public override string ToString()
            => new StringBuilder()
            .Append($"accountId={AccontId}")
            .Append('&')
            .Append($"expireTimestamp={ExpireTimestamp}")
            .Append('&')
            .Append($"guaranteedStopLoss={GuaranteedStopLoss}")
            .Append('&')
            .Append($"leverage={Leverage}")
            .Append('&')
            .Append($"newOrderRespType={NewOrderRespType}")
            .Append('&')
            .Append($"price={Price}")
            .Append('&')
            .Append($"quantity={Quantity}")
            .Append('&')
            .Append($"recvWindow={RecvWindow}")
            .Append('&')
            .Append($"side={Side}")
            .Append('&')
            .Append($"stopLoss={StopLoss}")
            .Append('&')
            .Append($"symbol={Symbol}")
            .Append('&')
            .Append($"takeProfit={TakeProfit}")
            .Append('&')
            .Append($"timestamp={Timestamp}")
            .Append('&')
            .Append($"type={Type}")
            .Append('&')
            .Append($"X-MBX-APIKEY={X_MBX_APIKEY}")
            .Append('&')
            .Append($"signature={Signature}")
            .ToString();
    }
}

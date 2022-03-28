using System.Text;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    public class UpdatePositionRequest
    {
        public bool GuaranteedStopLoss { get; set; }
        public string PositionId { get; set; }
        public string RecvWindow { get; set; }
        public decimal StopLoss { get; set; }
        public decimal TakeProfit { get; set; }
        public int Timestamp { get; set; }
        public string X_MBX_APIKEY { get; set; }
        public string Signature { get; set; }

        public override string ToString()
            => new StringBuilder()
            .Append($"guaranteedStopLoss={GuaranteedStopLoss}")
            .Append("&")
            .Append($"positionId={PositionId}")
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

using CurrencyDotNet.Common.Services;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// To edit current leverage trade by changing stop loss and take profit levels.
    /// </summary>
    public class UpdatePositionRequest : IRequestModel
    {
        public bool GuaranteedStopLoss { get; set; }
        public string PositionId { get; set; }
        public string RecvWindow { get; set; }
        public decimal StopLoss { get; set; }
        public decimal TakeProfit { get; set; }
        public int Timestamp { get; set; }
        public string ApiKey { get; set; }
        public string Signature { get; set; }

        public string GetQueryString()
            => new UriQueryBuilder()
            .AddValue($"guaranteedStopLoss={GuaranteedStopLoss}")
            .AddValue($"positionId={PositionId}")
            .AddValue($"recvWindow={RecvWindow}")
            .AddValue($"stopLoss={StopLoss}")
            .AddValue($"takeProfit={TakeProfit}")
            .AddValue($"timestamp={Timestamp}")
            .AddValue($"X-MBX-APIKEY={ApiKey}")
            .AddValue($"signature={Signature}")
            .GetQuery();
    }
}

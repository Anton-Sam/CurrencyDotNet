using CurrencyDotNet.Common.Services;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Close an active leverage trade.
    /// </summary>
    public class ClosePositionRequest : IRequestModel
    {
        public int RecvWindow { get; set; }
        public int Timestamp { get; set; }
        public string ApiKey { get; set; }
        public string PositionId { get; set; }
        public int StartTime { get; set; }

        public string GetQueryString()
            => new UriQueryBuilder()
            .AddValue($"recvWindow={RecvWindow}")
            .AddValue($"timestamp={Timestamp}")
            .AddValue($"X-MBX-APIKEY={ApiKey}")
            .AddValue($"positionId={PositionId}")
            .AddValue($"startTime={StartTime}")
            .GetQuery();
    }
}

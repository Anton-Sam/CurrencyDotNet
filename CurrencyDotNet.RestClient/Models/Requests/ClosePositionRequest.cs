using System.Text;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    public class ClosePositionRequest
    {
        public int RecvWindow { get; set; }
        public int Timestamp { get; set; }
        public string X_MBX_APIKEY { get; set; }
        public string PositionId { get; set; }
        public int StartTime { get; set; }

        public override string ToString()
            => new StringBuilder()
            .Append($"recvWindow={RecvWindow}")
            .Append('&')
            .Append($"timestamp={Timestamp}")
            .Append('&')
            .Append($"X-MBX-APIKEY={X_MBX_APIKEY}")
            .Append('&')
            .Append($"positionId={PositionId}")
            .Append('&')
            .Append($"startTime={StartTime}")
            .ToString();
    }
}

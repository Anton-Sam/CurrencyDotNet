using System.Text;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    public class GetAggregatedTradeHistoryRequest
    {
        public int EndTime { get; set; }
        public int Limit { get; set; }
        public int StartTime { get; set; }
        public string Symbol { get; set; }

        public override string ToString()
            => new StringBuilder()
            .Append($"endTime={EndTime}")
            .Append('&')
            .Append($"limit={Limit}")
            .Append('&')
            .Append($"startTime={StartTime}")
            .Append('&')
            .Append($"symbol ={Symbol}")
            .ToString();
    }
}

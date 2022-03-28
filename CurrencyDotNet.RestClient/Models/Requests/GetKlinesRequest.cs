using System.Text;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    public class GetKlinesRequest
    {
        public int EndTime { get; set; }
        public string Interval { get; set; }
        public int Limit { get; set; }
        public int StartTime { get; set; }
        public string Symbol { get; set; }
        public string Type { get; set; }

        public override string ToString()
            => new StringBuilder()
            .Append($"endTime={EndTime}")
            .Append('&')
            .Append($"interval ={Interval}")
            .Append('&')
            .Append($"limit={Limit}")
            .Append('&')
            .Append($"startTime={StartTime}")
            .Append('&')
            .Append($"symbol={Symbol}")
            .Append('&')
            .Append($"type={Type}")
            .ToString();
    }
}

using CurrencyDotNet.Common.Services;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    public class GetKlinesRequest : IBaseRequest
    {
        /// <summary>
        /// Kline/candlestick bars for a symbol. Klines are uniquely identified by their open time.
        /// </summary>
        public int EndTime { get; set; }
        public string Interval { get; set; }
        public int Limit { get; set; }
        public int StartTime { get; set; }
        public string Symbol { get; set; }
        public string Type { get; set; }

        public override string ToString()
            => new UriQueryBuilder()
            .AddValue($"endTime={EndTime}")
            .AddValue($"interval ={Interval}")
            .AddValue($"limit={Limit}")
            .AddValue($"startTime={StartTime}")
            .AddValue($"symbol={Symbol}")
            .AddValue($"type={Type}")
            .GetQuery();
    }
}

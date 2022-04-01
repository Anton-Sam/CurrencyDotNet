using CurrencyDotNet.RestClient.Models.Requests.Abstractions;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Kline/candlestick bars for a symbol. Klines are uniquely identified by their open time.
    /// </summary>
    internal class GetKlinesRequest : RequestModel
    {   
        public int EndTime { get; set; }
        public string Interval { get; set; }
        public int Limit { get; set; }
        public int StartTime { get; set; }
        public string Symbol { get; set; }
        public string Type { get; set; }
    }
}

using CurrencyDotNet.RestClient.Interfaces;
using System.Text.Json.Serialization;

namespace CurrencyDotNet.RestClient.Models.Responses
{
    public class Ticker : IResponseModel
    {
        /// <summary>
        /// Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }
        /// <summary>
        /// Price change
        /// </summary>
        [JsonPropertyName("priceChange")]
        public decimal PriceChange { get; set; }
        /// <summary>
        /// Percent price change
        /// </summary>
        [JsonPropertyName("priceChangePercent")]
        public decimal PriceChangePercent { get; set; }
        /// <summary>
        /// Weighted average price
        /// </summary>
        [JsonPropertyName("weightedAvgPrice")]
        public decimal WeightedAveragePrice { get; set; }
        /// <summary>
        /// Last price
        /// </summary>
        [JsonPropertyName("lastPrice")]
        public decimal LastPrice { get; set; }
        /// <summary>
        /// Last quantity
        /// </summary>
        [JsonPropertyName("lastQty")]
        public decimal LastQty { get; set; }
        /// <summary>
        /// Best bid price
        /// </summary>
        [JsonPropertyName("bidPrice")]
        public decimal BidPrice { get; set; }
        /// <summary>
        /// Best ask price
        /// </summary>
        [JsonPropertyName("askPrice")]
        public decimal AskPrice { get; set; }
        /// <summary>
        /// Open price
        /// </summary>
        [JsonPropertyName("openPrice")]
        public decimal OpenPrice { get; set; }
        /// <summary>
        /// Highest price in 24 hours
        /// </summary>
        [JsonPropertyName("highPrice")]
        public decimal HighPrice { get; set; }
        /// <summary>
        /// Lowest price in 24 hours
        /// </summary>
        [JsonPropertyName("lowPrice")]
        public decimal LowPrice { get; set; }
        /// <summary>
        /// Base asset volume in 24 hours
        /// </summary>
        [JsonPropertyName("volume")]
        public decimal Volume { get; set; }
        /// <summary>
        /// Quote asser volume in 24 hours
        /// </summary>
        [JsonPropertyName("quoteVolume")]
        public decimal QuoteVolume { get; set; }
        /// <summary>
        /// Open date and time in milliseconds unix format
        /// </summary>
        [JsonPropertyName("openTime")]
        public long UnixOpenTime { get; set; }
        /// <summary>
        /// Close date and time in milliseconds unix format
        /// </summary>
        [JsonPropertyName("closeTime")]
        public long UnixCloseTime { get; set; }
        /// <summary>
        /// Open date and time
        /// </summary>
        public DateTimeOffset OpenTime =>
            DateTimeOffset.FromUnixTimeMilliseconds(UnixOpenTime);
        /// <summary>
        /// Close date and time
        /// </summary>
        public DateTimeOffset CloseTime =>
            DateTimeOffset.FromUnixTimeMilliseconds(UnixCloseTime);
    }
}

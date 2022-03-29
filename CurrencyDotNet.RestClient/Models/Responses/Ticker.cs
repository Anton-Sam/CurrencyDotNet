using System.Text.Json.Serialization;

namespace CurrencyDotNet.RestClient.Models.Responses
{
    public class Ticker
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }
        [JsonPropertyName("priceChange")]
        public decimal PriceChange { get; set; }
        [JsonPropertyName("priceChangePercent")]
        public decimal PriceChangePercent { get; set; }
        [JsonPropertyName("weightedAvgPrice")]
        public decimal WeightedAveragePrice { get; set; }
        [JsonPropertyName("lastPrice")]
        public decimal LastPrice { get; set; }
        [JsonPropertyName("lastQty")]
        public decimal LastQty { get; set; }
        [JsonPropertyName("bidPrice")]
        public decimal BidPrice { get; set; }
        [JsonPropertyName("askPrice")]
        public decimal AskPrice { get; set; }
        [JsonPropertyName("openPrice")]
        public decimal OpenPrice { get; set; }
        [JsonPropertyName("highPrice")]
        public decimal HighPrice { get; set; }
        [JsonPropertyName("lowPrice")]
        public decimal LowPrice { get; set; }
        [JsonPropertyName("volume")]
        public decimal Volume { get; set; }
        [JsonPropertyName("quoteVolume")]
        public decimal QuoteVolume { get; set; }
        public DateTime OpenTime {
            get
            {
                return DateTime.Now;
            } 
            set 
            {

            } 
        }
        public DateTime CloseTime { get; set; }
    }
}

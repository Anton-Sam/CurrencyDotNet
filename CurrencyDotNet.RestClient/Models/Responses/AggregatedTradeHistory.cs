using System.Text.Json.Serialization;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Responses
{
    public class AggregatedTradeHistory : IResponseModel
    {
        /// <summary>
        /// Timestamp
        /// </summary>
        [JsonPropertyName("T")]
        int Timestamp { get; set; }

        /// <summary>
        /// Aggregate tradeId
        /// </summary>
        [JsonPropertyName("a")]
        int TradeId { get; set; }

        /// <summary>
        /// Was the buyer the maker
        /// </summary>
        [JsonPropertyName("m")]
        bool IsMaker { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        [JsonPropertyName("p")]
        string Price { get; set; }

        /// <summary>
        /// Quantity (should be ignored)
        /// </summary>
        [JsonPropertyName("q")]
        string Quantity { get; set; }
    }
}

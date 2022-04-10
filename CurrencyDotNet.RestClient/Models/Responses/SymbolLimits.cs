using CurrencyDotNet.RestClient.Interfaces;
using System.Text.Json.Serialization;

namespace CurrencyDotNet.RestClient.Models.Responses
{
    public class SymbolLimits : IResponseModel
    {
        /// <summary>
        /// Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }
        /// <summary>
        /// Full name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
        /// <summary>
        /// Last price of the symbol
        /// </summary>
        [JsonPropertyName("lastPrice")]
        public decimal LastPrice { get; set; }
        /// <summary>
        /// Minimum lot size
        /// </summary>
        [JsonPropertyName("minVolume")]
        public decimal MinLotSize { get; set; }
        /// <summary>
        /// Maximum lot size
        /// </summary>
        [JsonPropertyName("maxVolume")]
        public decimal MaxLotSize { get; set; }
        /// <summary>
        /// Minimum step of the lot size
        /// </summary>
        [JsonPropertyName("minStep")]
        public decimal MinLotSizeStep { get; set; }
        /// <summary>
        /// Price tick size
        /// </summary>
        [JsonPropertyName("tickSize")]
        public decimal PriceTickSize { get; set; }
    }
}

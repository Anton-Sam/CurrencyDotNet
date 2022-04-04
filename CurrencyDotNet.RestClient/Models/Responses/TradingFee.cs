using CurrencyDotNet.RestClient.Interfaces;
using System.Text.Json.Serialization;

namespace CurrencyDotNet.RestClient.Models.Responses
{
    public class TradingFee : IResponseModel
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
        /// Fee
        /// </summary>
        [JsonPropertyName("fee")]
        public decimal Fee { get; set; }
    }
}

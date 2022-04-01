using System.Text.Json.Serialization;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Responses
{
    public class OrderBook : IResponseModel
    {
        [JsonPropertyName("lastUpdateId")]
        int LastUpdateId { get; set; }

        [JsonPropertyName("lastUpdateId")]
        IEnumerable<IEnumerable<string>> Asks { get; set; }

        [JsonPropertyName("lastUpdateId")]
        IEnumerable<IEnumerable<string>> Bids { get; set; }
    }
}

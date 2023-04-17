using CurrencyDotNet.RestClient.Interfaces;
using System.Text.Json.Serialization;

namespace CurrencyDotNet.RestClient.Models.Responses
{
    public class TradingPositions : IResponseModel
    {
        [JsonPropertyName("positions")]
        public IEnumerable<TradingPosition> Positions { get; set; }
    }
}

using CurrencyDotNet.RestClient.Models.Requests.Abstractions;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Get all system limits.
    /// </summary>
    internal class GetSymbolLimitsRequest : RequestModel
    {
        public string Symbol { get; set; }
        public GetSymbolLimitsRequest(string? symbol = null)
        {
            Symbol = symbol;
        }
    }
}

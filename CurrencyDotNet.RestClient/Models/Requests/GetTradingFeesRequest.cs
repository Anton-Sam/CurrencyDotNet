using CurrencyDotNet.RestClient.Models.Requests.Abstractions;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Get all system fees.
    /// </summary>
    internal class GetTradingFeesRequest : RequestModel
    {
        public string Symbol { get; set; }

        public GetTradingFeesRequest(string? symbol = null)
        {
            Symbol = symbol;
        }
    }
}

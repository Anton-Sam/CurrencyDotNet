using CurrencyDotNet.RestClient.Interfaces;
using CurrencyDotNet.RestClient.Models.Requests.Abstractions;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Get all system fees.
    /// </summary>
    internal class GetTradingFeesRequest : RequestModel, IRequestModel
    {
        public string Symbol { get; set; }
    }
}

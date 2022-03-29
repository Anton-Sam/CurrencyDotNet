using CurrencyDotNet.RestClient.Interfaces;
using CurrencyDotNet.RestClient.Models.Requests.Abstractions;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Get all system limits.
    /// </summary>
    internal class GetTradingLimitsRequest : RequestModel, IRequestModel
    {
        public string Symbol { get; set; }
    }
}

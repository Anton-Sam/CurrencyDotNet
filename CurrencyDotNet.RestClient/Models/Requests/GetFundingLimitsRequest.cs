using CurrencyDotNet.RestClient.Interfaces;
using CurrencyDotNet.RestClient.Models.Requests.Abstractions;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Get all system Funding limits.
    /// </summary>
    internal class GetFundingLimitsRequest : RequestModel, IRequestModel
    {
        public int RecvWindow { get; set; }
        public int Timestamp { get; set; }
        public string ApiKey { get; set; }
        public string Signature { get; set; }
    }
}

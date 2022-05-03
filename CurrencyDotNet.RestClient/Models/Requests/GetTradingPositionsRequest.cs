using CurrencyDotNet.RestClient.Models.Requests.Abstractions;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Get all open trades within the account.
    /// </summary>
    internal class GetTradingPositionsRequest : PrivateRequestModel
    {
        public GetTradingPositionsRequest(string apiKey) : base(apiKey)
        {}
    }
}

using CurrencyDotNet.RestClient.Models.Requests.Abstractions;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Get all closes postions within the account.
    /// </summary>
    internal class GetTradingPositionsHistoryRequest : RequestModel
    {
        public int RecvWindow { get; set; }
        public string Symbol { get; set; }
        public int Timestamp { get; set; }
        public string ApiKey { get; set; }
        public int Limit { get; set; }
        public string Signature { get; set; }
    }
}

using CurrencyDotNet.RestClient.Models.Requests.Abstractions;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Get ledger by limit.
    /// </summary>
    internal class GetLedgersRequest : RequestModel
    {
        public int RecvWindow { get; set; }
        public int Timestamp { get; set; }
        public string ApiKey { get; set; }
        public int EndTime { get; set; }
        public int Limit { get; set; }
        public string Signature { get; set; }
        public int StartTime { get; set; }
    }
}

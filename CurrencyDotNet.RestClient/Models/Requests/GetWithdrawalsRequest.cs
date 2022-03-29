using CurrencyDotNet.RestClient.Interfaces;
using CurrencyDotNet.RestClient.Models.Requests.Abstractions;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Get withdrawals for user.
    /// </summary>
    internal class GetWithdrawalsRequest : RequestModel, IRequestModel
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

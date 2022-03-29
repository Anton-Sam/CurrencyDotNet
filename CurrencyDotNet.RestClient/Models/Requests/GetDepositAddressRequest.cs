using CurrencyDotNet.RestClient.Interfaces;
using CurrencyDotNet.RestClient.Models.Requests.Abstractions;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Get deposit address by coin.
    /// </summary>
    internal class GetDepositAddressRequest : RequestModel, IRequestModel
    {
        public int RecvWindow { get; set; }
        public int Timestamp { get; set; }
        public string ApiKey { get; set; }
        public string Coin { get; set; }
        public string Signature { get; set; }
    }
}

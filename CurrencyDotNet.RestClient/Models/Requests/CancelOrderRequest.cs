using CurrencyDotNet.RestClient.Interfaces;
using CurrencyDotNet.RestClient.Models.Requests.Abstractions;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Cancel an active order within exchange and leverage trading modes.
    /// </summary>
    internal class CancelOrderRequest : RequestModel, IRequestModel
    {
        public string OrderId { get; set; }
        public int RecvWindow { get; set; }
        public int Timestamp { get; set; }
        public string ApiKey { get; set; }
        public string Signature { get; set; }
        public string Symbol { get; set; }
    }
}

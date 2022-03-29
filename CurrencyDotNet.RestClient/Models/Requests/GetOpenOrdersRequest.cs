using CurrencyDotNet.RestClient.Interfaces;
using CurrencyDotNet.RestClient.Models.Requests.Abstractions;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Get all open orders within exchange and leverage trading modes on a symbol. Careful when accessing this with no symbol.
    /// </summary>
    internal class GetOpenOrdersRequest : RequestModel, IRequestModel
    {
        public int RecvWindow { get; set; }
        public string Symbol { get; set; }
        public int Timestamp { get; set; }
        public string ApiKey { get; set; }
        public string Signature { get; set; }
    }
}

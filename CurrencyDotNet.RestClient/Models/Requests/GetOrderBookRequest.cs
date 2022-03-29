using CurrencyDotNet.RestClient.Interfaces;
using CurrencyDotNet.RestClient.Models.Requests.Abstractions;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Order book.
    /// </summary>
    internal class GetOrderBookRequest : RequestModel, IRequestModel
    {
        public int Limit { get; set; }
        public string Symbol { get; set; }
    }
}

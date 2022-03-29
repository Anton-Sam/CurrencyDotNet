using CurrencyDotNet.RestClient.Interfaces;
using CurrencyDotNet.RestClient.Models.Requests.Abstractions;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Edit current leverage orders by changing take profit and stop loss levels.
    /// </summary>
    internal class UpdateOrderRequest : RequestModel, IRequestModel
    {
        public int ExpireTimestamp { get; set; }
        public bool GuaranteedStopLoss { get; set; }
        public decimal NewPrice { get; set; }
        public string OrderId { get; set; }
        public int RecvWindow { get; set; }
        public decimal StopLoss { get; set; }
        public decimal TakeProfit { get; set; }
        public int Timestamp { get; set; }
        public string ApiKey { get; set; }
        public string Signature { get; set; }
    }
}

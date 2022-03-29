using CurrencyDotNet.RestClient.Interfaces;
using CurrencyDotNet.RestClient.Models.Requests.Abstractions;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// To edit current leverage trade by changing stop loss and take profit levels.
    /// </summary>
    internal class UpdatePositionRequest : RequestModel, IRequestModel
    {
        public bool GuaranteedStopLoss { get; set; }
        public string PositionId { get; set; }
        public string RecvWindow { get; set; }
        public decimal StopLoss { get; set; }
        public decimal TakeProfit { get; set; }
        public int Timestamp { get; set; }
        public string ApiKey { get; set; }
        public string Signature { get; set; }
    }
}

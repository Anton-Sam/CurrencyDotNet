using CurrencyDotNet.RestClient.Interfaces;
using CurrencyDotNet.RestClient.Models.Requests.Abstractions;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Close an active leverage trade.
    /// </summary>
    internal class ClosePositionRequest : RequestModel, IRequestModel
    {
        public int RecvWindow { get; set; }
        public int Timestamp { get; set; }
        public string ApiKey { get; set; }
        public string PositionId { get; set; }
        public int StartTime { get; set; }
    }
}

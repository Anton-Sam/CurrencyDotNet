using CurrencyDotNet.RestClient.Models.Requests.Abstractions;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Get compressed, aggregate trades. Trades that fill at the same time, from the same order, with the same price will have the quantity aggregated.
    /// </summary>
    internal class GetAggregatedTradeHistoryRequest : RequestModel
    {
        string Symbol { get; set; }
        int? Limit { get; set; }
        long? StartTime { get; set; }
        long? EndTime { get; set; }

        public GetAggregatedTradeHistoryRequest(string symbol,
            int? limit = null,
            long? endTime = null,
            long? startTime = null)
        {
            Symbol = symbol;
            Limit = limit;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}

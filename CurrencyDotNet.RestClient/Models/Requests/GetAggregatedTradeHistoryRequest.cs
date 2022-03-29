using CurrencyDotNet.Common.Services;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Get compressed, aggregate trades. Trades that fill at the same time, from the same order, with the same price will have the quantity aggregated.
    /// </summary>
    internal class GetAggregatedTradeHistoryRequest : IRequestModel
    {
        int EndTime { get; set; }
        int Limit { get; set; }
        int StartTime { get; set; }
        string Symbol { get; set; }

        public GetAggregatedTradeHistoryRequest(int endTime,
            int limit,
            int startTime,
            string symbol)
        {
            EndTime = endTime;
            Limit = limit;
            StartTime = startTime;
            Symbol = symbol;
        }

        public string GetQueryString()
            => new UriQueryBuilder()
            .AddValue($"endTime={EndTime}")
            .AddValue($"limit={Limit}")
            .AddValue($"startTime={StartTime}")
            .AddValue($"symbol ={Symbol}")
            .GetQuery();
    }
}

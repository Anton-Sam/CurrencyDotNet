using CurrencyDotNet.Common.Services;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Get compressed, aggregate trades. Trades that fill at the same time, from the same order, with the same price will have the quantity aggregated.
    /// </summary>
    public class GetAggregatedTradeHistoryRequest : IBaseRequest
    {
        public int EndTime { get; set; }
        public int Limit { get; set; }
        public int StartTime { get; set; }
        public string Symbol { get; set; }

        public override string ToString()
            => new UriQueryBuilder()
            .AddValue($"endTime={EndTime}")
            .AddValue($"limit={Limit}")
            .AddValue($"startTime={StartTime}")
            .AddValue($"symbol ={Symbol}")
            .GetQuery();
    }
}

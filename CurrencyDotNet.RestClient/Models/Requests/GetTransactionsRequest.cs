﻿using CurrencyDotNet.Common.Services;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Get transactions by limit and sinceTime.
    /// </summary>
    public class GetTransactionsRequest : IBaseRequest
    {
        public int RecvWindow { get; set; }
        public int Timestamp { get; set; }
        public string X_MBX_APIKEY { get; set; }
        public int EndTime { get; set; }
        public int Limit { get; set; }
        public string Signature { get; set; }
        public int StartTime { get; set; }

        public override string ToString()
            => new UriQueryBuilder()
            .AddValue($"recvWindow={RecvWindow}")
            .AddValue($"timestamp={Timestamp}")
            .AddValue($"X-MBX-APIKEY={X_MBX_APIKEY}")
            .AddValue($"endTime={EndTime}")
            .AddValue($"signature={Signature}")
            .AddValue($"startTime={StartTime}")
            .GetQuery();
    }
}

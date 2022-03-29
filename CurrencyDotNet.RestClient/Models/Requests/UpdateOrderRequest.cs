﻿using CurrencyDotNet.Common.Services;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    /// <summary>
    /// Edit current leverage orders by changing take profit and stop loss levels.
    /// </summary>
    public class UpdateOrderRequest : IBaseRequest
    {
        public int ExpireTimestamp { get; set; }
        public bool GuaranteedStopLoss { get; set; }
        public decimal NewPrice { get; set; }
        public string OrderId { get; set; }
        public int RecvWindow { get; set; }
        public decimal StopLoss { get; set; }
        public decimal TakeProfit { get; set; }
        public int Timestamp { get; set; }
        public string X_MBX_APIKEY { get; set; }
        public string Signature { get; set; }

        public override string ToString()
            => new UriQueryBuilder()
            .AddValue($"expireTimestamp={ExpireTimestamp}")
            .AddValue($"guaranteedStopLoss={GuaranteedStopLoss}")
            .AddValue($"newPrice={NewPrice}")
            .AddValue($"orderId={OrderId}")
            .AddValue($"recvWindow={RecvWindow}")
            .AddValue($"stopLoss={StopLoss}")
            .AddValue($"takeProfit={TakeProfit}")
            .AddValue($"timestamp={Timestamp}")
            .AddValue($"X-MBX-APIKEY={X_MBX_APIKEY}")
            .AddValue($"signature={Signature}")
            .GetQuery();
    }
}

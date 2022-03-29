using CurrencyDotNet.Common.Services;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    public class PlaceOrderRequest : IRequestModel
    {
        /// <summary>
        /// To create a market or limit order in the exchange trading mode, and market, limit or stop order in the leverage trading mode.\n
        /// Please note that to open an order within the ‘leverage’ trading mode symbolLeverage should be used and additional accountId parameter should be mentioned in the request.
        /// </summary>
        public string AccountId { get; set; }
        public int ExpireTimestamp { get; set; }
        public bool GuaranteedStopLoss { get; set; }
        public int Leverage { get; set; }
        public string NewOrderRespType { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public int RecvWindow { get; set; }
        public string Side { get; set; }
        public decimal StopLoss { get; set; }
        public string Symbol { get; set; }
        public decimal TakeProfit { get; set; }
        public int Timestamp { get; set; }
        public string Type { get; set; }
        public string ApiKey { get; set; }
        public string Signature { get; set; }

        public string GetQueryString()
            => new UriQueryBuilder()
            .AddValue($"accountId={AccountId}")
            .AddValue($"expireTimestamp={ExpireTimestamp}")
            .AddValue($"guaranteedStopLoss={GuaranteedStopLoss}")
            .AddValue($"leverage={Leverage}")
            .AddValue($"newOrderRespType={NewOrderRespType}")
            .AddValue($"price={Price}")
            .AddValue($"quantity={Quantity}")
            .AddValue($"recvWindow={RecvWindow}")
            .AddValue($"side={Side}")
            .AddValue($"stopLoss={StopLoss}")
            .AddValue($"symbol={Symbol}")
            .AddValue($"takeProfit={TakeProfit}")
            .AddValue($"timestamp={Timestamp}")
            .AddValue($"type={Type}")
            .AddValue($"X-MBX-APIKEY={ApiKey}")
            .AddValue($"signature={Signature}")
            .GetQuery();
    }
}

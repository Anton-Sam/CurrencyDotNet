using CurrencyDotNet.Common.Enums;
using CurrencyDotNet.RestClient.Interfaces;
using System.Text.Json.Serialization;

namespace CurrencyDotNet.RestClient.Models.Responses
{
    public class TradingPosition : IResponseModel
    {
        [JsonPropertyName("accountId")]
        public string AccountId { get; set; }
        [JsonPropertyName("closePrice")]
        public decimal ClosePrice { get; set; }
        [JsonPropertyName("closeQuantity")]
        public decimal CloseQuantity { get; set; }
        [JsonPropertyName("closeTimestamp")]
        public long CloseTimestamp { get; set; }
        [JsonPropertyName("cost")]
        public decimal Cost { get; set; }
        [JsonPropertyName("createdTimestamp")]
        public long CreatedTimestamp { get; set; }
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
        [JsonPropertyName("dividend")]
        public decimal Dividend { get; set; }
        [JsonPropertyName("fee")]
        public decimal Fee { get; set; }
        [JsonPropertyName("guaranteedStopLoss")]
        public bool GuaranteedStopLoss { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("instrumentId")]
        public string InstrumentId { get; set; }
        [JsonPropertyName("margin")]
        public decimal Margin { get; set; }
        [JsonPropertyName("margin")]
        public decimal OpenPrice { get; set; }
        [JsonPropertyName("openQuantity")]
        public decimal OpenQuantity { get; set; }
        [JsonPropertyName("openTimestamp")]
        public long OpenTimestamp { get; set; }
        [JsonPropertyName("orderId")]
        public string OrderId { get; set; }
        [JsonPropertyName("rpl")]
        public decimal Rpl { get; set; }
        [JsonPropertyName("rplConverted")]
        public decimal RplConverted { get; set; }
        [JsonPropertyName("state")]
        public PositionState State { get; set; }
        [JsonPropertyName("stopLoss")]
        public decimal StopLoss { get; set; }
        [JsonPropertyName("swap")]
        public decimal Swap { get; set; }
        [JsonPropertyName("swapConverted")]
        public decimal SwapConverted { get; set; }
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }
        [JsonPropertyName("takeProfit")]
        public decimal TakeProfit { get; set; }
        [JsonPropertyName("upl")]
        public decimal Upl { get; set; }
        [JsonPropertyName("uplConverted")]
        public decimal UplConverted { get; set; }
    }
}

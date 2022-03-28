using System.Text;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    public class GetTradingLimitsRequest
    {
        public string Symbol { get; set; }

        public override string ToString()
            => new StringBuilder()
            .Append($"symbol={Symbol}")
            .ToString();
    }
}

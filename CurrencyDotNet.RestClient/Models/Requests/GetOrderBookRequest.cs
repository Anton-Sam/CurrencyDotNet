using System.Text;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    public class GetOrderBookRequest
    {
        public int Limit { get; set; }
        public string Symbol { get; set; }

        public override string ToString()
            => new StringBuilder()
            .Append($"limit={Limit}")
            .Append('&')
            .Append($"symbol={Symbol}")
            .ToString();
    }
}

using CurrencyDotNet.Common.Services;
using CurrencyDotNet.RestClient.Interfaces;

namespace CurrencyDotNet.RestClient.Models.Requests
{
    public class GetOpenOrdersRequest : IBaseRequest
    {
        /// <summary>
        /// Get all open orders within exchange and leverage trading modes on a symbol. Careful when accessing this with no symbol.
        /// </summary>
        public int RecvWindow { get; set; }
        public string Symbol { get; set; }
        public int Timestamp { get; set; }
        public string X_MBX_APIKEY { get; set; }
        public string Signature { get; set; }

        public override string ToString()
            => new UriQueryBuilder()
            .AddValue($"recvWindow={RecvWindow}")
            .AddValue($"symbol={Symbol}")
            .AddValue($"timestamp={Timestamp}")
            .AddValue($"X-MBX-APIKEY={X_MBX_APIKEY}")
            .AddValue($"signature={Signature}")
            .GetQuery();
    }
}

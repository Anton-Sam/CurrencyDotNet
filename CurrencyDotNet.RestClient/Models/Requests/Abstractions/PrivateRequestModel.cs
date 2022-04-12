using CurrencyDotNet.Common.Extensions;

namespace CurrencyDotNet.RestClient.Models.Requests.Abstractions
{
    public class PrivateRequestModel : RequestModel
    {
        public int RecvWindow { get; set; }
        public long Timestamp { get; private set; }
        private readonly string _apiKey;
        public PrivateRequestModel(string apiKey) =>
            _apiKey = apiKey;

        public new string GetQueryString()
        {
            Timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            var requestString = base.GetQueryString();
            return string.Concat(requestString, "&signature=", requestString.HmacSha256(_apiKey));
        }

    }
}

using System.Text.Json.Serialization;

namespace CurrencyDotNet.RestClient.Models.Responses
{
    public class Error
    {
        [JsonPropertyName("status")]
        public int Status { get; internal set; }

        [JsonPropertyName("error")]
        public string ErrorDescription { get; internal set; }

        [JsonPropertyName("message")]
        public string Message { get; internal set; }

        [JsonPropertyName("path")]
        public string RequestPath { get; internal set; }

        [JsonPropertyName("timestamp")]
        public int Timestamp { get; internal set; }
    }
}

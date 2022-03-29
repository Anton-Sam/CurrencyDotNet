using CurrencyDotNet.RestClient.Interfaces;
using System.Text;
using System.Text.Json;

namespace CurrencyDotNet.RestClient
{
    public class RestApiProvider : IRestApiProvider
    {
        private readonly HttpClient _httpClient;

        public RestApiProvider()
        {
            _httpClient = new HttpClient();
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }

        public async Task<T> GetRequestAsync<T>(string requestUri,
            IRequestModel requestModel,
            CancellationToken token = default)
        {
            var response = await _httpClient.GetAsync(
                requestUri: requestModel.GetQueryString(),
                cancellationToken: token);

            return await ParseResponse<T>(response);
        }

        public async Task<T> PostRequestAsync<T>(string requestUri,
            IRequestModel requestModel,
            CancellationToken token)
        {
            var requestContent = new StringContent(
                content: requestModel.GetQueryString(),
                encoding: Encoding.UTF8,
                mediaType: "application/x-www-form-urlencoded");

            var response = await _httpClient.PostAsync(
                requestUri: requestUri,
                content: requestContent,
                cancellationToken: token);

            return await ParseResponse<T>(response);
        }

        private async Task<T> ParseResponse<T>(HttpResponseMessage response)
        {
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<T>(content);

            return result;
        }
    }
}

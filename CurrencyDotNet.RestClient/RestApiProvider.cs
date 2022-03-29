using System.Text;
using System.Text.Json;
using CurrencyDotNet.RestClient.Interfaces;
using CurrencyDotNet.RestClient.Models.Responses;
using CurrencyDotNet.RestClient.Models.Responses.Abstractions;

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

        public async Task<CallResult<T>> GetRequestAsync<T>(IRequestModel requestModel,
            CancellationToken token = default)
        {
            var response = await _httpClient.GetAsync(
                requestUri: requestModel.GetQueryString(),
                cancellationToken: token);

            return await ParseResponse<T>(response);
        }

        public async Task<CallResult<T>> PostRequestAsync<T>(IRequestModel requestModel,
            CancellationToken token)
        {
            var requestContent = new StringContent(
                content: requestModel.GetQueryString(),
                encoding: Encoding.UTF8,
                mediaType: "application/x-www-form-urlencoded");

            var response = await _httpClient.PostAsync(
                requestUri: requestModel.GetQueryString(),
                content: requestContent,
                cancellationToken: token);

            return await ParseResponse<T>(response);
        }

        private async Task<CallResult<T>> ParseResponse<T>(HttpResponseMessage response)
        {
            var content = await response.Content.ReadAsStringAsync();

            return response.IsSuccessStatusCode ? 
                new CallResult<T>(JsonSerializer.Deserialize<T>(content)) : 
                new CallResult<T>(JsonSerializer.Deserialize<Error>(content));
        }
    }
}

﻿using System.Text;
using System.Text.Json;
using CurrencyDotNet.Common.Enums;
using CurrencyDotNet.RestClient.Requests.Abstractions;
using CurrencyDotNet.RestClient.Responses.Abstractions;

namespace CurrencyDotNet.RestClient.Common;

internal class RestApiProvider : IRestApiProvider
{
    private readonly HttpClient _httpClient;

    public RestApiProvider(ClientMode clientMode, ApiVersion apiVersion)
    {
        _httpClient = new HttpClient();
    }

    public void Dispose()
    {
        _httpClient?.Dispose();
    }

    public async Task<CallResult<T>> GetRequestAsync<T>(Request requestModel,
        CancellationToken token = default)
    {
        var response = await _httpClient.GetAsync(
            requestUri: requestModel.GetQueryString(),
            cancellationToken: token);

        return await ParseResponse<T>(response);
    }

    public Task<CallResult<T>> GetRequestAsync<T>(PrivateRequest request, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public async Task<CallResult<T>> PostRequestAsync<T>(Request requestModel,
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

    public Task<CallResult<T>> PostRequestAsync<T>(PrivateRequest request, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    private async Task<CallResult<T>> ParseResponse<T>(HttpResponseMessage response)
    {
        var content = await response.Content.ReadAsStringAsync();

        return response.IsSuccessStatusCode ?
            new CallResult<T>(JsonSerializer.Deserialize<T>(content)) :
            new CallResult<T>(JsonSerializer.Deserialize<Error>(content));
    }
}
